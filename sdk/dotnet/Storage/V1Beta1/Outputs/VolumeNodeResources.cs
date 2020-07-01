// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Storage.V1Beta1
{

    [OutputType]
    public sealed class VolumeNodeResources
    {
        /// <summary>
        /// Maximum number of unique volumes managed by the CSI driver that can be used on a node. A volume that is both attached and mounted on a node is considered to be used once, not twice. The same rule applies for a unique volume that is shared among multiple pods on the same node. If this field is nil, then the supported number of volumes on this node is unbounded.
        /// </summary>
        public readonly int Count;

        [OutputConstructor]
        private VolumeNodeResources(int count)
        {
            Count = count;
        }
    }
}