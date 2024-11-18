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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing OauthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OauthApiTests
    {
        private OauthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OauthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OauthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' OauthApi
            //Assert.IsInstanceOf(typeof(OauthApi), instance);
        }

        
        /// <summary>
        /// Test GetToken
        /// </summary>
        [Test]
        public void GetTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string clientSecret = null;
            //var response = instance.GetToken(clientId, clientSecret);
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
        /// <summary>
        /// Test GetUserInfo
        /// </summary>
        [Test]
        public void GetUserInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo();
            //Assert.IsInstanceOf(typeof(HttpEntity), response, "response is HttpEntity");
        }
        
        /// <summary>
        /// Test GetUserInfo1
        /// </summary>
        [Test]
        public void GetUserInfo1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserInfo1();
            //Assert.IsInstanceOf(typeof(HttpEntity), response, "response is HttpEntity");
        }
        
    }

}
