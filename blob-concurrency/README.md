# Overview
https://docs.microsoft.com/ja-jp/learn/modules/support-concurrency-blob-storage/

# GetStarted
1. create resouce group & blob
az group create --name rgBlobConcurrency --location "Japan East"
storage=mediastorageszk
az storage account create --name $storage --kind StorageV2 -g rgBlobConcurrency
1. get connection string
export STORAGE_CONNECTION_STRING=$(az storage account show-connection-string --name $storage --query connectionString -o tsv)
echo $STORAGE_CONNECTION_STRING
1. 
NewsEditor