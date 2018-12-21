/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetGatewayResponses Request Marshaller
    /// </summary>       
    public class GetGatewayResponsesRequestMarshaller : IMarshaller<IRequest, GetGatewayResponsesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetGatewayResponsesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetGatewayResponsesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";            
            request.HttpMethod = "GET";

            string uriResourcePath = "/restapis/{restapi_id}/gatewayresponses";
            if (!publicRequest.IsSetRestApiId())
                throw new AmazonAPIGatewayException("Request object does not have required field RestApiId set");
            uriResourcePath = uriResourcePath.Replace("{restapi_id}", StringUtils.FromStringWithSlashEncoding(publicRequest.RestApiId));
            
            if (publicRequest.IsSetLimit())
                request.Parameters.Add("limit", StringUtils.FromInt(publicRequest.Limit));
            
            if (publicRequest.IsSetPosition())
                request.Parameters.Add("position", StringUtils.FromString(publicRequest.Position));
            request.ResourcePath = uriResourcePath;
            request.UseQueryString = true;

            return request;
        }
        private static GetGatewayResponsesRequestMarshaller _instance = new GetGatewayResponsesRequestMarshaller();        

        internal static GetGatewayResponsesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetGatewayResponsesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}