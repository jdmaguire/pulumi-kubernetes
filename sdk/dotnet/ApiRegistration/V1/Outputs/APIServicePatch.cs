// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.ApiRegistration.V1
{

    /// <summary>
    /// APIService represents a server for a particular GroupVersion. Name must be "version.group".
    /// </summary>
    [OutputType]
    public sealed class APIServicePatch
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        public readonly string ApiVersion;
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMetaPatch Metadata;
        /// <summary>
        /// Spec contains information for locating and communicating with a server
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.ApiRegistration.V1.APIServiceSpecPatch Spec;
        /// <summary>
        /// Status contains derived information about an API server
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.ApiRegistration.V1.APIServiceStatusPatch Status;

        [OutputConstructor]
        private APIServicePatch(
            string apiVersion,

            string kind,

            Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMetaPatch metadata,

            Pulumi.Kubernetes.Types.Outputs.ApiRegistration.V1.APIServiceSpecPatch spec,

            Pulumi.Kubernetes.Types.Outputs.ApiRegistration.V1.APIServiceStatusPatch status)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
        }
    }
}