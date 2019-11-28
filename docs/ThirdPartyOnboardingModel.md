# YL.Web.Api.ThirdParty.Onboarding.Client.Model.ThirdPartyOnboardingModel
Third party onboarding model for create a Youlend lead
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThirdPartyCustomerId** | **string** | Gets or sets the third party&#39;s id for a merchant | 
**ThirdPartyLeadId** | **string** | Gets or sets the third party&#39;s id for this lead | 
**CountryISOCode** | **string** | Gets or sets the ISO country code for the merchant | 
**LoanCurrencyISOCode** | **string** | Gets or sets the ISO currency code for the merchant | 
**MonthlyCardRevenue** | **double** | Gets or sets the monthly card revenue for the merchant | [optional] 
**NumberOfPaymentsPerMonth** | **int** | Gets or sets the number of payments a merchant has a month | [optional] 
**SweepPercentage** | **double** | Gets or sets the percentange of transaction amount the merchant wants to use to pay back the loan | [optional] 
**MonthsTrading** | **int** | Gets or sets the number of months the merchant has been trading | [optional] 
**LoanAmount** | **double** | Gets or sets the size of loan the merchant wants | [optional] 
**KeyContactName** | **string** | Gets or sets the key merchant contact who will be setting up the loan | 
**CompanyType** | **string** | Gets or sets the merchant&#39;s company type e.g. Ltd, Sole Trader etc | 
**CompanyName** | **string** | Gets or sets the merchant&#39;s company name | 
**CompanyWebsite** | **string** | Gets or sets the merchants company website URL | [optional] 
**CompanyNumber** | **string** | Gets or sets the registered company number for the merchant | [optional] 
**VatNumber** | **string** | Gets or sets the VAT number for the merchant | [optional] 
**Mid** | **string** | Gets or sets the MID for the merchant | [optional] 
**RegisteredAddress** | [**AddressModel**](AddressModel.md) |  | 
**ContactPhoneNumber** | **string** | Gets or sets the merchant&#39;s contact phone number | 
**ContactEmailAddress** | **string** | Gets or sets the merchant&#39;s key contact email address | 
**NotificationURL** | **string** | Gets or sets the third parties notification URL to which YouLend will send status updates | [optional] 
**AdditionalInfo** | **Dictionary&lt;string, string&gt;** | Gets or sets a list of key values pairs representing any additional lead data not already covered. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

