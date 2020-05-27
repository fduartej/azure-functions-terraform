
# Create app service plan

data "azurerm_storage_account_sas" "sas" {
    connection_string = azurerm_storage_account.storage_prd.primary_connection_string
    https_only = true
    start = "2019-01-01"
    expiry = "2021-12-31"
    resource_types {
        object = true
        container = false
        service = false
    }
    services {
        blob = true
        queue = false
        table = false
        file = false
    }
    permissions {
        read = true
        write = false
        delete = false
        list = false
        add = false
        create = false
        update = false
        process = false
    }
}

resource "azurerm_app_service_plan" "asp" {
    name                     = "${var.config_tagging_conventions["app-sp"]}${var.app_ser_plan_prd["name"]}"
    resource_group_name      = azurerm_resource_group.rg.name
    location                 = azurerm_resource_group.rg.location    
    kind = "FunctionApp"
    sku {
        tier = var.app_ser_plan_prd["tier"]
        size = var.app_ser_plan_prd["size"]
    }

    tags = {
        project = var.project_prefix
        environment = var.config_common["tag_environment_prd"]
        empresa = var.config_common["tag_company"]
    }
}

resource "azurerm_application_insights" "logging" {
    name                = "${var.config_tagging_conventions["app-ins"]}-functionapp"
    resource_group_name = azurerm_resource_group.rg.name
    location            = azurerm_resource_group.rg.location    
    application_type    = "web"

    tags = {
        project = var.project_prefix
        environment = var.config_common["tag_environment_prd"]
        empresa = var.config_common["tag_company"]
    }
}


resource "azurerm_function_app" "functions" {
    name = var.funtionapp["name"]
    location                  = azurerm_resource_group.rg.location 
    resource_group_name       = azurerm_resource_group.rg.name
    app_service_plan_id       = azurerm_app_service_plan.asp.id
    storage_connection_string = azurerm_storage_account.storage_prd.primary_connection_string
    version = "~3"

    app_settings = {
        APPINSIGHTS_INSTRUMENTATIONKEY = azurerm_application_insights.logging.instrumentation_key
        https_only = true
        FUNCTIONS_EXTENSION_VERSION    = "~3"
        FUNCTIONS_WORKER_RUNTIME       = "dotnet"        
        FUNCTION_APP_EDIT_MODE = "readonly"
        HASH = "${base64encode(filesha256("${var.functionapphash}"))}"
        WEBSITE_RUN_FROM_PACKAGE = "https://${azurerm_storage_account.storage_prd.name}.blob.core.windows.net/${azurerm_storage_container.deployments.name}/${azurerm_storage_blob.appcode.name}${data.azurerm_storage_account_sas.sas.sas}"
    }

    #site_config {
    #    always_on                 = true
        #linux_fx_version          = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-appservice"
     #   linux_fx_version = "DOTNETCORE|LTS"
        #use_32_bit_worker_process = true
    #}

    tags = {
        project = var.project_prefix
        environment = var.config_common["tag_environment_prd"]
        empresa = var.config_common["tag_company"]
    }

}