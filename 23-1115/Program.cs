using System.Net;

WebProxy proxy = new("192.168.0.105", 3128)
{
    Credentials = new NetworkCredential("test1", "test1"),
};

HttpClientHandler handler = new()
{
    Proxy = proxy,
};

try
{
    using HttpClient client = new(handler);
    using var response = await client.GetAsync("https://microsoft.com/");
    //deny
    using var responseDeny = await client.GetAsync("https://www.naver.com/");
}
catch (HttpRequestException ex)
{
    // deny exception 403
    // auth exception 407
    Console.WriteLine(ex);
}