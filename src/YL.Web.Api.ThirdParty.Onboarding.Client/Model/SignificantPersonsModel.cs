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
    /// Collection of significant persons
    /// </summary>
    [DataContract]
    public partial class SignificantPersonsModel :  IEquatable<SignificantPersonsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignificantPersonsModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignificantPersonsModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignificantPersonsModel" /> class.
        /// </summary>
        /// <param name="significantPersons">Gets or sets a list of significant persons (required).</param>
        public SignificantPersonsModel(List<SignificantPersonModel> significantPersons = default(List<SignificantPersonModel>))
        {
            // to ensure "significantPersons" is required (not null)
            if (significantPersons == null)
            {
                throw new InvalidDataException("significantPersons is a required property for SignificantPersonsModel and cannot be null");
            }
            else
            {
                this.SignificantPersons = significantPersons;
            }

        }
        
        /// <summary>
        /// Gets or sets a list of significant persons
        /// </summary>
        /// <value>Gets or sets a list of significant persons</value>
        [DataMember(Name="significantPersons", EmitDefaultValue=false)]
        public List<SignificantPersonModel> SignificantPersons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignificantPersonsModel {\n");
            sb.Append("  SignificantPersons: ").Append(SignificantPersons).Append("\n");
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
            return this.Equals(input as SignificantPersonsModel);
        }

        /// <summary>
        /// Returns true if SignificantPersonsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SignificantPersonsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignificantPersonsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignificantPersons == input.SignificantPersons ||
                    this.SignificantPersons != null &&
                    input.SignificantPersons != null &&
                    this.SignificantPersons.SequenceEqual(input.SignificantPersons)
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
                if (this.SignificantPersons != null)
                    hashCode = hashCode * 59 + this.SignificantPersons.GetHashCode();
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