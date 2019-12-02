# YL.Web.Api.ThirdParty.Onboarding.Client.Api.DocumentSigningApi

All URIs are relative to *https://dev.youlendapi.com/onboarding*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DocumentSigningDocumentSigningIdGet**](DocumentSigningApi.md#documentsigningdocumentsigningidget) | **GET** /DocumentSigning/{documentSigningId} | Gets the document signing for specified document


<a name="documentsigningdocumentsigningidget"></a>
# **DocumentSigningDocumentSigningIdGet**
> DocumentSigningViewModel DocumentSigningDocumentSigningIdGet (Guid documentSigningId, string apiVersion = null)

Gets the document signing for specified document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class DocumentSigningDocumentSigningIdGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new DocumentSigningApi(config);
            var documentSigningId = new Guid(); // Guid | GUID used to identify the document signing
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // Gets the document signing for specified document
                DocumentSigningViewModel result = apiInstance.DocumentSigningDocumentSigningIdGet(documentSigningId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentSigningApi.DocumentSigningDocumentSigningIdGet: " + e.Message );
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
 **documentSigningId** | [**Guid**](Guid.md)| GUID used to identify the document signing | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**DocumentSigningViewModel**](DocumentSigningViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Returns a DocumentSigningViewModel |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

