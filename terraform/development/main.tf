provider "aws" {
  region  = "eu-west-2"
  version = "~> 2.0"
}
data "aws_caller_identity" "current" {}
data "aws_region" "current" {}
locals {
   parameter_store = "arn:aws:ssm:${data.aws_region.current.name}:${data.aws_caller_identity.current.account_id}:parameter"
}

data "aws_iam_role" "ec2_container_service_role" {
  name = "ecsServiceRole"
}

data "aws_iam_role" "ecs_task_execution_role" {
  name = "ecsTaskExecutionRole"
}

terraform {
  backend "s3" {
    bucket  = "terraform-state-development-apis"
    encrypt = true
    region  = "eu-west-2"
    key     = "services/resident-vulnerabilities-api/state"
  }
}

/*    POSTGRES SET UP    */
data "aws_vpc" "development_vpc" {
  tags = {
    Name = "vpc-development-apis-development"
  }
}
data "aws_subnet_ids" "development_private_subnets" {
  vpc_id = data.aws_vpc.development_vpc.id
  filter {
    name   = "tag:Type"
    values = ["private"]
  }
}
//database to be used for development purposes, not for DMS
module "postgres_db_development" {
  source = "github.com/LBHackney-IT/aws-hackney-common-terraform.git//modules/database/postgres"
  environment_name = "development"
  vpc_id = data.aws_vpc.development_vpc.id
  db_engine = "postgres"
  db_engine_version = "11.1"
  db_identifier = "vulnerabilities-dev-db"
  db_instance_class = "db.t2.micro"
  db_name = "vulnerabilities_dev"
  db_port  = 5202
  db_username = "${local.parameter_store}/vulnerabilities-api/development/postgres-username"
  db_password = "${local.parameter_store}/vulnerabilities-api/development/postgres-password"
  subnet_ids = data.aws_subnet_ids.development_private_subnets.ids
  db_allocated_storage = 10
  maintenance_window = "sun:10:00-sun:10:30"
  storage_encrypted = false
  multi_az = false //only true if production deployment
  publicly_accessible = false
  project_name = "platform apis"
}
