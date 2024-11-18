/* 
 * 运营商业务API接口
 *
 * 运营商业务API接口平台应用程序接口文档
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: henryxm@163.com
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CodeResponse
    /// </summary>
    [DataContract]
    public partial class CodeResponse :  IEquatable<CodeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CodeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeResponse" /> class.
        /// </summary>
        /// <param name="message">返回消息.</param>
        /// <param name="orderId">返回订单 (required).</param>
        /// <param name="result">返回结果.</param>
        public CodeResponse(string message = default(string), string orderId = default(string), string result = default(string))
        {
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new InvalidDataException("orderId is a required property for CodeResponse and cannot be null");
            }
            else
            {
                this.OrderId = orderId;
            }
            
            this.Message = message;
            this.Result = result;
        }
        
        /// <summary>
        /// 返回消息
        /// </summary>
        /// <value>返回消息</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回订单
        /// </summary>
        /// <value>返回订单</value>
        [DataMember(Name="orderId", EmitDefaultValue=true)]
        public string OrderId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <value>返回结果</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodeResponse {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CodeResponse);
        }

        /// <summary>
        /// Returns true if CodeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
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
