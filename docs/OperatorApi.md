# Org.OpenAPITools.Api.OperatorApi

All URIs are relative to *https://api.juhe.xin*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Demoback**](OperatorApi.md#demoback) | **POST** /op/api/v1/code/demoback | 回到函数示例
[**Request**](OperatorApi.md#request) | **POST** /op/api/v1/code/request | 请求下发验证码接口
[**Verify**](OperatorApi.md#verify) | **POST** /op/api/v1/code/verify | 请求校验验证码接口



## Demoback

> string Demoback (CallbackData data)

回到函数示例

用户调用测试，业务系统无需调用

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DemobackExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OperatorApi(Configuration.Default);
            var data = new CallbackData(); // CallbackData | data

            try
            {
                // 回到函数示例
                string result = apiInstance.Demoback(data);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OperatorApi.Demoback: " + e.Message );
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
 **data** | [**CallbackData**](CallbackData.md)| data | 

### Return type

**string**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
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


## Request

> OutResponseOfCodeResponse Request (CodeRequest request)

请求下发验证码接口

请求下发验证码接口

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OperatorApi(Configuration.Default);
            var request = new CodeRequest(); // CodeRequest | request

            try
            {
                // 请求下发验证码接口
                OutResponseOfCodeResponse result = apiInstance.Request(request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OperatorApi.Request: " + e.Message );
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
 **request** | [**CodeRequest**](CodeRequest.md)| request | 

### Return type

[**OutResponseOfCodeResponse**](OutResponseOfCodeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
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


## Verify

> OutResponseOfCodeResponse Verify (CodeVerify verify)

请求校验验证码接口

请求校验验证码接口

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VerifyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.juhe.xin";
            // Configure OAuth2 access token for authorization: Authorization
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OperatorApi(Configuration.Default);
            var verify = new CodeVerify(); // CodeVerify | verify

            try
            {
                // 请求校验验证码接口
                OutResponseOfCodeResponse result = apiInstance.Verify(verify);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OperatorApi.Verify: " + e.Message );
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
 **verify** | [**CodeVerify**](CodeVerify.md)| verify | 

### Return type

[**OutResponseOfCodeResponse**](OutResponseOfCodeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
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

