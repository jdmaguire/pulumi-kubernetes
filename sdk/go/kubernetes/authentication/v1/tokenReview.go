// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"reflect"

	"github.com/pkg/errors"
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// TokenReview attempts to authenticate a token to a known user. Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
type TokenReview struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrOutput     `pulumi:"kind"`
	Metadata metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// Spec holds information about the request being evaluated
	Spec TokenReviewSpecPtrOutput `pulumi:"spec"`
	// Status is filled in by the server and indicates whether the request can be authenticated.
	Status TokenReviewStatusPtrOutput `pulumi:"status"`
}

// NewTokenReview registers a new resource with the given unique name, arguments, and options.
func NewTokenReview(ctx *pulumi.Context,
	name string, args *TokenReviewArgs, opts ...pulumi.ResourceOption) (*TokenReview, error) {
	if args == nil || args.Spec == nil {
		return nil, errors.New("missing required argument 'Spec'")
	}
	if args == nil {
		args = &TokenReviewArgs{}
	}
	args.ApiVersion = pulumi.StringPtr("authentication.k8s.io/v1")
	args.Kind = pulumi.StringPtr("TokenReview")
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("kubernetes:authentication.k8s.io/v1beta1:TokenReview"),
		},
	})
	opts = append(opts, aliases)
	var resource TokenReview
	err := ctx.RegisterResource("kubernetes:authentication.k8s.io/v1:TokenReview", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTokenReview gets an existing TokenReview resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTokenReview(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TokenReviewState, opts ...pulumi.ResourceOption) (*TokenReview, error) {
	var resource TokenReview
	err := ctx.ReadResource("kubernetes:authentication.k8s.io/v1:TokenReview", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TokenReview resources.
type tokenReviewState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Spec holds information about the request being evaluated
	Spec *TokenReviewSpec `pulumi:"spec"`
	// Status is filled in by the server and indicates whether the request can be authenticated.
	Status *TokenReviewStatus `pulumi:"status"`
}

type TokenReviewState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// Spec holds information about the request being evaluated
	Spec TokenReviewSpecPtrInput
	// Status is filled in by the server and indicates whether the request can be authenticated.
	Status TokenReviewStatusPtrInput
}

func (TokenReviewState) ElementType() reflect.Type {
	return reflect.TypeOf((*tokenReviewState)(nil)).Elem()
}

type tokenReviewArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     *string            `pulumi:"kind"`
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// Spec holds information about the request being evaluated
	Spec TokenReviewSpec `pulumi:"spec"`
}

// The set of arguments for constructing a TokenReview resource.
type TokenReviewArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind     pulumi.StringPtrInput
	Metadata metav1.ObjectMetaPtrInput
	// Spec holds information about the request being evaluated
	Spec TokenReviewSpecInput
}

func (TokenReviewArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tokenReviewArgs)(nil)).Elem()
}
