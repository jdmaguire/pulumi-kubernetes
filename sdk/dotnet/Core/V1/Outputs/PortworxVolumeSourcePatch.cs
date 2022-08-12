// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    /// <summary>
    /// PortworxVolumeSource represents a Portworx volume resource.
    /// </summary>
    [OutputType]
    public sealed class PortworxVolumeSourcePatch
    {
        /// <summary>
        /// fSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        public readonly string FsType;
        /// <summary>
        /// readOnly defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        public readonly bool ReadOnly;
        /// <summary>
        /// volumeID uniquely identifies a Portworx volume
        /// </summary>
        public readonly string VolumeID;

        [OutputConstructor]
        private PortworxVolumeSourcePatch(
            string fsType,

            bool readOnly,

            string volumeID)
        {
            FsType = fsType;
            ReadOnly = readOnly;
            VolumeID = volumeID;
        }
    }
}