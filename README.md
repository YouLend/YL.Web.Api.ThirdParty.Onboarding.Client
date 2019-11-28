# YL.Web.Api.ThirdParty.Onboarding.Client - the C# library for the YouLend Third Party Onboarding API

Through this API you can can initiate the process of onboarding a borrower with YouLend

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.6.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command in powershell: 
```
Install-Package YL.Web.Api.ThirdParty.Onboarding.Client
```
More detail on nuget: [YL.Web.Api.ThirdParty.Onboarding.Client]( https://www.nuget.org/packages/YL.Web.Api.ThirdParty.Onboarding.Client/1.0.1)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Onboarding.Client.Api;
using YL.Web.Api.ThirdParty.Onboarding.Client.Client;
using YL.Web.Api.ThirdParty.Onboarding.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
		Console
            var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/onboarding",
                AccessToken =
                    "YOUR_TOKEN"
            };
            // Configure OAuth2 access token for authorization: oauth2

            var apiInstance = new LeadsApi(config);
            var leadId = new Guid(); // Guid | The lead id
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var accountDetailsModel = new AccountDetailsModel(); // AccountDetailsModel |  (optional) 

            try
            {
                // An endpoint for adding account details to a lead
                apiInstance.LeadsLeadIdAccountdetailsPut(leadId, apiVersion, accountDetailsModel);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LeadsApi.LeadsLeadIdAccountdetailsPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dev.youlendapi.com/onboarding*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LeadsApi* | [**LeadsLeadIdAccountdetailsPut**](docs/LeadsApi.md#leadsleadidaccountdetailsput) | **PUT** /Leads/{leadId}/accountdetails | An endpoint for adding account details to a lead
*LeadsApi* | [**LeadsLeadIdDocumentsBankstatementsPost**](docs/LeadsApi.md#leadsleadiddocumentsbankstatementspost) | **POST** /Leads/{leadId}/documents/bankstatements | An endpoint for adding bank statements to a lead
*LeadsApi* | [**LeadsLeadIdDocumentsPaymentdataPost**](docs/LeadsApi.md#leadsleadiddocumentspaymentdatapost) | **POST** /Leads/{leadId}/documents/paymentdata | An endpoint for adding payment data documents to a lead
*LeadsApi* | [**LeadsLeadIdDocumentsSignificantpersonsSignificantPersonIdKycDocumentTypePost**](docs/LeadsApi.md#leadsleadiddocumentssignificantpersonssignificantpersonidkycdocumenttypepost) | **POST** /Leads/{leadId}/documents/significantpersons/{significantPersonId}/{kycDocumentType} | An endpoint for adding kyc documents for a significant person
*LeadsApi* | [**LeadsLeadIdKycquestionsPut**](docs/LeadsApi.md#leadsleadidkycquestionsput) | **PUT** /Leads/{leadId}/kycquestions | An endpoint for adding KYC question answers to a lead
*LeadsApi* | [**LeadsLeadIdPaymentgatewaysPost**](docs/LeadsApi.md#leadsleadidpaymentgatewayspost) | **POST** /Leads/{leadId}/paymentgateways | An endpoint for adding a payment gateway to a lead
*LeadsApi* | [**LeadsLeadIdSignificantpersonsPut**](docs/LeadsApi.md#leadsleadidsignificantpersonsput) | **PUT** /Leads/{leadId}/significantpersons | An endpoint for updating significant persons for a lead
*LeadsApi* | [**LeadsPost**](docs/LeadsApi.md#leadspost) | **POST** /Leads | Creates a Youlend Advance Lead


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountDetailsModel](docs/AccountDetailsModel.md)
 - [Model.AddressModel](docs/AddressModel.md)
 - [Model.CreateThirdPartyAdvanceOnboardingResultModel](docs/CreateThirdPartyAdvanceOnboardingResultModel.md)
 - [Model.DateModel](docs/DateModel.md)
 - [Model.FreeTextQuestionModel](docs/FreeTextQuestionModel.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.KycQuestionsModel](docs/KycQuestionsModel.md)
 - [Model.PaymentGatewayModel](docs/PaymentGatewayModel.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.SaveBankStatementDocumentResultModel](docs/SaveBankStatementDocumentResultModel.md)
 - [Model.SavePaymentDataDocumentResultModel](docs/SavePaymentDataDocumentResultModel.md)
 - [Model.SaveSignficantPersonKycDocumentResultModel](docs/SaveSignficantPersonKycDocumentResultModel.md)
 - [Model.SaveSignificantPersonsResultModel](docs/SaveSignificantPersonsResultModel.md)
 - [Model.SignificantPersonModel](docs/SignificantPersonModel.md)
 - [Model.SignificantPersonsModel](docs/SignificantPersonsModel.md)
 - [Model.ThirdPartyOnboardingModel](docs/ThirdPartyOnboardingModel.md)
 - [Model.YesNoQuestionModel](docs/YesNoQuestionModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

