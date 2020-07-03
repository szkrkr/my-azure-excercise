# Overview
これのやつ
https://docs.microsoft.com/ja-jp/azure/azure-app-configuration/quickstart-aspnet-core-app?tabs=core3x

# GetStarted
1. execute following to create resource group
> az group create --name rgAppConfiguration --location "Japan East"
1. execute following to create
az deployment group create \
  --name DeployAppConfiguration \
  --resource-group rgAppConfiguration \
  --template-file arm/template.json \
  --parameters arm/parameters.json \
  --verbose
1. Put following KV
TestApp:Settings:BackgroundColor	White
TestApp:Settings:FontSize	24
TestApp:Settings:FontColor	Black
TestApp:Settings:Message	Azure App Configuration からのデータ
1. execute to store connectino string
> dotnet user-secrets set ConnectionStrings:AppConfig "Endpoint=https://appconfigszk.azconfig.io;Id=95Hg-l0-s0:Oz0l8VnPcpoPfMpkRcOZ;Secret=9PRC/ZmPJMXHY+HGOdjdxzwdzxR2kASu7t2jqfc21J4="
1. execute following
> dotnet run

# Closing
1. execute following
`az group delete -n rgAppConfiguration`
