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
    /// The result of creating a third party lead
    /// </summary>
    [DataContract]
    public partial class CreateThirdPartyAdvanceOnboardingResultModel :  IEquatable<CreateThirdPartyAdvanceOnboardingResultModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThirdPartyAdvanceOnboardingResultModel" /> class.
        /// </summary>
        /// <param name="leadId">Gets or sets the Lead Id.</param>
        /// <param name="leadURL">Gets or sets the Lead redirect URL.</param>
        /// <param name="signUpURL">Gets or sets the broker redirect URL.</param>
        public CreateThirdPartyAdvanceOnboardingResultModel(Guid leadId = default(Guid), string leadURL = default(string), string signUpURL = default(string))
        {
            this.LeadId = leadId;
            this.LeadURL = leadURL;
            this.SignUpURL = signUpURL;
        }
        
        /// <summary>
        /// Gets or sets the Lead Id
        /// </summary>
        /// <value>Gets or sets the Lead Id</value>
        [DataMember(Name="leadId", EmitDefaultValue=false)]
        public Guid LeadId { get; set; }

        /// <summary>
        /// Gets or sets the Lead redirect URL
        /// </summary>
        /// <value>Gets or sets the Lead redirect URL</value>
        [DataMember(Name="leadURL", EmitDefaultValue=false)]
        public string LeadURL { get; set; }

        /// <summary>
        /// Gets or sets the broker redirect URL
        /// </summary>
        /// <value>Gets or sets the broker redirect URL</value>
        [DataMember(Name="signUpURL", EmitDefaultValue=false)]
        public string SignUpURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateThirdPartyAdvanceOnboardingResultModel {\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  LeadURL: ").Append(LeadURL).Append("\n");
            sb.Append("  SignUpURL: ").Append(SignUpURL).Append("\n");
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
            return this.Equals(input as CreateThirdPartyAdvanceOnboardingResultModel);
        }

        /// <summary>
        /// Returns true if CreateThirdPartyAdvanceOnboardingResultModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateThirdPartyAdvanceOnboardingResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateThirdPartyAdvanceOnboardingResultModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeadId == input.LeadId ||
                    (this.LeadId != null &&
                    this.LeadId.Equals(input.LeadId))
                ) && 
                (
                    this.LeadURL == input.LeadURL ||
                    (this.LeadURL != null &&
                    this.LeadURL.Equals(input.LeadURL))
                ) && 
                (
                    this.SignUpURL == input.SignUpURL ||
                    (this.SignUpURL != null &&
                    this.SignUpURL.Equals(input.SignUpURL))
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
                if (this.LeadId != null)
                    hashCode = hashCode * 59 + this.LeadId.GetHashCode();
                if (this.LeadURL != null)
                    hashCode = hashCode * 59 + this.LeadURL.GetHashCode();
                if (this.SignUpURL != null)
                    hashCode = hashCode * 59 + this.SignUpURL.GetHashCode();
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