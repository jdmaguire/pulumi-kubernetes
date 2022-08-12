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
    /// An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
    /// </summary>
    public class PreferredSchedulingTermPatchArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A node selector term, associated with the corresponding weight.
        /// </summary>
        [Input("preference")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.NodeSelectorTermPatchArgs>? Preference { get; set; }

        /// <summary>
        /// Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
        /// </summary>
        [Input("weight")]
        public Input<int>? Weight { get; set; }

        public PreferredSchedulingTermPatchArgs()
        {
        }
        public static new PreferredSchedulingTermPatchArgs Empty => new PreferredSchedulingTermPatchArgs();
    }
}