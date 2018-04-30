using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.Azure.Management.ResourceManager;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using ResourceGroups.Tests;

namespace Resource.Tests.Helpers
{
    public static class ManagementGroupsTestUtilities
    {

        public static ManagementGroupsAPI GetManagementGroupsApiClient(MockContext context,
            RecordedDelegatingHandler handler = null)
        {
            if (handler != null)
            {
                handler.IsPassThrough = true;
            }

            var client = context.GetServiceClient<ManagementGroupsAPI>(
                handlers: handler ?? new RecordedDelegatingHandler {StatusCodeToReturn = HttpStatusCode.OK});

            return client;
        }
    }
}
