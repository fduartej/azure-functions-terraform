#Function Archetype
Arquetipo para la creacion de Funciones en Azure

#Deploy
Local Deployment 

Azure Deployment

#Misscelaneus Cheat Sheet Commands

func start --build

dotnet publish --configuration Release --output ..\build

dotnet publish -r linux-x64 --self-contained false --configuration Release  --output build

Compress-Archive -Path build\* -DestinationPath ..\..\deploy\functionapp.zip  -Force

dotnet publish --configuration Release --output publish_output
