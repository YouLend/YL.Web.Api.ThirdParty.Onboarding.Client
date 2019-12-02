# YL.Web.Api.ThirdParty.Onboarding.Client.Model.CreditRatingBandParameters
The parameters for the credit rating band of a lead
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Rating** | **string** | Gets or sets the credit rating of the lead | [optional] 
**LowerLimit** | **double** | Gets or sets the lower limit for credit score for the credit rating band | [optional] 
**UpperLimit** | **double** | Gets or sets the upper limit for credit score for the credit rating band | [optional] 
**TargetTerm** | **double** | Gets or sets the target number of months until full repayment of the loan, which is used to determine the sweep of the option 1 loan | [optional] 
**Fee** | **double** | Gets or sets the fee (as a factor), which is used to determine the LoanAmount (repayable amount) from the FundingAmount (amount lent to the borrower) | [optional] 
**Size** | **double** | Gets or sets the size for the credit rating band, which is used to determine the FundingAmount of the option 1 loan | [optional] 
**CountryCode** | **string** | Gets or sets the country code for which this credit rating band applies | [optional] 
**LoanSweep2** | **double** | Gets or sets the fixed sweep used in loan option 2 | [optional] 
**LoanSweep3** | **double** | Gets or sets the fixed sweep used in loan option 3 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

