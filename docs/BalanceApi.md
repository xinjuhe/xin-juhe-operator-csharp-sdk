# Org.OpenAPITools.Api.BalanceApi

All URIs are relative to *https://api.juhe.xin*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBalance**](BalanceApi.md#getbalance) | **POST** /user/api/v1/balance | 获取用户余额



## GetBalance

> OutResponseOfBalance GetBalance ()

获取用户余额

获取用户余额

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBalanceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BalanceApi(Configuration.Default);

            try
            {
                // 获取用户余额
                OutResponseOfBalance result = apiInstance.GetBalance();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BalanceApi.GetBalance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**OutResponseOfBalance**](OutResponseOfBalance.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **201** | Created |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

