# YL.Web.Api.ThirdParty.Onboarding.Client.Model.OfferStepModel
Model containing details about an offer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeadId** | **Guid** | Gets or sets the lead id | [optional] 
**YouWillGet** | **double** | Gets or sets the amount that the lead will receive if offer is accepted | [optional] 
**YouWillRepay** | **double** | Gets or sets the amount that the lead will repay | [optional] 
**CurrencyISOCode** | **string** | Gets or sets the currency ISO code for the offer | [optional] 
**Sweep** | **double** | Gets or sets the sweep, which is the percentage of the settlement which is allocated to repaying the loan | [optional] 
**UnsignedLoanDocument** | [**DocumentMetadataModel**](DocumentMetadataModel.md) |  | [optional] 
**UnsignedLoanDocumentDownloaded** | **bool** | Gets or sets a value indicating whether the unsigned loan document has been downloaded | [optional] 
**UnsignedAccountDocument** | [**DocumentMetadataModel**](DocumentMetadataModel.md) |  | [optional] 
**UnsignedAccountDocumentDownloaded** | **bool** | Gets or sets a value indicating whether the unsigned loan document has been downloaded | [optional] 
**DocumentSigningId** | **Guid** | Gets or sets the document signing id | [optional] 
**SortCode** | **string** | Gets or sets the sort code of the lead&#39;s account | [optional] 
**AccountNumber** | **string** | Gets or sets the account number for the lead | [optional] 
**Swift** | **string** | Gets or sets the swift code for the lead&#39;s account | [optional] 
**Iban** | **string** | Gets or sets the IBAN for the lead&#39;s account | [optional] 
**BankName** | **string** | Gets or sets the name of the bank associated with the lead&#39;s account | [optional] 
**ConfirmedCompanyAccount** | **bool** | Gets or sets a value indicating whether the account is confirmed to be the company account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

