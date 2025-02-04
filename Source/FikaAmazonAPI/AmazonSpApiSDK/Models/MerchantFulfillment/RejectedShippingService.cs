/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// Information about a rejected shipping service
    /// </summary>
    [DataContract]
    public partial class RejectedShippingService : IEquatable<RejectedShippingService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedShippingService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public RejectedShippingService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedShippingService" /> class.
        /// </summary>
        /// <param name="CarrierName">The rejected shipping carrier name. e.g. USPS (required).</param>
        /// <param name="ShippingServiceName">The rejected shipping service localized name. e.g. FedEx Standard Overnight (required).</param>
        /// <param name="ShippingServiceId">The rejected shipping service identifier. e.g. FEDEX_PTP_STANDARD_OVERNIGHT (required).</param>
        /// <param name="RejectionReasonCode">A reason code meant to be consumed programatically. e.g. CARRIER_CANNOT_SHIP_TO_POBOX (required).</param>
        /// <param name="RejectionReasonMessage">A localized human readable description of the rejected reason..</param>
        public RejectedShippingService(string CarrierName = default(string), string ShippingServiceName = default(string), ShippingServiceIdentifier ShippingServiceId = default(ShippingServiceIdentifier), string RejectionReasonCode = default(string), string RejectionReasonMessage = default(string))
        {
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for RejectedShippingService and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            // to ensure "ShippingServiceName" is required (not null)
            if (ShippingServiceName == null)
            {
                throw new InvalidDataException("ShippingServiceName is a required property for RejectedShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceName = ShippingServiceName;
            }
            // to ensure "ShippingServiceId" is required (not null)
            if (ShippingServiceId == null)
            {
                throw new InvalidDataException("ShippingServiceId is a required property for RejectedShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceId = ShippingServiceId;
            }
            // to ensure "RejectionReasonCode" is required (not null)
            if (RejectionReasonCode == null)
            {
                throw new InvalidDataException("RejectionReasonCode is a required property for RejectedShippingService and cannot be null");
            }
            else
            {
                this.RejectionReasonCode = RejectionReasonCode;
            }
            this.RejectionReasonMessage = RejectionReasonMessage;
        }

        /// <summary>
        /// The rejected shipping carrier name. e.g. USPS
        /// </summary>
        /// <value>The rejected shipping carrier name. e.g. USPS</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The rejected shipping service localized name. e.g. FedEx Standard Overnight
        /// </summary>
        /// <value>The rejected shipping service localized name. e.g. FedEx Standard Overnight</value>
        [DataMember(Name = "ShippingServiceName", EmitDefaultValue = false)]
        public string ShippingServiceName { get; set; }

        /// <summary>
        /// The rejected shipping service identifier. e.g. FEDEX_PTP_STANDARD_OVERNIGHT
        /// </summary>
        /// <value>The rejected shipping service identifier. e.g. FEDEX_PTP_STANDARD_OVERNIGHT</value>
        [DataMember(Name = "ShippingServiceId", EmitDefaultValue = false)]
        public ShippingServiceIdentifier ShippingServiceId { get; set; }

        /// <summary>
        /// A reason code meant to be consumed programatically. e.g. CARRIER_CANNOT_SHIP_TO_POBOX
        /// </summary>
        /// <value>A reason code meant to be consumed programatically. e.g. CARRIER_CANNOT_SHIP_TO_POBOX</value>
        [DataMember(Name = "RejectionReasonCode", EmitDefaultValue = false)]
        public string RejectionReasonCode { get; set; }

        /// <summary>
        /// A localized human readable description of the rejected reason.
        /// </summary>
        /// <value>A localized human readable description of the rejected reason.</value>
        [DataMember(Name = "RejectionReasonMessage", EmitDefaultValue = false)]
        public string RejectionReasonMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RejectedShippingService {\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ShippingServiceName: ").Append(ShippingServiceName).Append("\n");
            sb.Append("  ShippingServiceId: ").Append(ShippingServiceId).Append("\n");
            sb.Append("  RejectionReasonCode: ").Append(RejectionReasonCode).Append("\n");
            sb.Append("  RejectionReasonMessage: ").Append(RejectionReasonMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as RejectedShippingService);
        }

        /// <summary>
        /// Returns true if RejectedShippingService instances are equal
        /// </summary>
        /// <param name="input">Instance of RejectedShippingService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RejectedShippingService input)
        {
            if (input == null)
                return false;

            return
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    this.ShippingServiceName == input.ShippingServiceName ||
                    (this.ShippingServiceName != null &&
                    this.ShippingServiceName.Equals(input.ShippingServiceName))
                ) &&
                (
                    this.ShippingServiceId == input.ShippingServiceId ||
                    (this.ShippingServiceId != null &&
                    this.ShippingServiceId.Equals(input.ShippingServiceId))
                ) &&
                (
                    this.RejectionReasonCode == input.RejectionReasonCode ||
                    (this.RejectionReasonCode != null &&
                    this.RejectionReasonCode.Equals(input.RejectionReasonCode))
                ) &&
                (
                    this.RejectionReasonMessage == input.RejectionReasonMessage ||
                    (this.RejectionReasonMessage != null &&
                    this.RejectionReasonMessage.Equals(input.RejectionReasonMessage))
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
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.ShippingServiceName != null)
                    hashCode = hashCode * 59 + this.ShippingServiceName.GetHashCode();
                if (this.ShippingServiceId != null)
                    hashCode = hashCode * 59 + this.ShippingServiceId.GetHashCode();
                if (this.RejectionReasonCode != null)
                    hashCode = hashCode * 59 + this.RejectionReasonCode.GetHashCode();
                if (this.RejectionReasonMessage != null)
                    hashCode = hashCode * 59 + this.RejectionReasonMessage.GetHashCode();
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
