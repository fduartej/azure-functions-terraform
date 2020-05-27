# Create Storages
resource "azurerm_storage_account" "storage_prd" {
  name                     = "${var.config_tagging_conventions["storage"]}${var.storage_prd["name"]}"
  resource_group_name      = azurerm_resource_group.rg.name
  location                 = azurerm_resource_group.rg.location
  account_tier             = var.storage_prd["tier"]
  account_replication_type = var.storage_prd["replication_type"]

  tags = {
    project = var.project_prefix
    environment = var.config_common["tag_environment_prd"]
    empresa = var.config_common["tag_company"]
  }
}

resource "azurerm_storage_container" "deployments" {
    name = "function-releases"
    storage_account_name = azurerm_storage_account.storage_prd.name
    container_access_type = "private"
}

resource "azurerm_storage_blob" "appcode" {
    name                   = "${var.funtionapp["name"]}.zip"
    storage_account_name   = azurerm_storage_account.storage_prd.name
    storage_container_name = azurerm_storage_container.deployments.name
    type = "Block"
    source = var.funtionapp["file"]
}