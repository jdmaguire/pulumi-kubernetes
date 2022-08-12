// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// ReplicationControllerSpec is the specification of a replication controller.
    /// </summary>
    public class ReplicationControllerSpecPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
        /// </summary>
        [Input("minReadySeconds")]
        public Input<int>? MinReadySeconds { get; set; }

        /// <summary>
        /// Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </summary>
        [Input("replicas")]
        public Input<int>? Replicas { get; set; }

        [Input("selector")]
        private InputMap<string>? _selector;

        /// <summary>
        /// Selector is a label query over pods that should match the Replicas count. If Selector is empty, it is defaulted to the labels present on the Pod template. Label keys and values that must match in order to be controlled by this replication controller, if empty defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        public InputMap<string> Selector
        {
            get => _selector ?? (_selector = new InputMap<string>());
            set => _selector = value;
        }

        /// <summary>
        /// Template is the object that describes the pod that will be created if insufficient replicas are detected. This takes precedence over a TemplateRef. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </summary>
        [Input("template")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodTemplateSpecPatchArgs>? Template { get; set; }

        public ReplicationControllerSpecPatchArgs()
        {
        }
        public static new ReplicationControllerSpecPatchArgs Empty => new ReplicationControllerSpecPatchArgs();
    }
}