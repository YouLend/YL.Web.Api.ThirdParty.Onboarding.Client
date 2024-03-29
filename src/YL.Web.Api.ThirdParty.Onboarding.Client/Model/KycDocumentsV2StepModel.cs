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
    /// Model containing data about the KYC document step
    /// </summary>
    [DataContract]
    public partial class KycDocumentsV2StepModel :  IEquatable<KycDocumentsV2StepModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KycDocumentsV2StepModel" /> class.
        /// </summary>
        /// <param name="companyDocuments">companyDocuments.</param>
        /// <param name="significantPersonDocuments">Gets or sets a list of YL.Web.Api.ThirdParty.Onboarding.Models.SignificantPersonDocumentsModel.</param>
        /// <param name="bankStatements">Gets or sets a Dictionary of Guids to YL.Web.Api.ThirdParty.Onboarding.Models.KycDocumentModel&amp;gt;.</param>
        /// <param name="leadId">Gets or sets the lead id.</param>
        /// <param name="country">Gets or sets the country.</param>
        /// <param name="companyType">Gets or sets the company type.</param>
        public KycDocumentsV2StepModel(Dictionary<string, KycDocumentModel> companyDocuments = default(Dictionary<string, KycDocumentModel>), List<SignificantPersonDocumentsModel> significantPersonDocuments = default(List<SignificantPersonDocumentsModel>), Dictionary<string, KycDocumentModel> bankStatements = default(Dictionary<string, KycDocumentModel>), Guid leadId = default(Guid), string country = default(string), string companyType = default(string))
        {
            this.CompanyDocuments = companyDocuments;
            this.SignificantPersonDocuments = significantPersonDocuments;
            this.BankStatements = bankStatements;
            this.LeadId = leadId;
            this.Country = country;
            this.CompanyType = companyType;
        }
        
        /// <summary>
        /// Gets or Sets CompanyDocuments
        /// </summary>
        [DataMember(Name="companyDocuments", EmitDefaultValue=false)]
        public Dictionary<string, KycDocumentModel> CompanyDocuments { get; set; }

        /// <summary>
        /// Gets or sets a list of YL.Web.Api.ThirdParty.Onboarding.Models.SignificantPersonDocumentsModel
        /// </summary>
        /// <value>Gets or sets a list of YL.Web.Api.ThirdParty.Onboarding.Models.SignificantPersonDocumentsModel</value>
        [DataMember(Name="significantPersonDocuments", EmitDefaultValue=false)]
        public List<SignificantPersonDocumentsModel> SignificantPersonDocuments { get; set; }

        /// <summary>
        /// Gets or sets a Dictionary of Guids to YL.Web.Api.ThirdParty.Onboarding.Models.KycDocumentModel&amp;gt;
        /// </summary>
        /// <value>Gets or sets a Dictionary of Guids to YL.Web.Api.ThirdParty.Onboarding.Models.KycDocumentModel&amp;gt;</value>
        [DataMember(Name="bankStatements", EmitDefaultValue=false)]
        public Dictionary<string, KycDocumentModel> BankStatements { get; set; }

        /// <summary>
        /// Gets or sets the lead id
        /// </summary>
        /// <value>Gets or sets the lead id</value>
        [DataMember(Name="leadId", EmitDefaultValue=false)]
        public Guid LeadId { get; set; }

        /// <summary>
        /// Gets or sets the country
        /// </summary>
        /// <value>Gets or sets the country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the company type
        /// </summary>
        /// <value>Gets or sets the company type</value>
        [DataMember(Name="companyType", EmitDefaultValue=false)]
        public string CompanyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KycDocumentsV2StepModel {\n");
            sb.Append("  CompanyDocuments: ").Append(CompanyDocuments).Append("\n");
            sb.Append("  SignificantPersonDocuments: ").Append(SignificantPersonDocuments).Append("\n");
            sb.Append("  BankStatements: ").Append(BankStatements).Append("\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
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
            return this.Equals(input as KycDocumentsV2StepModel);
        }

        /// <summary>
        /// Returns true if KycDocumentsV2StepModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KycDocumentsV2StepModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KycDocumentsV2StepModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyDocuments == input.CompanyDocuments ||
                    this.CompanyDocuments != null &&
                    input.CompanyDocuments != null &&
                    this.CompanyDocuments.SequenceEqual(input.CompanyDocuments)
                ) && 
                (
                    this.SignificantPersonDocuments == input.SignificantPersonDocuments ||
                    this.SignificantPersonDocuments != null &&
                    input.SignificantPersonDocuments != null &&
                    this.SignificantPersonDocuments.SequenceEqual(input.SignificantPersonDocuments)
                ) && 
                (
                    this.BankStatements == input.BankStatements ||
                    this.BankStatements != null &&
                    input.BankStatements != null &&
                    this.BankStatements.SequenceEqual(input.BankStatements)
                ) && 
                (
                    this.LeadId == input.LeadId ||
                    (this.LeadId != null &&
                    this.LeadId.Equals(input.LeadId))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CompanyType == input.CompanyType ||
                    (this.CompanyType != null &&
                    this.CompanyType.Equals(input.CompanyType))
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
                if (this.CompanyDocuments != null)
                    hashCode = hashCode * 59 + this.CompanyDocuments.GetHashCode();
                if (this.SignificantPersonDocuments != null)
                    hashCode = hashCode * 59 + this.SignificantPersonDocuments.GetHashCode();
                if (this.BankStatements != null)
                    hashCode = hashCode * 59 + this.BankStatements.GetHashCode();
                if (this.LeadId != null)
                    hashCode = hashCode * 59 + this.LeadId.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CompanyType != null)
                    hashCode = hashCode * 59 + this.CompanyType.GetHashCode();
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
