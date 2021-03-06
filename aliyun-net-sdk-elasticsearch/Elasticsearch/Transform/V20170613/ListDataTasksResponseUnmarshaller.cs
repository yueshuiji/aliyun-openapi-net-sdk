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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListDataTasksResponseUnmarshaller
    {
        public static ListDataTasksResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataTasksResponse listDataTasksResponse = new ListDataTasksResponse();

			listDataTasksResponse.HttpResponse = context.HttpResponse;
			listDataTasksResponse.RequestId = context.StringValue("ListDataTasks.RequestId");

			List<ListDataTasksResponse.ListDataTasks_ResultItem> listDataTasksResponse_result = new List<ListDataTasksResponse.ListDataTasks_ResultItem>();
			for (int i = 0; i < context.Length("ListDataTasks.Result.Length"); i++) {
				ListDataTasksResponse.ListDataTasks_ResultItem resultItem = new ListDataTasksResponse.ListDataTasks_ResultItem();
				resultItem.CreateTime = context.StringValue("ListDataTasks.Result["+ i +"].createTime");
				resultItem.Status = context.StringValue("ListDataTasks.Result["+ i +"].status");
				resultItem.TaskId = context.StringValue("ListDataTasks.Result["+ i +"].taskId");

				ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SinkCluster sinkCluster = new ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SinkCluster();
				sinkCluster.DataSourceType = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.dataSourceType");
				sinkCluster.Endpoint = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.endpoint");
				sinkCluster.Index = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.index");
				sinkCluster.Type = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.type");
				sinkCluster.VpcId = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcId");
				sinkCluster.VpcInstanceId = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcInstanceId");
				sinkCluster.VpcInstancePort = context.StringValue("ListDataTasks.Result["+ i +"].SinkCluster.vpcInstancePort");
				resultItem.SinkCluster = sinkCluster;

				ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SourceCluster sourceCluster = new ListDataTasksResponse.ListDataTasks_ResultItem.ListDataTasks_SourceCluster();
				sourceCluster.DataSourceType = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.dataSourceType");
				sourceCluster.Index = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.index");
				sourceCluster.Mapping = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.mapping");
				sourceCluster.Routing = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.routing");
				sourceCluster.Settings = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.settings");
				sourceCluster.Type = context.StringValue("ListDataTasks.Result["+ i +"].SourceCluster.type");
				resultItem.SourceCluster = sourceCluster;

				listDataTasksResponse_result.Add(resultItem);
			}
			listDataTasksResponse.Result = listDataTasksResponse_result;
        
			return listDataTasksResponse;
        }
    }
}
