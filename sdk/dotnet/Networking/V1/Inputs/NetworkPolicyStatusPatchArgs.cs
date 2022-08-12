// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Networking.V1
{

    /// <summary>
    /// NetworkPolicyStatus describe the current state of the NetworkPolicy.
    /// </summary>
    public class NetworkPolicyStatusPatchArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionPatchArgs>? _conditions;

        /// <summary>
        /// Conditions holds an array of metav1.Condition that describe the state of the NetworkPolicy. Current service state
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionPatchArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionPatchArgs>());
            set => _conditions = value;
        }

        public NetworkPolicyStatusPatchArgs()
        {
        }
    }
}