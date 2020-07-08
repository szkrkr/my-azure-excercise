# Overview
下記の内容
https://github.com/MicrosoftLearning/AZ-204JA-DevelopingSolutionsforMicrosoftAzure/blob/master/Instructions/Labs/AZ-204_07_lab.md

# Get Started
* 
> az group create --name rgKeyVaultAppSzk --location "Japan East"
> az deployment group create \
  --name DeployKeyVaultAppSzk  \
  --resource-group rgKeyVaultAppSzk\
  --template-file arm/template.json \
  --parameters arm/parameters.json \
  --verbose \
  --no-wait 
