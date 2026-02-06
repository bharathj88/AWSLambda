variable "aws_region" {
  type    = string
  default = "ap-south-1"
}

variable "function_name" {
  type    = string
  default = "MyLambdaFunction"
}

variable "api_name" {
  type    = string
  default = "MyLambdaFunction"
}

variable "stage" {
  type    = string
  default = "dev"
}

variable "runtime" {
  type    = string
  default = "dotnet8"
}

# Assembly and namespace used in handler string: Assembly::Namespace.Class::Method
variable "assembly" {
  type    = string
  default = "MyLambdaFunction"
}

variable "namespace" {
  type    = string
  default = "MyLambdaFunction"
}