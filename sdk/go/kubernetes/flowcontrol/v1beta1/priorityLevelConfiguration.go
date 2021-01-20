// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v1beta1

import (
	"context"
	"reflect"

	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v2/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// PriorityLevelConfiguration represents the configuration of a priority level.
type PriorityLevelConfiguration struct {
	pulumi.CustomResourceState

	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrOutput `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ObjectMetaPtrOutput `pulumi:"metadata"`
	// `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Spec PriorityLevelConfigurationSpecPtrOutput `pulumi:"spec"`
	// `status` is the current status of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Status PriorityLevelConfigurationStatusPtrOutput `pulumi:"status"`
}

// NewPriorityLevelConfiguration registers a new resource with the given unique name, arguments, and options.
func NewPriorityLevelConfiguration(ctx *pulumi.Context,
	name string, args *PriorityLevelConfigurationArgs, opts ...pulumi.ResourceOption) (*PriorityLevelConfiguration, error) {
	if args == nil {
		args = &PriorityLevelConfigurationArgs{}
	}

	args.ApiVersion = pulumi.StringPtr("flowcontrol.apiserver.k8s.io/v1beta1")
	args.Kind = pulumi.StringPtr("PriorityLevelConfiguration")
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("kubernetes:flowcontrol.apiserver.k8s.io/v1alpha1:PriorityLevelConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource PriorityLevelConfiguration
	err := ctx.RegisterResource("kubernetes:flowcontrol.apiserver.k8s.io/v1beta1:PriorityLevelConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPriorityLevelConfiguration gets an existing PriorityLevelConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPriorityLevelConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PriorityLevelConfigurationState, opts ...pulumi.ResourceOption) (*PriorityLevelConfiguration, error) {
	var resource PriorityLevelConfiguration
	err := ctx.ReadResource("kubernetes:flowcontrol.apiserver.k8s.io/v1beta1:PriorityLevelConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PriorityLevelConfiguration resources.
type priorityLevelConfigurationState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Spec *PriorityLevelConfigurationSpec `pulumi:"spec"`
	// `status` is the current status of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Status *PriorityLevelConfigurationStatus `pulumi:"status"`
}

type PriorityLevelConfigurationState struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput
	// `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ObjectMetaPtrInput
	// `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Spec PriorityLevelConfigurationSpecPtrInput
	// `status` is the current status of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Status PriorityLevelConfigurationStatusPtrInput
}

func (PriorityLevelConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*priorityLevelConfigurationState)(nil)).Elem()
}

type priorityLevelConfigurationArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion *string `pulumi:"apiVersion"`
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind *string `pulumi:"kind"`
	// `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata *metav1.ObjectMeta `pulumi:"metadata"`
	// `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Spec *PriorityLevelConfigurationSpec `pulumi:"spec"`
}

// The set of arguments for constructing a PriorityLevelConfiguration resource.
type PriorityLevelConfigurationArgs struct {
	// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
	ApiVersion pulumi.StringPtrInput
	// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
	Kind pulumi.StringPtrInput
	// `metadata` is the standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
	Metadata metav1.ObjectMetaPtrInput
	// `spec` is the specification of the desired behavior of a "request-priority". More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
	Spec PriorityLevelConfigurationSpecPtrInput
}

func (PriorityLevelConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*priorityLevelConfigurationArgs)(nil)).Elem()
}

type PriorityLevelConfigurationInput interface {
	pulumi.Input

	ToPriorityLevelConfigurationOutput() PriorityLevelConfigurationOutput
	ToPriorityLevelConfigurationOutputWithContext(ctx context.Context) PriorityLevelConfigurationOutput
}

func (*PriorityLevelConfiguration) ElementType() reflect.Type {
	return reflect.TypeOf((*PriorityLevelConfiguration)(nil))
}

func (i *PriorityLevelConfiguration) ToPriorityLevelConfigurationOutput() PriorityLevelConfigurationOutput {
	return i.ToPriorityLevelConfigurationOutputWithContext(context.Background())
}

func (i *PriorityLevelConfiguration) ToPriorityLevelConfigurationOutputWithContext(ctx context.Context) PriorityLevelConfigurationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PriorityLevelConfigurationOutput)
}

type PriorityLevelConfigurationOutput struct {
	*pulumi.OutputState
}

func (PriorityLevelConfigurationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PriorityLevelConfiguration)(nil))
}

func (o PriorityLevelConfigurationOutput) ToPriorityLevelConfigurationOutput() PriorityLevelConfigurationOutput {
	return o
}

func (o PriorityLevelConfigurationOutput) ToPriorityLevelConfigurationOutputWithContext(ctx context.Context) PriorityLevelConfigurationOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(PriorityLevelConfigurationOutput{})
}