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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceDataTrimTitle Object
    /// </summary>  
    public class SourceDataTrimTitleUnmarshaller : IUnmarshaller<SourceDataTrimTitle, XmlUnmarshallerContext>, IUnmarshaller<SourceDataTrimTitle, JsonUnmarshallerContext>
    {
        public SourceDataTrimTitle Unmarshall(XmlUnmarshallerContext context)
        {
            SourceDataTrimTitle unmarshalledObject = new SourceDataTrimTitle();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DefaultValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DefaultValue = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Language", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Language = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Separator", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Separator = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SourceName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public SourceDataTrimTitle Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static SourceDataTrimTitleUnmarshaller _instance = new SourceDataTrimTitleUnmarshaller();        

        public static SourceDataTrimTitleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}