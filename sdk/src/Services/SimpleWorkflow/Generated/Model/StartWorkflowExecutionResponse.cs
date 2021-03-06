/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains the response data from the StartWorkflowExecution operation.
    /// </summary>
    public partial class StartWorkflowExecutionResponse : AmazonWebServiceResponse
    {
        private Run _run;

        /// <summary>
        /// Gets and sets the Run member
        /// </summary>
        public Run Run
        {
            get { return this._run; }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run != null;
        }
    }
}