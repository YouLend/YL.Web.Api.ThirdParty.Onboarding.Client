# YL.Web.Api.ThirdParty.Onboarding.Client.Model.OnboardingV2View
A model containing data about an onboarding for a lead
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeadSourceLendingPartnerId** | **Guid** |  | [optional] 
**OnboardingState** | **string** | Gets or sets the current state of an onboarding.  One of \&quot;signuprequirementsnotmet\&quot;, \&quot;stage1incomplete\&quot;, \&quot;stage1submitted\&quot;,  \&quot;stage1rejected\&quot;, \&quot;stage2incomplete\&quot;, \&quot;stage2submitted\&quot;, \&quot;stage2rejected\&quot; or \&quot;onboardingcomplete\&quot;. | [optional] 
**OnboardingStateReason** | **string** | Gets or sets the reason for the current state of an onboarding in case of rejection. | [optional] 
**OrganisationDetailsStepComplete** | **bool** | Gets or sets a value indicating whether the organisation details step is complete | [optional] 
**PaymentDataStepComplete** | **bool** | Gets or sets a value indicating whether the payment data step is complete | [optional] 
**OfferStepComplete** | **bool** | Gets or sets a value indicating whether the offer step is complete.  The offer step requires the documents to be signed. | [optional] 
**KycQuestionsStepComplete** | **bool** | Gets or sets a value indicating whether the KYC questions step is complete | [optional] 
**KycDocumentsStepComplete** | **bool** | Gets or sets a value indicating whether the KYC documents step is complete | [optional] 
**AccountStepComplete** | **bool** | Gets or sets a value indicating whether the accounts step is complete | [optional] 
**CompanyName** | **string** | Gets or sets the name of the company | [optional] 
**LeadType** | **string** | Gets or sets the lead type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

