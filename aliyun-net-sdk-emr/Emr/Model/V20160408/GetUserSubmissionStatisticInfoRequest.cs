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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class GetUserSubmissionStatisticInfoRequest : RpcAcsRequest<GetUserSubmissionStatisticInfoResponse>
    {
        public GetUserSubmissionStatisticInfoRequest()
            : base("Emr", "2016-04-08", "GetUserSubmissionStatisticInfo", "emr", "openAPI")
        {
        }

		private string fromDatetime;

		private long? resourceOwnerId;

		private string regionId;

		private string clusterId;

		private string toDatetime;

		private string applicationType;

		private string accessKeyId;

		private string finalStatus;

		public string FromDatetime
		{
			get
			{
				return fromDatetime;
			}
			set	
			{
				fromDatetime = value;
				DictionaryUtil.Add(QueryParameters, "FromDatetime", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string ToDatetime
		{
			get
			{
				return toDatetime;
			}
			set	
			{
				toDatetime = value;
				DictionaryUtil.Add(QueryParameters, "ToDatetime", value);
			}
		}

		public string ApplicationType
		{
			get
			{
				return applicationType;
			}
			set	
			{
				applicationType = value;
				DictionaryUtil.Add(QueryParameters, "ApplicationType", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string FinalStatus
		{
			get
			{
				return finalStatus;
			}
			set	
			{
				finalStatus = value;
				DictionaryUtil.Add(QueryParameters, "FinalStatus", value);
			}
		}

        public override GetUserSubmissionStatisticInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetUserSubmissionStatisticInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
