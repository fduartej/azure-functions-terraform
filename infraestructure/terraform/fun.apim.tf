#api management

resource "azurerm_api_management" "api_mgt_prd" {
  name                = "${var.config_tagging_conventions["api_mgt"]}${var.api_mgt_prd["name"]}"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  publisher_email     = var.credentials_client_email
  publisher_name      = var.api_mgt_prd["company"]

  sku_name     = var.api_mgt_prd["sku_name"]

  tags = {
    environment = var.config_common["tag_environment_prd"]
    empresa = var.config_common["tag_company"]
    project = var.project_prefix
  }
}