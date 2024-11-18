# Org.OpenAPITools.Api.OauthApi

All URIs are relative to *https://api.juhe.xin*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetToken**](OauthApi.md#gettoken) | **POST** /oauth2/token | 获取Token
[**GetUserInfo**](OauthApi.md#getuserinfo) | **GET** /oauth2/userInfo | 获取用户信息
[**GetUserInfo1**](OauthApi.md#getuserinfo1) | **POST** /oauth2/userInfo | 获取用户信息



## GetToken

> string GetToken (string clientId, string clientSecret)

获取Token

获取Token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            var apiInstance = new OauthApi(Configuration.Default);
            var clientId = clientId_example;  // string | client_id
            var clientSecret = clientSecret_example;  // string | client_secret

            try
            {
                // 获取Token
                string result = apiInstance.GetToken(clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.GetToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| client_id | 
 **clientSecret** | **string**| client_secret | 

### Return type

**string**

### Authorization

No authorization required

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


## GetUserInfo

> HttpEntity GetUserInfo ()

获取用户信息

获取用户信息

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserInfoExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OauthApi(Configuration.Default);

            try
            {
                // 获取用户信息
                HttpEntity result = apiInstance.GetUserInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.GetUserInfo: " + e.Message );
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

[**HttpEntity**](HttpEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json;charset=UTF-8

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetUserInfo1

> HttpEntity GetUserInfo1 ()

获取用户信息

获取用户信息

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserInfo1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OauthApi(Configuration.Default);

            try
            {
                // 获取用户信息
                HttpEntity result = apiInstance.GetUserInfo1();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.GetUserInfo1: " + e.Message );
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

[**HttpEntity**](HttpEntity.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json;charset=UTF-8

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

