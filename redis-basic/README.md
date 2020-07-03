# Overview
①Redis で読み取り専用データをキャッシュすることにより Web アプリケーションを最適化する
https://docs.microsoft.com/ja-jp/learn/modules/optimize-your-web-apps-with-redis/

# GetStarted
1. 
> az group create --name rgContosoSportsAppSzk --location "Japan East"
1. 
> az deployment group create \
  --name DeployContosoSportsAppSzk  \
  --resource-group rgContosoSportsAppSzk \
  --template-file arm/template.json \
  --parameters arm/parameters.json \
  --verbose \
  --no-wait 
1. update connection string
1. 
> dotnet run
