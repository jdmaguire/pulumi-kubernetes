# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ... import meta as _meta

__all__ = [
    'Lease',
    'LeaseSpec',
]

@pulumi.output_type
class Lease(dict):
    """
    Lease defines a lease concept.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "apiVersion":
            suggest = "api_version"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in Lease. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        Lease.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        Lease.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 api_version: Optional[str] = None,
                 kind: Optional[str] = None,
                 metadata: Optional['_meta.v1.outputs.ObjectMeta'] = None,
                 spec: Optional['outputs.LeaseSpec'] = None):
        """
        Lease defines a lease concept.
        :param str api_version: APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        :param str kind: Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        :param '_meta.v1.ObjectMetaArgs' metadata: More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        :param 'LeaseSpecArgs' spec: Specification of the Lease. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        if api_version is not None:
            pulumi.set(__self__, "api_version", 'coordination.k8s.io/v1beta1')
        if kind is not None:
            pulumi.set(__self__, "kind", 'Lease')
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if spec is not None:
            pulumi.set(__self__, "spec", spec)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> Optional[str]:
        """
        APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        """
        return pulumi.get(self, "api_version")

    @property
    @pulumi.getter
    def kind(self) -> Optional[str]:
        """
        Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def metadata(self) -> Optional['_meta.v1.outputs.ObjectMeta']:
        """
        More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def spec(self) -> Optional['outputs.LeaseSpec']:
        """
        Specification of the Lease. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        return pulumi.get(self, "spec")


@pulumi.output_type
class LeaseSpec(dict):
    """
    LeaseSpec is a specification of a Lease.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "acquireTime":
            suggest = "acquire_time"
        elif key == "holderIdentity":
            suggest = "holder_identity"
        elif key == "leaseDurationSeconds":
            suggest = "lease_duration_seconds"
        elif key == "leaseTransitions":
            suggest = "lease_transitions"
        elif key == "renewTime":
            suggest = "renew_time"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in LeaseSpec. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        LeaseSpec.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        LeaseSpec.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 acquire_time: Optional[str] = None,
                 holder_identity: Optional[str] = None,
                 lease_duration_seconds: Optional[int] = None,
                 lease_transitions: Optional[int] = None,
                 renew_time: Optional[str] = None):
        """
        LeaseSpec is a specification of a Lease.
        :param str acquire_time: acquireTime is a time when the current lease was acquired.
        :param str holder_identity: holderIdentity contains the identity of the holder of a current lease.
        :param int lease_duration_seconds: leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.
        :param int lease_transitions: leaseTransitions is the number of transitions of a lease between holders.
        :param str renew_time: renewTime is a time when the current holder of a lease has last updated the lease.
        """
        if acquire_time is not None:
            pulumi.set(__self__, "acquire_time", acquire_time)
        if holder_identity is not None:
            pulumi.set(__self__, "holder_identity", holder_identity)
        if lease_duration_seconds is not None:
            pulumi.set(__self__, "lease_duration_seconds", lease_duration_seconds)
        if lease_transitions is not None:
            pulumi.set(__self__, "lease_transitions", lease_transitions)
        if renew_time is not None:
            pulumi.set(__self__, "renew_time", renew_time)

    @property
    @pulumi.getter(name="acquireTime")
    def acquire_time(self) -> Optional[str]:
        """
        acquireTime is a time when the current lease was acquired.
        """
        return pulumi.get(self, "acquire_time")

    @property
    @pulumi.getter(name="holderIdentity")
    def holder_identity(self) -> Optional[str]:
        """
        holderIdentity contains the identity of the holder of a current lease.
        """
        return pulumi.get(self, "holder_identity")

    @property
    @pulumi.getter(name="leaseDurationSeconds")
    def lease_duration_seconds(self) -> Optional[int]:
        """
        leaseDurationSeconds is a duration that candidates for a lease need to wait to force acquire it. This is measure against time of last observed RenewTime.
        """
        return pulumi.get(self, "lease_duration_seconds")

    @property
    @pulumi.getter(name="leaseTransitions")
    def lease_transitions(self) -> Optional[int]:
        """
        leaseTransitions is the number of transitions of a lease between holders.
        """
        return pulumi.get(self, "lease_transitions")

    @property
    @pulumi.getter(name="renewTime")
    def renew_time(self) -> Optional[str]:
        """
        renewTime is a time when the current holder of a lease has last updated the lease.
        """
        return pulumi.get(self, "renew_time")


