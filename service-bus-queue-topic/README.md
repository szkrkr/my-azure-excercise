# Overview
https://docs.microsoft.com/ja-jp/learn/modules/implement-message-workflows-with-service-bus/

# GetStarted
1. create resouce group
> az group create --name rgServiceBusSzk --location "Japan East"
1. deploy resources
> az deployment group create \
  --name DeployServiceBusSzk   \
  --resource-group rgServiceBusSzk \
  --template-file arm/template.json \
  --parameters arm/parameters.json \
  --verbose \
  --no-wait 
1. update connection string
1. run
> dotnet run

# Appendix
* az servicebus namespace authorization-rule keys list \
    --resource-group rgServiceBusSzk \
    --name RootManageSharedAccessKey \
    --query primaryConnectionString \
    --output tsv \
    --namespace-name salesteamappszk

* get count for queue
az servicebus queue show     --resource-group rgServiceBusSzk     --name salesmessages     --query messageCount     --namespace-name salesteamappszk

* get count for topic of EN
az servicebus topic subscription show     --resource-group rgServiceBusSzk     --namespace-name salesteamappszk     --topic-name salesperformancemessages     --name Americas     --query messageCount

* get count for topic of EU
az servicebus topic subscription show     --resource-group rgServiceBusSzk     --namespace-name salesteamappszk     --topic-name salesperformancemessages     --name EuropeAndAfrica     --query messageCount

* create service bus 