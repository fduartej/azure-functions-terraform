#variables from input.variables.tfvars
variable "project_prefix" {}
variable "project_locations" {}
variable "project_rg_name" {}

variable "credentials_client_email" {}
variable "credentials_subscription_id" {}
variable "credentials_client_id" {}
variable "credentials_client_secret" {}
variable "credentials_tenant_id" {}

variable "resource_admin_username" {}

#input setup common 
variable "config_common" {
    type   = map
    default = {
        "tag_environment_dev"        = "DEVELOPMENT"
        "tag_environment_prd"        = "PRODUCTION"
        "tag_company"                = "BANK"
    }    
}

#input tagging conventions
variable "config_tagging_conventions" {
  type        = map
  default     = {
    storage      = "sa"
    kubernetes   = "aks"
    api_mgt      = "api"
    registry     = "acr"
    vnet         = "vnet"
    sub_net      = "snet"  
    log_ws       = "lws"  
    bus          = "sb"  
    bus_topic    = "sbt"  
    bus_queue    = "sbq"  
    cache        = "redis"
    public_ip    = "pip"
    app_gtw      = "agw"
    app-sp       = "asp"
    app-ins      = "appi"
  }  
}

#input storage
variable "storage_prd" {
    type = map
    default = {
        "name"              = "prd01use1"
        "tier"              = "Standard"
        "replication_type"  = "GRS"
    }  
}

#input setup api management
variable "api_mgt_prd" {
    type = map
    default = {
        "name"         = "prd01use1"
        "company"      = "inteligo"
        "sku_name"     = "Basic_1"
    }
} 

#input app service plan
variable "app_ser_plan_prd" {
    type = map
    default = {
        "name"     = "prd01use1"
        "tier"     = "Dynamic"
        "size"     = "Y1"
    }
} 


#input app service plan
variable "funtionapp" {
    type = map
    default = {
        "name"     = "functionappsab"
        "file"     = "../../deploy/functionapp.zip"
    }
}

variable "functionapphash" {
    type = string
    default = "../../deploy/functionapp.zip"
}