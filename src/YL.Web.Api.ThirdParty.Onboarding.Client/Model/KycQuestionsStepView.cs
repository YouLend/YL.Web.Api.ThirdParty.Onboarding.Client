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
    /// KycQuestionsStepView
    /// </summary>
    [DataContract]
    public partial class KycQuestionsStepView :  IEquatable<KycQuestionsStepView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KycQuestionsStepView" /> class.
        /// </summary>
        /// <param name="leadId">leadId.</param>
        /// <param name="kycQuestions">kycQuestions.</param>
        public KycQuestionsStepView(Guid leadId = default(Guid), KycQuestions kycQuestions = default(KycQuestions))
        {
            this.LeadId = leadId;
            this.KycQuestions = kycQuestions;
        }
        
        /// <summary>
        /// Gets or Sets LeadId
        /// </summary>
        [DataMember(Name="leadId", EmitDefaultValue=false)]
        public Guid LeadId { get; set; }

        /// <summary>
        /// Gets or Sets KycQuestions
        /// </summary>
        [DataMember(Name="kycQuestions", EmitDefaultValue=false)]
        public KycQuestions KycQuestions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KycQuestionsStepView {\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  KycQuestions: ").Append(KycQuestions).Append("\n");
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
            return this.Equals(input as KycQuestionsStepView);
        }

        /// <summary>
        /// Returns true if KycQuestionsStepView instances are equal
        /// </summary>
        /// <param name="input">Instance of KycQuestionsStepView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KycQuestionsStepView input)
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
                    this.KycQuestions == input.KycQuestions ||
                    (this.KycQuestions != null &&
                    this.KycQuestions.Equals(input.KycQuestions))
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
                if (this.KycQuestions != null)
                    hashCode = hashCode * 59 + this.KycQuestions.GetHashCode();
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