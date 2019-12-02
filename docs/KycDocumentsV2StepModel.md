# YL.Web.Api.ThirdParty.Onboarding.Client.Model.KycDocumentsV2StepModel
Model containing data about the KYC document step
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyDocuments** | [**Dictionary&lt;string, KycDocumentModel&gt;**](KycDocumentModel.md) |  | [optional] 
**SignificantPersonDocuments** | [**List&lt;SignificantPersonDocumentsModel&gt;**](SignificantPersonDocumentsModel.md) | Gets or sets a list of YL.Web.Api.ThirdParty.Onboarding.Models.SignificantPersonDocumentsModel | [optional] 
**BankStatements** | [**Dictionary&lt;string, KycDocumentModel&gt;**](KycDocumentModel.md) | Gets or sets a Dictionary of Guids to YL.Web.Api.ThirdParty.Onboarding.Models.KycDocumentModel&amp;gt; | [optional] 
**LeadId** | **Guid** | Gets or sets the lead id | [optional] 
**Country** | **string** | Gets or sets the country | [optional] 
**CompanyType** | **string** | Gets or sets the company type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

