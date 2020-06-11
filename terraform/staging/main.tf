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
    bucket  = "terraform-state-staging-apis" 
    encrypt = true
    region  = "eu-west-2"
    key     = "services/resident-vulnerabilities-api/state" 
  }
}

/*    POSTGRES SET UP    */
data "aws_vpc" "staging_vpc" {
  tags = {
    Name = "vpc-staging-apis-staging"
  }
}
data "aws_subnet_ids" "staging" {
  vpc_id = data.aws_vpc.staging_vpc.id
  filter {
    name   = "tag:Type"
    values = ["private"] 
  }
}
 data "aws_ssm_parameter" "vulnerabilities_postgres_db_password" {
   name = "/resident-vulnerabilities-api/staging/postgres-password"
 }

 data "aws_ssm_parameter" "vulnerabilities_postgres_username" {
   name = "/resident-vulnerabilities-api/staging/postgres-username"
 }
 
module "postgres_db_staging" {
  source = "github.com/LBHackney-IT/aws-hackney-common-terraform.git//modules/database/postgres"
  environment_name = "staging"
  vpc_id = data.aws_vpc.staging_vpc.id
  db_identifier = "vulnerabilities-db"
  db_name = "vulnerabilities_db"
  db_port  = 5202
  subnet_ids = data.aws_subnet_ids.staging.ids
  db_engine = "postgres"
  db_engine_version = "11.1" //DMS does not work well with v12
  db_instance_class = "db.t2.micro"
  db_allocated_storage = 20
  maintenance_window = "sun:10:00-sun:10:30"
  db_username = data.aws_ssm_parameter.vulnerabilities_postgres_username.value
  db_password = data.aws_ssm_parameter.vulnerabilities_postgres_db_password.value
  storage_encrypted = false
  multi_az = false //only true if production deployment
  publicly_accessible = false
  project_name = "platform apis"
}