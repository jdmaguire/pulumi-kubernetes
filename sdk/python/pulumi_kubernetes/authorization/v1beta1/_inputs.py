# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'NonResourceAttributesArgs',
    'ResourceAttributesArgs',
    'SelfSubjectAccessReviewSpecArgs',
    'SelfSubjectRulesReviewSpecArgs',
    'SubjectAccessReviewSpecArgs',
]

@pulumi.input_type
class NonResourceAttributesArgs:
    def __init__(__self__, *,
                 path: Optional[pulumi.Input[str]] = None,
                 verb: Optional[pulumi.Input[str]] = None):
        """
        NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface
        :param pulumi.Input[str] path: Path is the URL path of the request
        :param pulumi.Input[str] verb: Verb is the standard HTTP verb
        """
        if path is not None:
            pulumi.set(__self__, "path", path)
        if verb is not None:
            pulumi.set(__self__, "verb", verb)

    @property
    @pulumi.getter
    def path(self) -> Optional[pulumi.Input[str]]:
        """
        Path is the URL path of the request
        """
        return pulumi.get(self, "path")

    @path.setter
    def path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "path", value)

    @property
    @pulumi.getter
    def verb(self) -> Optional[pulumi.Input[str]]:
        """
        Verb is the standard HTTP verb
        """
        return pulumi.get(self, "verb")

    @verb.setter
    def verb(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "verb", value)


@pulumi.input_type
class ResourceAttributesArgs:
    def __init__(__self__, *,
                 group: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 namespace: Optional[pulumi.Input[str]] = None,
                 resource: Optional[pulumi.Input[str]] = None,
                 subresource: Optional[pulumi.Input[str]] = None,
                 verb: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface
        :param pulumi.Input[str] group: Group is the API Group of the Resource.  "*" means all.
        :param pulumi.Input[str] name: Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.
        :param pulumi.Input[str] namespace: Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
        :param pulumi.Input[str] resource: Resource is one of the existing resource types.  "*" means all.
        :param pulumi.Input[str] subresource: Subresource is one of the existing resource types.  "" means none.
        :param pulumi.Input[str] verb: Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "*" means all.
        :param pulumi.Input[str] version: Version is the API Version of the Resource.  "*" means all.
        """
        if group is not None:
            pulumi.set(__self__, "group", group)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)
        if resource is not None:
            pulumi.set(__self__, "resource", resource)
        if subresource is not None:
            pulumi.set(__self__, "subresource", subresource)
        if verb is not None:
            pulumi.set(__self__, "verb", verb)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def group(self) -> Optional[pulumi.Input[str]]:
        """
        Group is the API Group of the Resource.  "*" means all.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name is the name of the resource being requested for a "get" or deleted for a "delete". "" (empty) means all.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace is the namespace of the action being requested.  Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)

    @property
    @pulumi.getter
    def resource(self) -> Optional[pulumi.Input[str]]:
        """
        Resource is one of the existing resource types.  "*" means all.
        """
        return pulumi.get(self, "resource")

    @resource.setter
    def resource(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource", value)

    @property
    @pulumi.getter
    def subresource(self) -> Optional[pulumi.Input[str]]:
        """
        Subresource is one of the existing resource types.  "" means none.
        """
        return pulumi.get(self, "subresource")

    @subresource.setter
    def subresource(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subresource", value)

    @property
    @pulumi.getter
    def verb(self) -> Optional[pulumi.Input[str]]:
        """
        Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.  "*" means all.
        """
        return pulumi.get(self, "verb")

    @verb.setter
    def verb(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "verb", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Version is the API Version of the Resource.  "*" means all.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class SelfSubjectAccessReviewSpecArgs:
    def __init__(__self__, *,
                 non_resource_attributes: Optional[pulumi.Input['NonResourceAttributesArgs']] = None,
                 resource_attributes: Optional[pulumi.Input['ResourceAttributesArgs']] = None):
        """
        SelfSubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
        :param pulumi.Input['NonResourceAttributesArgs'] non_resource_attributes: NonResourceAttributes describes information for a non-resource access request
        :param pulumi.Input['ResourceAttributesArgs'] resource_attributes: ResourceAuthorizationAttributes describes information for a resource access request
        """
        if non_resource_attributes is not None:
            pulumi.set(__self__, "non_resource_attributes", non_resource_attributes)
        if resource_attributes is not None:
            pulumi.set(__self__, "resource_attributes", resource_attributes)

    @property
    @pulumi.getter(name="nonResourceAttributes")
    def non_resource_attributes(self) -> Optional[pulumi.Input['NonResourceAttributesArgs']]:
        """
        NonResourceAttributes describes information for a non-resource access request
        """
        return pulumi.get(self, "non_resource_attributes")

    @non_resource_attributes.setter
    def non_resource_attributes(self, value: Optional[pulumi.Input['NonResourceAttributesArgs']]):
        pulumi.set(self, "non_resource_attributes", value)

    @property
    @pulumi.getter(name="resourceAttributes")
    def resource_attributes(self) -> Optional[pulumi.Input['ResourceAttributesArgs']]:
        """
        ResourceAuthorizationAttributes describes information for a resource access request
        """
        return pulumi.get(self, "resource_attributes")

    @resource_attributes.setter
    def resource_attributes(self, value: Optional[pulumi.Input['ResourceAttributesArgs']]):
        pulumi.set(self, "resource_attributes", value)


@pulumi.input_type
class SelfSubjectRulesReviewSpecArgs:
    def __init__(__self__, *,
                 namespace: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] namespace: Namespace to evaluate rules for. Required.
        """
        if namespace is not None:
            pulumi.set(__self__, "namespace", namespace)

    @property
    @pulumi.getter
    def namespace(self) -> Optional[pulumi.Input[str]]:
        """
        Namespace to evaluate rules for. Required.
        """
        return pulumi.get(self, "namespace")

    @namespace.setter
    def namespace(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace", value)


@pulumi.input_type
class SubjectAccessReviewSpecArgs:
    def __init__(__self__, *,
                 extra: Optional[pulumi.Input[Mapping[str, pulumi.Input[Sequence[pulumi.Input[str]]]]]] = None,
                 group: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 non_resource_attributes: Optional[pulumi.Input['NonResourceAttributesArgs']] = None,
                 resource_attributes: Optional[pulumi.Input['ResourceAttributesArgs']] = None,
                 uid: Optional[pulumi.Input[str]] = None,
                 user: Optional[pulumi.Input[str]] = None):
        """
        SubjectAccessReviewSpec is a description of the access request.  Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
        :param pulumi.Input[Mapping[str, pulumi.Input[Sequence[pulumi.Input[str]]]]] extra: Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] group: Groups is the groups you're testing for.
        :param pulumi.Input['NonResourceAttributesArgs'] non_resource_attributes: NonResourceAttributes describes information for a non-resource access request
        :param pulumi.Input['ResourceAttributesArgs'] resource_attributes: ResourceAuthorizationAttributes describes information for a resource access request
        :param pulumi.Input[str] uid: UID information about the requesting user.
        :param pulumi.Input[str] user: User is the user you're testing for. If you specify "User" but not "Group", then is it interpreted as "What if User were not a member of any groups
        """
        if extra is not None:
            pulumi.set(__self__, "extra", extra)
        if group is not None:
            pulumi.set(__self__, "group", group)
        if non_resource_attributes is not None:
            pulumi.set(__self__, "non_resource_attributes", non_resource_attributes)
        if resource_attributes is not None:
            pulumi.set(__self__, "resource_attributes", resource_attributes)
        if uid is not None:
            pulumi.set(__self__, "uid", uid)
        if user is not None:
            pulumi.set(__self__, "user", user)

    @property
    @pulumi.getter
    def extra(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[Sequence[pulumi.Input[str]]]]]]:
        """
        Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.
        """
        return pulumi.get(self, "extra")

    @extra.setter
    def extra(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[Sequence[pulumi.Input[str]]]]]]):
        pulumi.set(self, "extra", value)

    @property
    @pulumi.getter
    def group(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Groups is the groups you're testing for.
        """
        return pulumi.get(self, "group")

    @group.setter
    def group(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "group", value)

    @property
    @pulumi.getter(name="nonResourceAttributes")
    def non_resource_attributes(self) -> Optional[pulumi.Input['NonResourceAttributesArgs']]:
        """
        NonResourceAttributes describes information for a non-resource access request
        """
        return pulumi.get(self, "non_resource_attributes")

    @non_resource_attributes.setter
    def non_resource_attributes(self, value: Optional[pulumi.Input['NonResourceAttributesArgs']]):
        pulumi.set(self, "non_resource_attributes", value)

    @property
    @pulumi.getter(name="resourceAttributes")
    def resource_attributes(self) -> Optional[pulumi.Input['ResourceAttributesArgs']]:
        """
        ResourceAuthorizationAttributes describes information for a resource access request
        """
        return pulumi.get(self, "resource_attributes")

    @resource_attributes.setter
    def resource_attributes(self, value: Optional[pulumi.Input['ResourceAttributesArgs']]):
        pulumi.set(self, "resource_attributes", value)

    @property
    @pulumi.getter
    def uid(self) -> Optional[pulumi.Input[str]]:
        """
        UID information about the requesting user.
        """
        return pulumi.get(self, "uid")

    @uid.setter
    def uid(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "uid", value)

    @property
    @pulumi.getter
    def user(self) -> Optional[pulumi.Input[str]]:
        """
        User is the user you're testing for. If you specify "User" but not "Group", then is it interpreted as "What if User were not a member of any groups
        """
        return pulumi.get(self, "user")

    @user.setter
    def user(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user", value)


