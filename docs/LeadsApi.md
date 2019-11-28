# YL.Web.Api.ThirdParty.Onboarding.Client.Api.LeadsApi

All URIs are relative to *http://localhost:61178*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LeadsLeadIdAccountdetailsPut**](LeadsApi.md#leadsleadidaccountdetailsput) | **PUT** /Leads/{leadId}/accountdetails | An endpoint for adding account details to a lead
[**LeadsLeadIdDocumentsBankstatementsPost**](LeadsApi.md#leadsleadiddocumentsbankstatementspost) | **POST** /Leads/{leadId}/documents/bankstatements | An endpoint for adding bank statements to a lead
[**LeadsLeadIdDocumentsPaymentdataPost**](LeadsApi.md#leadsleadiddocumentspaymentdatapost) | **POST** /Leads/{leadId}/documents/paymentdata | An endpoint for adding payment data documents to a lead
[**LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost**](LeadsApi.md#leadsleadiddocumentssignificantpersonssignificantpersonidkycdocumenttypepost) | **POST** /Leads/{leadId}/documents/significantpersons/{significantPersonId}/{kycDocumentType} | An endpoint for adding kyc documents for a significant person
[**LeadsLeadIdKycquestionsPut**](LeadsApi.md#leadsleadidkycquestionsput) | **PUT** /Leads/{leadId}/kycquestions | An endpoint for adding KYC question answers to a lead
[**LeadsLeadIdPaymentgatewaysPost**](LeadsApi.md#leadsleadidpaymentgatewayspost) | **POST** /Leads/{leadId}/paymentgateways | An endpoint for adding a payment gateway to a lead
[**LeadsLeadIdSignificantpersonsPut**](LeadsApi.md#leadsleadidsignificantpersonsput) | **PUT** /Leads/{leadId}/significantpersons | An endpoint for updating significant persons for a lead
[**LeadsPost**](LeadsApi.md#leadspost) | **POST** /Leads | Creates a Youlend Advance Lead


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

			var config = new Configuration
			{
				BasePath = "https://dev.youlendapi.com/onboarding",
				AccessToken =
					"YOUR_ACCES_TOKEN"
			};
			
			var apiInstance = new LeadsApi(config);
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
			Cvar config = new Configuration
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

<a name="leadspost"></a>
# **LeadsPost**
> CreateThirdPartyAdvanceOnboardingResultModel LeadsPost (string apiVersion = null, ThirdPartyOnboardingModel thirdPartyOnboardingModel = null)

Creates a Youlend Advance Lead

Can add sample as an example here

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

