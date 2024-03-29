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
    /// A model containing data about organisations details step for a lead
    /// </summary>
    [DataContract]
    public partial class OrganisationDetailsV3StepView :  IEquatable<OrganisationDetailsV3StepView>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationDetailsV3StepView" /> class.
        /// </summary>
        /// <param name="leadId">Gets or sets the lead id.</param>
        /// <param name="organisationDetails">organisationDetails.</param>
        public OrganisationDetailsV3StepView(Guid leadId = default(Guid), OrganisationDetailsV3 organisationDetails = default(OrganisationDetailsV3))
        {
            this.LeadId = leadId;
            this.OrganisationDetails = organisationDetails;
        }
        
        /// <summary>
        /// Gets or sets the lead id
        /// </summary>
        /// <value>Gets or sets the lead id</value>
        [DataMember(Name="leadId", EmitDefaultValue=false)]
        public Guid LeadId { get; set; }

        /// <summary>
        /// Gets or Sets OrganisationDetails
        /// </summary>
        [DataMember(Name="organisationDetails", EmitDefaultValue=false)]
        public OrganisationDetailsV3 OrganisationDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganisationDetailsV3StepView {\n");
            sb.Append("  LeadId: ").Append(LeadId).Append("\n");
            sb.Append("  OrganisationDetails: ").Append(OrganisationDetails).Append("\n");
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
            return this.Equals(input as OrganisationDetailsV3StepView);
        }

        /// <summary>
        /// Returns true if OrganisationDetailsV3StepView instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationDetailsV3StepView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationDetailsV3StepView input)
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
                    this.OrganisationDetails == input.OrganisationDetails ||
                    (this.OrganisationDetails != null &&
                    this.OrganisationDetails.Equals(input.OrganisationDetails))
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
                if (this.OrganisationDetails != null)
                    hashCode = hashCode * 59 + this.OrganisationDetails.GetHashCode();
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
