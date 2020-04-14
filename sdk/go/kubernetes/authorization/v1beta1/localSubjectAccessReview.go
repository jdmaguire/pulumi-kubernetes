// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"reflect"

	"github.com/pkg/errors"
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// LocalSubjectAccessReview checks whether or not a user or group can perform an action in a given namespace. Having a namespace scoped resource makes it much easier to grant namespace scoped policy that includes permissions checking.
type LocalSubjectAccessReview struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
	Spec SubjectAccessReviewSpecPtrOutput `pulumi:"spec"`
	// Status is filled in by the server and indicates whether the request is allowed or not
	Status SubjectAccessReviewStatusPtrOutput `pulumi:"status"`
}

// NewLocalSubjectAccessReview registers a new resource with the given unique name, arguments, and options.
func NewLocalSubjectAccessReview(ctx *pulumi.Context,
	name string, args *LocalSubjectAccessReviewArgs, opts ...pulumi.ResourceOption) (*LocalSubjectAccessReview, error) {
	if args == nil || args.Spec == nil {
		return nil, errors.New("missing required argument 'Spec'")
	}
	if args == nil {
		args = &LocalSubjectAccessReviewArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("authorization.k8s.io/v1beta1")
	args.Kind = pulumi.StringPtr("LocalSubjectAccessReview")
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("kubernetes:authorization.k8s.io/v1:LocalSubjectAccessReview"),
		},
	})
	opts = append(opts, aliases)
	var resource LocalSubjectAccessReview
	err := ctx.RegisterResource("kubernetes:authorization.k8s.io/v1beta1:LocalSubjectAccessReview", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLocalSubjectAccessReview gets an existing LocalSubjectAccessReview resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLocalSubjectAccessReview(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LocalSubjectAccessReviewState, opts ...pulumi.ResourceOption) (*LocalSubjectAccessReview, error) {
	var resource LocalSubjectAccessReview
	err := ctx.ReadResource("kubernetes:authorization.k8s.io/v1beta1:LocalSubjectAccessReview", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LocalSubjectAccessReview resources.
type localSubjectAccessReviewState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
	Spec *SubjectAccessReviewSpec `pulumi:"spec"`
	// Status is filled in by the server and indicates whether the request is allowed or not
	Status *SubjectAccessReviewStatus `pulumi:"status"`
}

type LocalSubjectAccessReviewState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
	Spec SubjectAccessReviewSpecPtrInput
	// Status is filled in by the server and indicates whether the request is allowed or not
	Status SubjectAccessReviewStatusPtrInput
}

func (LocalSubjectAccessReviewState) ElementType() reflect.Type {
	return reflect.TypeOf((*localSubjectAccessReviewState)(nil)).Elem()
}

type localSubjectAccessReviewArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
	Spec SubjectAccessReviewSpec `pulumi:"spec"`
}

// The set of arguments for constructing a LocalSubjectAccessReview resource.
type LocalSubjectAccessReviewArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// Spec holds information about the request being evaluated.  spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
	Spec SubjectAccessReviewSpecInput
}

func (LocalSubjectAccessReviewArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*localSubjectAccessReviewArgs)(nil)).Elem()
}
