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
    /// OutResponseOfCodeResponse
    /// </summary>
    [DataContract]
    public partial class OutResponseOfCodeResponse :  IEquatable<OutResponseOfCodeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutResponseOfCodeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OutResponseOfCodeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutResponseOfCodeResponse" /> class.
        /// </summary>
        /// <param name="code">响应代码 (required).</param>
        /// <param name="data">data.</param>
        /// <param name="msg">错误信息:成功时为空或为success.</param>
        public OutResponseOfCodeResponse(int code = default(int), CodeResponse data = default(CodeResponse), string msg = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for OutResponseOfCodeResponse and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            this.Data = data;
            this.Msg = msg;
        }
        
        /// <summary>
        /// 响应代码
        /// </summary>
        /// <value>响应代码</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public int Code { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public CodeResponse Data { get; set; }

        /// <summary>
        /// 错误信息:成功时为空或为success
        /// </summary>
        /// <value>错误信息:成功时为空或为success</value>
        [DataMember(Name="msg", EmitDefaultValue=false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutResponseOfCodeResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as OutResponseOfCodeResponse);
        }

        /// <summary>
        /// Returns true if OutResponseOfCodeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OutResponseOfCodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutResponseOfCodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
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
