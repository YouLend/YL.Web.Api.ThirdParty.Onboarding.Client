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
    /// AccountDetailsModel
    /// </summary>
    [DataContract]
    public partial class AccountDetailsModel :  IEquatable<AccountDetailsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountDetailsModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsModel" /> class.
        /// </summary>
        /// <param name="sortCode">sortCode (required).</param>
        /// <param name="accountNumber">accountNumber (required).</param>
        /// <param name="swift">swift (required).</param>
        /// <param name="iban">iban (required).</param>
        /// <param name="bankName">bankName (required).</param>
        /// <param name="confirmedCompanyAccount">confirmedCompanyAccount (required).</param>
        public AccountDetailsModel(string sortCode = default(string), string accountNumber = default(string), string swift = default(string), string iban = default(string), string bankName = default(string), bool confirmedCompanyAccount = default(bool))
        {
            // to ensure "sortCode" is required (not null)
            if (sortCode == null)
            {
                throw new InvalidDataException("sortCode is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.SortCode = sortCode;
            }

            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new InvalidDataException("accountNumber is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.AccountNumber = accountNumber;
            }

            // to ensure "swift" is required (not null)
            if (swift == null)
            {
                throw new InvalidDataException("swift is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.Swift = swift;
            }

            // to ensure "iban" is required (not null)
            if (iban == null)
            {
                throw new InvalidDataException("iban is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.Iban = iban;
            }

            // to ensure "bankName" is required (not null)
            if (bankName == null)
            {
                throw new InvalidDataException("bankName is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.BankName = bankName;
            }

            // to ensure "confirmedCompanyAccount" is required (not null)
            if (confirmedCompanyAccount == null)
            {
                throw new InvalidDataException("confirmedCompanyAccount is a required property for AccountDetailsModel and cannot be null");
            }
            else
            {
                this.ConfirmedCompanyAccount = confirmedCompanyAccount;
            }

        }
        
        /// <summary>
        /// Gets or Sets SortCode
        /// </summary>
        [DataMember(Name="sortCode", EmitDefaultValue=false)]
        public string SortCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Swift
        /// </summary>
        [DataMember(Name="swift", EmitDefaultValue=false)]
        public string Swift { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmedCompanyAccount
        /// </summary>
        [DataMember(Name="confirmedCompanyAccount", EmitDefaultValue=false)]
        public bool ConfirmedCompanyAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountDetailsModel {\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  ConfirmedCompanyAccount: ").Append(ConfirmedCompanyAccount).Append("\n");
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
            return this.Equals(input as AccountDetailsModel);
        }

        /// <summary>
        /// Returns true if AccountDetailsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountDetailsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountDetailsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Swift == input.Swift ||
                    (this.Swift != null &&
                    this.Swift.Equals(input.Swift))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.ConfirmedCompanyAccount == input.ConfirmedCompanyAccount ||
                    this.ConfirmedCompanyAccount.Equals(input.ConfirmedCompanyAccount)
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
                if (this.SortCode != null)
                    hashCode = hashCode * 59 + this.SortCode.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.Swift != null)
                    hashCode = hashCode * 59 + this.Swift.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                hashCode = hashCode * 59 + this.ConfirmedCompanyAccount.GetHashCode();
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
            // SortCode (string) minLength
            if(this.SortCode != null && this.SortCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SortCode, length must be greater than 1.", new [] { "SortCode" });
            }

            // AccountNumber (string) minLength
            if(this.AccountNumber != null && this.AccountNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be greater than 1.", new [] { "AccountNumber" });
            }

            // Swift (string) minLength
            if(this.Swift != null && this.Swift.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Swift, length must be greater than 1.", new [] { "Swift" });
            }

            // Iban (string) minLength
            if(this.Iban != null && this.Iban.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, length must be greater than 1.", new [] { "Iban" });
            }

            // BankName (string) minLength
            if(this.BankName != null && this.BankName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BankName, length must be greater than 1.", new [] { "BankName" });
            }

            yield break;
        }
    }

}
