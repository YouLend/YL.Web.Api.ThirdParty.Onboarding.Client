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
    /// KycQuestions
    /// </summary>
    [DataContract]
    public partial class KycQuestions :  IEquatable<KycQuestions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KycQuestions" /> class.
        /// </summary>
        /// <param name="everTerminated">everTerminated.</param>
        /// <param name="anyPoliticallyExposedPeople">anyPoliticallyExposedPeople.</param>
        /// <param name="businessArea">businessArea.</param>
        /// <param name="countriesOperateIn">countriesOperateIn.</param>
        /// <param name="anyLawEnforcedSanctions">anyLawEnforcedSanctions.</param>
        /// <param name="anyTerrorismFinancing">anyTerrorismFinancing.</param>
        /// <param name="anyCriminals">anyCriminals.</param>
        public KycQuestions(KycYesNoQuestion everTerminated = default(KycYesNoQuestion), KycYesNoQuestion anyPoliticallyExposedPeople = default(KycYesNoQuestion), KycFreeTextQuestion businessArea = default(KycFreeTextQuestion), KycFreeTextQuestion countriesOperateIn = default(KycFreeTextQuestion), KycYesNoQuestion anyLawEnforcedSanctions = default(KycYesNoQuestion), KycYesNoQuestion anyTerrorismFinancing = default(KycYesNoQuestion), KycYesNoQuestion anyCriminals = default(KycYesNoQuestion))
        {
            this.EverTerminated = everTerminated;
            this.AnyPoliticallyExposedPeople = anyPoliticallyExposedPeople;
            this.BusinessArea = businessArea;
            this.CountriesOperateIn = countriesOperateIn;
            this.AnyLawEnforcedSanctions = anyLawEnforcedSanctions;
            this.AnyTerrorismFinancing = anyTerrorismFinancing;
            this.AnyCriminals = anyCriminals;
        }
        
        /// <summary>
        /// Gets or Sets EverTerminated
        /// </summary>
        [DataMember(Name="everTerminated", EmitDefaultValue=false)]
        public KycYesNoQuestion EverTerminated { get; set; }

        /// <summary>
        /// Gets or Sets AnyPoliticallyExposedPeople
        /// </summary>
        [DataMember(Name="anyPoliticallyExposedPeople", EmitDefaultValue=false)]
        public KycYesNoQuestion AnyPoliticallyExposedPeople { get; set; }

        /// <summary>
        /// Gets or Sets BusinessArea
        /// </summary>
        [DataMember(Name="businessArea", EmitDefaultValue=false)]
        public KycFreeTextQuestion BusinessArea { get; set; }

        /// <summary>
        /// Gets or Sets CountriesOperateIn
        /// </summary>
        [DataMember(Name="countriesOperateIn", EmitDefaultValue=false)]
        public KycFreeTextQuestion CountriesOperateIn { get; set; }

        /// <summary>
        /// Gets or Sets AnyLawEnforcedSanctions
        /// </summary>
        [DataMember(Name="anyLawEnforcedSanctions", EmitDefaultValue=false)]
        public KycYesNoQuestion AnyLawEnforcedSanctions { get; set; }

        /// <summary>
        /// Gets or Sets AnyTerrorismFinancing
        /// </summary>
        [DataMember(Name="anyTerrorismFinancing", EmitDefaultValue=false)]
        public KycYesNoQuestion AnyTerrorismFinancing { get; set; }

        /// <summary>
        /// Gets or Sets AnyCriminals
        /// </summary>
        [DataMember(Name="anyCriminals", EmitDefaultValue=false)]
        public KycYesNoQuestion AnyCriminals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KycQuestions {\n");
            sb.Append("  EverTerminated: ").Append(EverTerminated).Append("\n");
            sb.Append("  AnyPoliticallyExposedPeople: ").Append(AnyPoliticallyExposedPeople).Append("\n");
            sb.Append("  BusinessArea: ").Append(BusinessArea).Append("\n");
            sb.Append("  CountriesOperateIn: ").Append(CountriesOperateIn).Append("\n");
            sb.Append("  AnyLawEnforcedSanctions: ").Append(AnyLawEnforcedSanctions).Append("\n");
            sb.Append("  AnyTerrorismFinancing: ").Append(AnyTerrorismFinancing).Append("\n");
            sb.Append("  AnyCriminals: ").Append(AnyCriminals).Append("\n");
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
            return this.Equals(input as KycQuestions);
        }

        /// <summary>
        /// Returns true if KycQuestions instances are equal
        /// </summary>
        /// <param name="input">Instance of KycQuestions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KycQuestions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EverTerminated == input.EverTerminated ||
                    (this.EverTerminated != null &&
                    this.EverTerminated.Equals(input.EverTerminated))
                ) && 
                (
                    this.AnyPoliticallyExposedPeople == input.AnyPoliticallyExposedPeople ||
                    (this.AnyPoliticallyExposedPeople != null &&
                    this.AnyPoliticallyExposedPeople.Equals(input.AnyPoliticallyExposedPeople))
                ) && 
                (
                    this.BusinessArea == input.BusinessArea ||
                    (this.BusinessArea != null &&
                    this.BusinessArea.Equals(input.BusinessArea))
                ) && 
                (
                    this.CountriesOperateIn == input.CountriesOperateIn ||
                    (this.CountriesOperateIn != null &&
                    this.CountriesOperateIn.Equals(input.CountriesOperateIn))
                ) && 
                (
                    this.AnyLawEnforcedSanctions == input.AnyLawEnforcedSanctions ||
                    (this.AnyLawEnforcedSanctions != null &&
                    this.AnyLawEnforcedSanctions.Equals(input.AnyLawEnforcedSanctions))
                ) && 
                (
                    this.AnyTerrorismFinancing == input.AnyTerrorismFinancing ||
                    (this.AnyTerrorismFinancing != null &&
                    this.AnyTerrorismFinancing.Equals(input.AnyTerrorismFinancing))
                ) && 
                (
                    this.AnyCriminals == input.AnyCriminals ||
                    (this.AnyCriminals != null &&
                    this.AnyCriminals.Equals(input.AnyCriminals))
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
                if (this.EverTerminated != null)
                    hashCode = hashCode * 59 + this.EverTerminated.GetHashCode();
                if (this.AnyPoliticallyExposedPeople != null)
                    hashCode = hashCode * 59 + this.AnyPoliticallyExposedPeople.GetHashCode();
                if (this.BusinessArea != null)
                    hashCode = hashCode * 59 + this.BusinessArea.GetHashCode();
                if (this.CountriesOperateIn != null)
                    hashCode = hashCode * 59 + this.CountriesOperateIn.GetHashCode();
                if (this.AnyLawEnforcedSanctions != null)
                    hashCode = hashCode * 59 + this.AnyLawEnforcedSanctions.GetHashCode();
                if (this.AnyTerrorismFinancing != null)
                    hashCode = hashCode * 59 + this.AnyTerrorismFinancing.GetHashCode();
                if (this.AnyCriminals != null)
                    hashCode = hashCode * 59 + this.AnyCriminals.GetHashCode();
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
