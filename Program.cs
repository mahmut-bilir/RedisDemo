using StackExchange.Redis;

var redis = await ConnectionMultiplexer.ConnectAsync("localhost:6379");
var db = redis.GetDatabase();


string key = "my_key";
string value = "Hello, Redis!";
await db.StringSetAsync(key, value);
Console.WriteLine($"Added: {key} -> {value}");

string retrievedValue = await db.StringGetAsync(key);

Console.WriteLine($"Retrieved value: {key} -> {retrievedValue}");

await redis.CloseAsync();
