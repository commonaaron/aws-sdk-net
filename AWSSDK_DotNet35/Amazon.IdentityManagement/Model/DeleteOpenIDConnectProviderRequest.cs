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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOpenIDConnectProvider operation.
    /// Deletes an IAM OpenID Connect identity provider.
    /// 
    ///  
    /// <para>
    /// Deleting an OIDC provider does not update any roles that reference the provider as
    /// a principal in their trust policies. Any attempt to assume a role that references
    /// a provider that has been deleted will fail. 
    /// </para>
    ///  
    /// <para>
    /// This action is idempotent; it does not fail or return an error if you call the action
    /// for a provider that was already deleted.
    /// </para>
    /// </summary>
    public partial class DeleteOpenIDConnectProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _openIDConnectProviderArn;

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM OpenID Connect provider to delete. You can
        /// get a list of OpenID Connect provider ARNs by using the <a>ListOpenIDConnectProviders</a>
        /// action.
        /// </para>
        /// </summary>
        public string OpenIDConnectProviderArn
        {
            get { return this._openIDConnectProviderArn; }
            set { this._openIDConnectProviderArn = value; }
        }

        // Check to see if OpenIDConnectProviderArn property is set
        internal bool IsSetOpenIDConnectProviderArn()
        {
            return this._openIDConnectProviderArn != null;
        }

    }
}