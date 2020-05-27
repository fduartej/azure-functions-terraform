provider "azurerm" {
  version = "=2.0.0"
  features {}

  subscription_id = var.credentials_subscription_id
  client_id       = var.credentials_client_id
  client_secret   = var.credentials_client_secret
  tenant_id       = var.credentials_tenant_id
}

# Create a resource group for all components to this project
resource "azurerm_resource_group" "rg" {
  name     = var.project_rg_name
  location = var.project_locations

  tags = {
    project = var.project_prefix
    environment = var.config_common["tag_environment_prd"]
    empresa = var.config_common["tag_company"]
  }
}

