# YL.Web.Api.ThirdParty.Onboarding.Client.Api.LeadsApi

All URIs are relative to *https://dev.youlendapi.com/onboarding*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadsLeadIdAccountdetailsGet**](LeadsApi.md#leadsleadidaccountdetailsget) | **GET** /Leads/{leadId}/accountdetails | An endpoint for adding account details to a lead
[**LeadsLeadIdAccountdetailsPut**](LeadsApi.md#leadsleadidaccountdetailsput) | **PUT** /Leads/{leadId}/accountdetails | An endpoint for adding account details to a lead
[**LeadsLeadIdDetailsGet**](LeadsApi.md#leadsleadiddetailsget) | **GET** /Leads/{leadId}/details | An endpoint for viewing the onboarding details of a lead
[**LeadsLeadIdDocumentsBankstatementsPost**](LeadsApi.md#leadsleadiddocumentsbankstatementspost) | **POST** /Leads/{leadId}/documents/bankstatements | An endpoint for adding bank statements to a lead
[**LeadsLeadIdDocumentsGet**](LeadsApi.md#leadsleadiddocumentsget) | **GET** /Leads/{leadId}/documents | An endpoint for getting kyc documents for a significant person
[**LeadsLeadIdDocumentsPaymentdataPost**](LeadsApi.md#leadsleadiddocumentspaymentdatapost) | **POST** /Leads/{leadId}/documents/paymentdata | An endpoint for adding payment data documents to a lead
[**LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost**](LeadsApi.md#leadsleadiddocumentssignificantpersonssignificantpersonidkycdocumenttypepost) | **POST** /Leads/{leadId}/documents/significantpersons/{significantPersonId}/{kycDocumentType} | An endpoint for adding kyc documents for a significant person
[**LeadsLeadIdKycquestionsGet**](LeadsApi.md#leadsleadidkycquestionsget) | **GET** /Leads/{leadId}/kycquestions | An endpoint for viewing the kyc questions of a lead
[**LeadsLeadIdKycquestionsPut**](LeadsApi.md#leadsleadidkycquestionsput) | **PUT** /Leads/{leadId}/kycquestions | An endpoint for adding KYC question answers to a lead
[**LeadsLeadIdOfferGet**](LeadsApi.md#leadsleadidofferget) | **GET** /Leads/{leadId}/offer | An endpoint for getting the loan offer
[**LeadsLeadIdOfferPost**](LeadsApi.md#leadsleadidofferpost) | **POST** /Leads/{leadId}/offer | An endpoint for creating the loan offer
[**LeadsLeadIdOptionsGet**](LeadsApi.md#leadsleadidoptionsget) | **GET** /Leads/{leadId}/options | An endpoint for getting the loan options for a lead
[**LeadsLeadIdOrganisationdetailsPut**](LeadsApi.md#leadsleadidorganisationdetailsput) | **PUT** /Leads/{leadId}/organisationdetails | An endpoint for adding organisation details
[**LeadsLeadIdOrganisationsdetailsGet**](LeadsApi.md#leadsleadidorganisationsdetailsget) | **GET** /Leads/{leadId}/organisationsdetails | An endpoint for viewing the organisation details of a lead
[**LeadsLeadIdPaymentdataGet**](LeadsApi.md#leadsleadidpaymentdataget) | **GET** /Leads/{leadId}/paymentdata | An endpoint for viewing the payment data of a lead
[**LeadsLeadIdPaymentgatewaysPost**](LeadsApi.md#leadsleadidpaymentgatewayspost) | **POST** /Leads/{leadId}/paymentgateways | An endpoint for adding a payment gateway to a lead
[**LeadsLeadIdSignificantpersonsPut**](LeadsApi.md#leadsleadidsignificantpersonsput) | **PUT** /Leads/{leadId}/significantpersons | An endpoint for updating significant persons for a lead
[**LeadsLeadIdStatePut**](LeadsApi.md#leadsleadidstateput) | **PUT** /Leads/{leadId}/state | An endpoint for updating the state of an onboarding
[**LeadsPost**](LeadsApi.md#leadspost) | **POST** /Leads | Creates a Youlend Advance Lead


<a name="leadsleadidaccountdetailsget"></a>
# **LeadsLeadIdAccountdetailsGet**
> AccountV2StepModel LeadsLeadIdAccountdetailsGet (Guid leadId, string apiVersion = null)

An endpoint for adding account details to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdAccountdetailsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/onboarding";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LeadsApi(Configuration.Default);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for adding account details to a lead
                AccountV2StepModel result = apiInstance.LeadsLeadIdAccountdetailsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdAccountdetailsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**AccountV2StepModel**](AccountV2StepModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidaccountdetailsput"></a>
# **LeadsLeadIdAccountdetailsPut**
> void LeadsLeadIdAccountdetailsPut (Guid leadId, string apiVersion = null, AccountDetailsModel accountDetailsModel = null)

An endpoint for adding account details to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdAccountdetailsPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/onboarding";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LeadsApi(Configuration.Default);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var accountDetailsModel = new AccountDetailsModel(); // AccountDetailsModel |  (optional) 

            try
            {
                // An endpoint for adding account details to a lead
                apiInstance.LeadsLeadIdAccountdetailsPut(leadId, apiVersion, accountDetailsModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdAccountdetailsPut: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **accountDetailsModel** | [**AccountDetailsModel**](AccountDetailsModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadiddetailsget"></a>
# **LeadsLeadIdDetailsGet**
> OnboardingV2View LeadsLeadIdDetailsGet (Guid leadId, string apiVersion = null)

An endpoint for viewing the onboarding details of a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdDetailsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/onboarding";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LeadsApi(Configuration.Default);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for viewing the onboarding details of a lead
                OnboardingV2View result = apiInstance.LeadsLeadIdDetailsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdDetailsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**OnboardingV2View**](OnboardingV2View.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadiddocumentsbankstatementspost"></a>
# **LeadsLeadIdDocumentsBankstatementsPost**
> SaveBankStatementDocumentResultModel LeadsLeadIdDocumentsBankstatementsPost (Guid leadId, string apiVersion = null, System.IO.Stream file = null)

An endpoint for adding bank statements to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdDocumentsBankstatementsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/onboarding";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LeadsApi(Configuration.Default);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var file = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // An endpoint for adding bank statements to a lead
                SaveBankStatementDocumentResultModel result = apiInstance.LeadsLeadIdDocumentsBankstatementsPost(leadId, apiVersion, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdDocumentsBankstatementsPost: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**SaveBankStatementDocumentResultModel**](SaveBankStatementDocumentResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadiddocumentsget"></a>
# **LeadsLeadIdDocumentsGet**
> KycDocumentsV2StepModel LeadsLeadIdDocumentsGet (Guid leadId, string apiVersion = null)

An endpoint for getting kyc documents for a significant person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdDocumentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/onboarding";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LeadsApi(Configuration.Default);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for getting kyc documents for a significant person
                KycDocumentsV2StepModel result = apiInstance.LeadsLeadIdDocumentsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdDocumentsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**KycDocumentsV2StepModel**](KycDocumentsV2StepModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadiddocumentspaymentdatapost"></a>
# **LeadsLeadIdDocumentsPaymentdataPost**
> SavePaymentDataDocumentResultModel LeadsLeadIdDocumentsPaymentdataPost (Guid leadId, string apiVersion = null, System.IO.Stream file = null)

An endpoint for adding payment data documents to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdDocumentsPaymentdataPostExample
    {
        public static void Main()
        {
			var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var file = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // An endpoint for adding payment data documents to a lead
                SavePaymentDataDocumentResultModel result = apiInstance.LeadsLeadIdDocumentsPaymentdataPost(leadId, apiVersion, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdDocumentsPaymentdataPost: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**SavePaymentDataDocumentResultModel**](SavePaymentDataDocumentResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadiddocumentssignificantpersonssignificantpersonidkycdocumenttypepost"></a>
# **LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost**
> SaveSignficantPersonKycDocumentResultModel LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost (Guid leadId, Guid significantPersonId, string kycDocumentType, string apiVersion = null, System.IO.Stream file = null)

An endpoint for adding kyc documents for a significant person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePostExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var significantPersonId = new Guid(); // Guid | The third party significant person id
            var kycDocumentType = kycDocumentType_example;  // string | The kyc document type (passport, proofOfAddress) (default to "")
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var file = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // An endpoint for adding kyc documents for a significant person
                SaveSignficantPersonKycDocumentResultModel result = apiInstance.LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost(leadId, significantPersonId, kycDocumentType, apiVersion, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **significantPersonId** | [**Guid**](Guid.md)| The third party significant person id | 
 **kycDocumentType** | **string**| The kyc document type (passport, proofOfAddress) | [default to &quot;&quot;]
 **apiVersion** | **string**|  | [optional] 
 **file** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**SaveSignficantPersonKycDocumentResultModel**](SaveSignficantPersonKycDocumentResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidkycquestionsget"></a>
# **LeadsLeadIdKycquestionsGet**
> KycQuestionsStepView LeadsLeadIdKycquestionsGet (Guid leadId, string apiVersion = null)

An endpoint for viewing the kyc questions of a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdKycquestionsGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for viewing the kyc questions of a lead
                KycQuestionsStepView result = apiInstance.LeadsLeadIdKycquestionsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdKycquestionsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**KycQuestionsStepView**](KycQuestionsStepView.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidkycquestionsput"></a>
# **LeadsLeadIdKycquestionsPut**
> void LeadsLeadIdKycquestionsPut (Guid leadId, string apiVersion = null, KycQuestionsModel kycQuestionsModel = null)

An endpoint for adding KYC question answers to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdKycquestionsPutExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var kycQuestionsModel = new KycQuestionsModel(); // KycQuestionsModel |  (optional) 

            try
            {
                // An endpoint for adding KYC question answers to a lead
                apiInstance.LeadsLeadIdKycquestionsPut(leadId, apiVersion, kycQuestionsModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdKycquestionsPut: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **kycQuestionsModel** | [**KycQuestionsModel**](KycQuestionsModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidofferget"></a>
# **LeadsLeadIdOfferGet**
> OfferStepModel LeadsLeadIdOfferGet (Guid leadId, string apiVersion = null)

An endpoint for getting the loan offer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdOfferGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for getting the loan offer
                OfferStepModel result = apiInstance.LeadsLeadIdOfferGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdOfferGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**OfferStepModel**](OfferStepModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidofferpost"></a>
# **LeadsLeadIdOfferPost**
> void LeadsLeadIdOfferPost (Guid leadId, string apiVersion = null, OnboardingOfferModel onboardingOfferModel = null)

An endpoint for creating the loan offer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdOfferPostExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var onboardingOfferModel = new OnboardingOfferModel(); // OnboardingOfferModel |  (optional) 

            try
            {
                // An endpoint for creating the loan offer
                apiInstance.LeadsLeadIdOfferPost(leadId, apiVersion, onboardingOfferModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdOfferPost: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **onboardingOfferModel** | [**OnboardingOfferModel**](OnboardingOfferModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidoptionsget"></a>
# **LeadsLeadIdOptionsGet**
> LoanSizingModel LeadsLeadIdOptionsGet (Guid leadId, string apiVersion = null)

An endpoint for getting the loan options for a lead

The available loan options are accessed through this endpoint.  The loan options must first be generated by Banking Circle staff before it is made available through this endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdOptionsGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for getting the loan options for a lead
                LoanSizingModel result = apiInstance.LeadsLeadIdOptionsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdOptionsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**LoanSizingModel**](LoanSizingModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidorganisationdetailsput"></a>
# **LeadsLeadIdOrganisationdetailsPut**
> void LeadsLeadIdOrganisationdetailsPut (Guid leadId, string apiVersion = null, OnboardingOrganisationDetailsModel onboardingOrganisationDetailsModel = null)

An endpoint for adding organisation details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdOrganisationdetailsPutExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var onboardingOrganisationDetailsModel = new OnboardingOrganisationDetailsModel(); // OnboardingOrganisationDetailsModel |  (optional) 

            try
            {
                // An endpoint for adding organisation details
                apiInstance.LeadsLeadIdOrganisationdetailsPut(leadId, apiVersion, onboardingOrganisationDetailsModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdOrganisationdetailsPut: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **onboardingOrganisationDetailsModel** | [**OnboardingOrganisationDetailsModel**](OnboardingOrganisationDetailsModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **204** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidorganisationsdetailsget"></a>
# **LeadsLeadIdOrganisationsdetailsGet**
> OrganisationDetailsV3StepView LeadsLeadIdOrganisationsdetailsGet (Guid leadId, string apiVersion = null)

An endpoint for viewing the organisation details of a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdOrganisationsdetailsGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for viewing the organisation details of a lead
                OrganisationDetailsV3StepView result = apiInstance.LeadsLeadIdOrganisationsdetailsGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdOrganisationsdetailsGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**OrganisationDetailsV3StepView**](OrganisationDetailsV3StepView.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidpaymentdataget"></a>
# **LeadsLeadIdPaymentdataGet**
> PaymentDataStepView LeadsLeadIdPaymentdataGet (Guid leadId, string apiVersion = null)

An endpoint for viewing the payment data of a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdPaymentdataGetExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for viewing the payment data of a lead
                PaymentDataStepView result = apiInstance.LeadsLeadIdPaymentdataGet(leadId, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdPaymentdataGet: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**PaymentDataStepView**](PaymentDataStepView.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidpaymentgatewayspost"></a>
# **LeadsLeadIdPaymentgatewaysPost**
> void LeadsLeadIdPaymentgatewaysPost (Guid leadId, string apiVersion = null, PaymentGatewayModel paymentGatewayModel = null)

An endpoint for adding a payment gateway to a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdPaymentgatewaysPostExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var paymentGatewayModel = new PaymentGatewayModel(); // PaymentGatewayModel |  (optional) 

            try
            {
                // An endpoint for adding a payment gateway to a lead
                apiInstance.LeadsLeadIdPaymentgatewaysPost(leadId, apiVersion, paymentGatewayModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdPaymentgatewaysPost: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **paymentGatewayModel** | [**PaymentGatewayModel**](PaymentGatewayModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidsignificantpersonsput"></a>
# **LeadsLeadIdSignificantpersonsPut**
> SaveSignificantPersonsResultModel LeadsLeadIdSignificantpersonsPut (Guid leadId, string apiVersion = null, SignificantPersonsModel significantPersonsModel = null)

An endpoint for updating significant persons for a lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdSignificantpersonsPutExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var significantPersonsModel = new SignificantPersonsModel(); // SignificantPersonsModel |  (optional) 

            try
            {
                // An endpoint for updating significant persons for a lead
                SaveSignificantPersonsResultModel result = apiInstance.LeadsLeadIdSignificantpersonsPut(leadId, apiVersion, significantPersonsModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdSignificantpersonsPut: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **significantPersonsModel** | [**SignificantPersonsModel**](SignificantPersonsModel.md)|  | [optional] 

### Return type

[**SaveSignificantPersonsResultModel**](SaveSignificantPersonsResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadsleadidstateput"></a>
# **LeadsLeadIdStatePut**
> void LeadsLeadIdStatePut (Guid leadId, string apiVersion = null, OnboardingStateModel onboardingStateModel = null)

An endpoint for updating the state of an onboarding

The state can only be updated once the relevant documents are submitted, the relevant questions are answered or the relevants documents are signed

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsLeadIdStatePutExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var onboardingStateModel = new OnboardingStateModel(); // OnboardingStateModel |  (optional) 

            try
            {
                // An endpoint for updating the state of an onboarding
                apiInstance.LeadsLeadIdStatePut(leadId, apiVersion, onboardingStateModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdStatePut: " + e.Message );
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
 **leadId** | [**Guid**](Guid.md)| The lead id | 
 **apiVersion** | **string**|  | [optional] 
 **onboardingStateModel** | [**OnboardingStateModel**](OnboardingStateModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leadspost"></a>
# **LeadsPost**
> CreateThirdPartyAdvanceOnboardingResultModel LeadsPost (string apiVersion = null, ThirdPartyOnboardingModel thirdPartyOnboardingModel = null)

Creates a Youlend Advance Lead

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class LeadsPostExample
    {
        public static void Main()
        {
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_ACCES_TOKEN"
            };

            var apiInstance = new LeadsApi(config);
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var thirdPartyOnboardingModel = new ThirdPartyOnboardingModel(); // ThirdPartyOnboardingModel |  (optional) 

            try
            {
                // Creates a Youlend Advance Lead
                CreateThirdPartyAdvanceOnboardingResultModel result = apiInstance.LeadsPost(apiVersion, thirdPartyOnboardingModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsPost: " + e.Message );
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
 **apiVersion** | **string**|  | [optional] 
 **thirdPartyOnboardingModel** | [**ThirdPartyOnboardingModel**](ThirdPartyOnboardingModel.md)|  | [optional] 

### Return type

[**CreateThirdPartyAdvanceOnboardingResultModel**](CreateThirdPartyAdvanceOnboardingResultModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Returns a CreateThirdPartyAdvanceOnboardingResultModel |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

