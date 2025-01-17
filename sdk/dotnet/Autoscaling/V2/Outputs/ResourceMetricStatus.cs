// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Autoscaling.V2
{

    /// <summary>
    /// ResourceMetricStatus indicates the current value of a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.
    /// </summary>
    [OutputType]
    public sealed class ResourceMetricStatus
    {
        /// <summary>
        /// current contains the current value for the given metric
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Autoscaling.V2.MetricValueStatus Current;
        /// <summary>
        /// Name is the name of the resource in question.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ResourceMetricStatus(
            Pulumi.Kubernetes.Types.Outputs.Autoscaling.V2.MetricValueStatus current,

            string name)
        {
            Current = current;
            Name = name;
        }
    }
}
