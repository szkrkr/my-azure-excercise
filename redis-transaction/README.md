# Overview
②Azure Cache for Redis で変更可能な部分的データを処理する
https://docs.microsoft.com/ja-jp/learn/modules/work-with-mutable-and-partial-data-in-a-redis-cache/

# GetStarted
1. Azure Cache for Redis　独自の接続文字列を取得する
> REDIS_NAME=[name]
REDIS_KEY=$(az redis list-keys \
    --name "$REDIS_NAME" \
    --resource-group [sandbox resource group name] \
    --query primaryKey \
    --output tsv)
echo "$REDIS_KEY"@"$REDIS_NAME".redis.cache.windows.net:6380?ssl=true
1. set connection string
1. execute
> dotnet run
