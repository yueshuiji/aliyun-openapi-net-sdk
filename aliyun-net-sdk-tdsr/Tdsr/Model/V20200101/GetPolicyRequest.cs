/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.tdsr;
using Aliyun.Acs.tdsr.Transform;
using Aliyun.Acs.tdsr.Transform.V20200101;

namespace Aliyun.Acs.tdsr.Model.V20200101
{
    public class GetPolicyRequest : RpcAcsRequest<GetPolicyResponse>
    {
        public GetPolicyRequest()
            : base("tdsr", "2020-01-01", "GetPolicy")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string subSceneUuid;

		private string type;

		public string SubSceneUuid
		{
			get
			{
				return subSceneUuid;
			}
			set	
			{
				subSceneUuid = value;
				DictionaryUtil.Add(QueryParameters, "SubSceneUuid", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
