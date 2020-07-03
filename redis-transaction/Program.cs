using System;
using ServiceStack.Redis;

namespace redis
{
    class Program {
        static string redisConnectionString = "uyVcXodkopA7b8Bku4jlbO1E6iDPs8L0RXmJLpKPI0E=@RedisExcersizeSzk.redis.cache.windows.net:6380?ssl=True";
        static void Main (string[] args) {
            bool transactionResult = false;

            using (RedisClient redisClient = new RedisClient (redisConnectionString))
            using (var transaction = redisClient.CreateTransaction ()) {
                //Add multiple operations to the transaction
                transaction.QueueCommand (c => c.Set ("MyKey1", "MyValue1"));
                transaction.QueueCommand (c => c.Set ("MyKey2", "MyValue2"));

                //Commit and get result of transaction
                transactionResult = transaction.Commit ();
            }

            if (transactionResult) {
                Console.WriteLine ("Transaction committed");
            } else {
                Console.WriteLine ("Transaction failed to commit");
            }
        }
    }
}