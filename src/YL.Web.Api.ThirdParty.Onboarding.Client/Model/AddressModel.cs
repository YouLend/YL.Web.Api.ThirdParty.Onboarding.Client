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
    /// Address Data Model
    /// </summary>
    [DataContract]
    public partial class AddressModel :  IEquatable<AddressModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddressModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressModel" /> class.
        /// </summary>
        /// <param name="line1">Gets or sets gets Address Line 1 (required).</param>
        /// <param name="line2">Gets or sets gets Address Line 2.</param>
        /// <param name="line3">Gets or sets gets Address Line 3.</param>
        /// <param name="city">Gets or sets gets City (required).</param>
        /// <param name="region">Gets or sets gets Region (required).</param>
        /// <param name="areaCode">Gets or sets gets Area Code (required).</param>
        /// <param name="country">Gets or sets gets Country (required).</param>
        public AddressModel(string line1 = default(string), string line2 = default(string), string line3 = default(string), string city = default(string), string region = default(string), string areaCode = default(string), string country = default(string))
        {
            // to ensure "line1" is required (not null)
            if (line1 == null)
            {
                throw new InvalidDataException("line1 is a required property for AddressModel and cannot be null");
            }
            else
            {
                this.Line1 = line1;
            }

            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for AddressModel and cannot be null");
            }
            else
            {
                this.City = city;
            }

            // to ensure "region" is required (not null)
            if (region == null)
            {
                throw new InvalidDataException("region is a required property for AddressModel and cannot be null");
            }
            else
            {
                this.Region = region;
            }

            // to ensure "areaCode" is required (not null)
            if (areaCode == null)
            {
                throw new InvalidDataException("areaCode is a required property for AddressModel and cannot be null");
            }
            else
            {
                this.AreaCode = areaCode;
            }

            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new InvalidDataException("country is a required property for AddressModel and cannot be null");
            }
            else
            {
                this.Country = country;
            }

            this.Line2 = line2;
            this.Line3 = line3;
        }
        
        /// <summary>
        /// Gets or sets gets Address Line 1
        /// </summary>
        /// <value>Gets or sets gets Address Line 1</value>
        [DataMember(Name="line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or sets gets Address Line 2
        /// </summary>
        /// <value>Gets or sets gets Address Line 2</value>
        [DataMember(Name="line2", EmitDefaultValue=false)]
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or sets gets Address Line 3
        /// </summary>
        /// <value>Gets or sets gets Address Line 3</value>
        [DataMember(Name="line3", EmitDefaultValue=false)]
        public string Line3 { get; set; }

        /// <summary>
        /// Gets or sets gets City
        /// </summary>
        /// <value>Gets or sets gets City</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets gets Region
        /// </summary>
        /// <value>Gets or sets gets Region</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets gets Area Code
        /// </summary>
        /// <value>Gets or sets gets Area Code</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or sets gets Country
        /// </summary>
        /// <value>Gets or sets gets Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressModel {\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Line3: ").Append(Line3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as AddressModel);
        }

        /// <summary>
        /// Returns true if AddressModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.Line3 == input.Line3 ||
                    (this.Line3 != null &&
                    this.Line3.Equals(input.Line3))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.Line3 != null)
                    hashCode = hashCode * 59 + this.Line3.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AreaCode != null)
                    hashCode = hashCode * 59 + this.AreaCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
            // Line1 (string) maxLength
            if(this.Line1 != null && this.Line1.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line1, length must be less than 255.", new [] { "Line1" });
            }

            // Line1 (string) minLength
            if(this.Line1 != null && this.Line1.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line1, length must be greater than 1.", new [] { "Line1" });
            }

            // Line2 (string) maxLength
            if(this.Line2 != null && this.Line2.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line2, length must be less than 255.", new [] { "Line2" });
            }

            // Line2 (string) minLength
            if(this.Line2 != null && this.Line2.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line2, length must be greater than 0.", new [] { "Line2" });
            }

            // Line3 (string) maxLength
            if(this.Line3 != null && this.Line3.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line3, length must be less than 255.", new [] { "Line3" });
            }

            // Line3 (string) minLength
            if(this.Line3 != null && this.Line3.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Line3, length must be greater than 0.", new [] { "Line3" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 255.", new [] { "City" });
            }

            // City (string) minLength
            if(this.City != null && this.City.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 1.", new [] { "City" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 255.", new [] { "Region" });
            }

            // Region (string) minLength
            if(this.Region != null && this.Region.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be greater than 1.", new [] { "Region" });
            }

            // AreaCode (string) maxLength
            if(this.AreaCode != null && this.AreaCode.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AreaCode, length must be less than 255.", new [] { "AreaCode" });
            }

            // AreaCode (string) minLength
            if(this.AreaCode != null && this.AreaCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AreaCode, length must be greater than 1.", new [] { "AreaCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 255.", new [] { "Country" });
            }

            // Country (string) minLength
            if(this.Country != null && this.Country.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be greater than 1.", new [] { "Country" });
            }

            yield break;
        }
    }

}
