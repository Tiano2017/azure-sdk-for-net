// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backend address pool settings of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayBackendHttpSettings : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHttpSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettings class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="port">Port</param>
        /// <param name="protocol">Protocol. Possible values include: 'Http',
        /// 'Https'</param>
        /// <param name="cookieBasedAffinity">Cookie based affinity. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="requestTimeout">Request timeout in seconds.
        /// Application Gateway will fail the request if response is not
        /// received within RequestTimeout. Acceptable values are from 1 second
        /// to 86400 seconds.</param>
        /// <param name="probe">Probe resource of an application
        /// gateway.</param>
        /// <param name="authenticationCertificates">Array of references to
        /// application gateway authentication certificates.</param>
        /// <param name="connectionDraining">Connection draining of the backend
        /// http settings resource.</param>
        /// <param name="hostName">Host header to be sent to the backend
        /// servers.</param>
        /// <param name="pickHostNameFromBackendAddress">Whether to pick host
        /// header should be picked from the host name of the backend server.
        /// Default value is false.</param>
        /// <param name="affinityCookieName">Cookie name to use for the
        /// affinity cookie.</param>
        /// <param name="probeEnabled">Whether the probe is enabled. Default
        /// value is false.</param>
        /// <param name="path">Path which should be used as a prefix for all
        /// HTTP requests. Null means no path will be prefixed. Default value
        /// is null.</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayBackendHttpSettings(string id = default(string), int? port = default(int?), string protocol = default(string), string cookieBasedAffinity = default(string), int? requestTimeout = default(int?), SubResource probe = default(SubResource), IList<SubResource> authenticationCertificates = default(IList<SubResource>), ApplicationGatewayConnectionDraining connectionDraining = default(ApplicationGatewayConnectionDraining), string hostName = default(string), bool? pickHostNameFromBackendAddress = default(bool?), string affinityCookieName = default(string), bool? probeEnabled = default(bool?), string path = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            Port = port;
            Protocol = protocol;
            CookieBasedAffinity = cookieBasedAffinity;
            RequestTimeout = requestTimeout;
            Probe = probe;
            AuthenticationCertificates = authenticationCertificates;
            ConnectionDraining = connectionDraining;
            HostName = hostName;
            PickHostNameFromBackendAddress = pickHostNameFromBackendAddress;
            AffinityCookieName = affinityCookieName;
            ProbeEnabled = probeEnabled;
            Path = path;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets port
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets protocol. Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets cookie based affinity. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cookieBasedAffinity")]
        public string CookieBasedAffinity { get; set; }

        /// <summary>
        /// Gets or sets request timeout in seconds. Application Gateway will
        /// fail the request if response is not received within RequestTimeout.
        /// Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTimeout")]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets probe resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probe")]
        public SubResource Probe { get; set; }

        /// <summary>
        /// Gets or sets array of references to application gateway
        /// authentication certificates.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationCertificates")]
        public IList<SubResource> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Gets or sets connection draining of the backend http settings
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionDraining")]
        public ApplicationGatewayConnectionDraining ConnectionDraining { get; set; }

        /// <summary>
        /// Gets or sets host header to be sent to the backend servers.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets whether to pick host header should be picked from the
        /// host name of the backend server. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pickHostNameFromBackendAddress")]
        public bool? PickHostNameFromBackendAddress { get; set; }

        /// <summary>
        /// Gets or sets cookie name to use for the affinity cookie.
        /// </summary>
        [JsonProperty(PropertyName = "properties.affinityCookieName")]
        public string AffinityCookieName { get; set; }

        /// <summary>
        /// Gets or sets whether the probe is enabled. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probeEnabled")]
        public bool? ProbeEnabled { get; set; }

        /// <summary>
        /// Gets or sets path which should be used as a prefix for all HTTP
        /// requests. Null means no path will be prefixed. Default value is
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "properties.path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionDraining != null)
            {
                ConnectionDraining.Validate();
            }
        }
    }
}