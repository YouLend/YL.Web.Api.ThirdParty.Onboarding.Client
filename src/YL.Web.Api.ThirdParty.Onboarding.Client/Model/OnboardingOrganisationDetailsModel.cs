/* 
 * YouLend Third Party Onboarding API
 *
 * Through this API you can can initiate the process of onboarding a borrower with YouLend
 *
 * The version of the OpenAPI document: 1.0
 * Contact: mark.ufland@youlend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YL.Web.Api.ThirdParty.Onboarding.Client.Client.OpenAPIDateConverter;

namespace YL.Web.Api.ThirdParty.Onboarding.Client.Model
{
    /// <summary>
    /// Model for miscellaneous details for a company
    /// </summary>
    [DataContract]
    public partial class OnboardingOrganisationDetailsModel :  IEquatable<OnboardingOrganisationDetailsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingOrganisationDetailsModel" /> class.
        /// </summary>
        /// <param name="companyName">Gets or sets the merchant&#39;s company name.</param>
        /// <param name="companyNumber">Gets or sets the registered company number.</param>
        /// <param name="vatNumber">Gets or sets the VAT number for the company.</param>
        /// <param name="formationDate">Gets or sets the formation date of the company.</param>
        /// <param name="companyType">Gets or sets the company type.</param>
        /// <param name="registeredAddress">registeredAddress.</param>
        /// <param name="countryISOCode">Gets or sets the ISO country code for the company.</param>
        /// <param name="description">Gets or sets the description for the company.</param>
        /// <param name="industries">Gets or sets the list of industries that the company conducts business in.</param>
        /// <param name="keyContactName">Gets or sets the key merchant contact who will be setting up the loan.</param>
        /// <param name="companyWebsite">Gets or sets the merchant&#39;s company website URL.</param>
        /// <param name="contactPhoneNumber">Gets or sets the merchant&#39;s contact phone number.</param>
        /// <param name="contactEmailAddress">Gets or sets the merchant&#39;s key contact email address.</param>
        /// <param name="merchantIds">merchantIds.</param>
        /// <param name="confirmedCreditSearch">Gets or sets a value indicating whether the lead has given their consent for a credit search..</param>
        public OnboardingOrganisationDetailsModel(string companyName = default(string), string companyNumber = default(string), string vatNumber = default(string), DateTime formationDate = default(DateTime), string companyType = default(string), AddressModel registeredAddress = default(AddressModel), string countryISOCode = default(string), string description = default(string), List<Industry> industries = default(List<Industry>), string keyContactName = default(string), string companyWebsite = default(string), string contactPhoneNumber = default(string), string contactEmailAddress = default(string), MerchantIdsModel merchantIds = default(MerchantIdsModel), bool confirmedCreditSearch = default(bool))
        {
            this.CompanyName = companyName;
            this.CompanyNumber = companyNumber;
            this.VatNumber = vatNumber;
            this.FormationDate = formationDate;
            this.CompanyType = companyType;
            this.RegisteredAddress = registeredAddress;
            this.CountryISOCode = countryISOCode;
            this.Description = description;
            this.Industries = industries;
            this.KeyContactName = keyContactName;
            this.CompanyWebsite = companyWebsite;
            this.ContactPhoneNumber = contactPhoneNumber;
            this.ContactEmailAddress = contactEmailAddress;
            this.MerchantIds = merchantIds;
            this.ConfirmedCreditSearch = confirmedCreditSearch;
        }
        
        /// <summary>
        /// Gets or sets the merchant&#39;s company name
        /// </summary>
        /// <value>Gets or sets the merchant&#39;s company name</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the registered company number
        /// </summary>
        /// <value>Gets or sets the registered company number</value>
        [DataMember(Name="companyNumber", EmitDefaultValue=false)]
        public string CompanyNumber { get; set; }

        /// <summary>
        /// Gets or sets the VAT number for the company
        /// </summary>
        /// <value>Gets or sets the VAT number for the company</value>
        [DataMember(Name="vatNumber", EmitDefaultValue=false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or sets the formation date of the company
        /// </summary>
        /// <value>Gets or sets the formation date of the company</value>
        [DataMember(Name="formationDate", EmitDefaultValue=false)]
        public DateTime FormationDate { get; set; }

        /// <summary>
        /// Gets or sets the company type
        /// </summary>
        /// <value>Gets or sets the company type</value>
        [DataMember(Name="companyType", EmitDefaultValue=false)]
        public string CompanyType { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredAddress
        /// </summary>
        [DataMember(Name="registeredAddress", EmitDefaultValue=false)]
        public AddressModel RegisteredAddress { get; set; }

        /// <summary>
        /// Gets or sets the ISO country code for the company
        /// </summary>
        /// <value>Gets or sets the ISO country code for the company</value>
        [DataMember(Name="countryISOCode", EmitDefaultValue=false)]
        public string CountryISOCode { get; set; }

        /// <summary>
        /// Gets or sets the description for the company
        /// </summary>
        /// <value>Gets or sets the description for the company</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of industries that the company conducts business in
        /// </summary>
        /// <value>Gets or sets the list of industries that the company conducts business in</value>
        [DataMember(Name="industries", EmitDefaultValue=false)]
        public List<Industry> Industries { get; set; }

        /// <summary>
        /// Gets or sets the key merchant contact who will be setting up the loan
        /// </summary>
        /// <value>Gets or sets the key merchant contact who will be setting up the loan</value>
        [DataMember(Name="keyContactName", EmitDefaultValue=false)]
        public string KeyContactName { get; set; }

        /// <summary>
        /// Gets or sets the merchant&#39;s company website URL
        /// </summary>
        /// <value>Gets or sets the merchant&#39;s company website URL</value>
        [DataMember(Name="companyWebsite", EmitDefaultValue=false)]
        public string CompanyWebsite { get; set; }

        /// <summary>
        /// Gets or sets the merchant&#39;s contact phone number
        /// </summary>
        /// <value>Gets or sets the merchant&#39;s contact phone number</value>
        [DataMember(Name="contactPhoneNumber", EmitDefaultValue=false)]
        public string ContactPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the merchant&#39;s key contact email address
        /// </summary>
        /// <value>Gets or sets the merchant&#39;s key contact email address</value>
        [DataMember(Name="contactEmailAddress", EmitDefaultValue=false)]
        public string ContactEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets MerchantIds
        /// </summary>
        [DataMember(Name="merchantIds", EmitDefaultValue=false)]
        public MerchantIdsModel MerchantIds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the lead has given their consent for a credit search.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the lead has given their consent for a credit search.</value>
        [DataMember(Name="confirmedCreditSearch", EmitDefaultValue=false)]
        public bool ConfirmedCreditSearch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnboardingOrganisationDetailsModel {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyNumber: ").Append(CompanyNumber).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  FormationDate: ").Append(FormationDate).Append("\n");
            sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
            sb.Append("  RegisteredAddress: ").Append(RegisteredAddress).Append("\n");
            sb.Append("  CountryISOCode: ").Append(CountryISOCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Industries: ").Append(Industries).Append("\n");
            sb.Append("  KeyContactName: ").Append(KeyContactName).Append("\n");
            sb.Append("  CompanyWebsite: ").Append(CompanyWebsite).Append("\n");
            sb.Append("  ContactPhoneNumber: ").Append(ContactPhoneNumber).Append("\n");
            sb.Append("  ContactEmailAddress: ").Append(ContactEmailAddress).Append("\n");
            sb.Append("  MerchantIds: ").Append(MerchantIds).Append("\n");
            sb.Append("  ConfirmedCreditSearch: ").Append(ConfirmedCreditSearch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnboardingOrganisationDetailsModel);
        }

        /// <summary>
        /// Returns true if OnboardingOrganisationDetailsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OnboardingOrganisationDetailsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnboardingOrganisationDetailsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.CompanyNumber == input.CompanyNumber ||
                    (this.CompanyNumber != null &&
                    this.CompanyNumber.Equals(input.CompanyNumber))
                ) && 
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                    this.VatNumber.Equals(input.VatNumber))
                ) && 
                (
                    this.FormationDate == input.FormationDate ||
                    (this.FormationDate != null &&
                    this.FormationDate.Equals(input.FormationDate))
                ) && 
                (
                    this.CompanyType == input.CompanyType ||
                    (this.CompanyType != null &&
                    this.CompanyType.Equals(input.CompanyType))
                ) && 
                (
                    this.RegisteredAddress == input.RegisteredAddress ||
                    (this.RegisteredAddress != null &&
                    this.RegisteredAddress.Equals(input.RegisteredAddress))
                ) && 
                (
                    this.CountryISOCode == input.CountryISOCode ||
                    (this.CountryISOCode != null &&
                    this.CountryISOCode.Equals(input.CountryISOCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Industries == input.Industries ||
                    this.Industries != null &&
                    input.Industries != null &&
                    this.Industries.SequenceEqual(input.Industries)
                ) && 
                (
                    this.KeyContactName == input.KeyContactName ||
                    (this.KeyContactName != null &&
                    this.KeyContactName.Equals(input.KeyContactName))
                ) && 
                (
                    this.CompanyWebsite == input.CompanyWebsite ||
                    (this.CompanyWebsite != null &&
                    this.CompanyWebsite.Equals(input.CompanyWebsite))
                ) && 
                (
                    this.ContactPhoneNumber == input.ContactPhoneNumber ||
                    (this.ContactPhoneNumber != null &&
                    this.ContactPhoneNumber.Equals(input.ContactPhoneNumber))
                ) && 
                (
                    this.ContactEmailAddress == input.ContactEmailAddress ||
                    (this.ContactEmailAddress != null &&
                    this.ContactEmailAddress.Equals(input.ContactEmailAddress))
                ) && 
                (
                    this.MerchantIds == input.MerchantIds ||
                    (this.MerchantIds != null &&
                    this.MerchantIds.Equals(input.MerchantIds))
                ) && 
                (
                    this.ConfirmedCreditSearch == input.ConfirmedCreditSearch ||
                    this.ConfirmedCreditSearch.Equals(input.ConfirmedCreditSearch)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.CompanyNumber != null)
                    hashCode = hashCode * 59 + this.CompanyNumber.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.FormationDate != null)
                    hashCode = hashCode * 59 + this.FormationDate.GetHashCode();
                if (this.CompanyType != null)
                    hashCode = hashCode * 59 + this.CompanyType.GetHashCode();
                if (this.RegisteredAddress != null)
                    hashCode = hashCode * 59 + this.RegisteredAddress.GetHashCode();
                if (this.CountryISOCode != null)
                    hashCode = hashCode * 59 + this.CountryISOCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Industries != null)
                    hashCode = hashCode * 59 + this.Industries.GetHashCode();
                if (this.KeyContactName != null)
                    hashCode = hashCode * 59 + this.KeyContactName.GetHashCode();
                if (this.CompanyWebsite != null)
                    hashCode = hashCode * 59 + this.CompanyWebsite.GetHashCode();
                if (this.ContactPhoneNumber != null)
                    hashCode = hashCode * 59 + this.ContactPhoneNumber.GetHashCode();
                if (this.ContactEmailAddress != null)
                    hashCode = hashCode * 59 + this.ContactEmailAddress.GetHashCode();
                if (this.MerchantIds != null)
                    hashCode = hashCode * 59 + this.MerchantIds.GetHashCode();
                hashCode = hashCode * 59 + this.ConfirmedCreditSearch.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
