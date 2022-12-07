// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Helm.V3
{
    /// <summary>
    /// A `Release` is an instance of a chart running in a Kubernetes cluster. A `Chart` is a Helm package. It contains all the
    /// resource definitions necessary to run an application, tool, or service inside a Kubernetes cluster.
    /// 
    /// This resource models a Helm Release as if it were created by the Helm CLI. The underlying implementation embeds Helm as
    /// a library to perform the orchestration of the resources. As a result, the full spectrum of Helm features are supported
    /// natively.
    /// 
    /// ## Example Usage
    /// ### Local Chart Directory
    /// ```csharp
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var nginx = new Release("nginx-ingress", new ReleaseArgs
    ///         {
    ///             Chart = "./nginx-ingress",
    ///         });
    /// 
    ///     }
    /// }
    /// ```
    /// ### Remote Chart
    /// ```csharp
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var nginx = new Release("nginx-ingress", new ReleaseArgs
    ///         {
    ///             Chart = "nginx-ingress",
    ///             Version = "1.24.4",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://charts.helm.sh/stable"
    ///             }
    ///         });
    /// 
    ///     }
    /// }
    /// ```
    /// ### Set Chart Values
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var values = new Dictionary&lt;string, object&gt;
    ///         {
    ///             ["controller"] = new Dictionary&lt;string, object&gt;
    ///             {
    ///                 ["metrics"] = new Dictionary&lt;string, object&gt;
    ///                 {
    ///                     ["enabled"] = true
    ///                 }
    ///             },
    ///         };
    /// 
    ///         var nginx = new Release("nginx-ingress", new ReleaseArgs
    ///         {
    ///             Chart = "nginx-ingress",
    ///             Version = "1.24.4",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://charts.helm.sh/stable"
    ///             },
    ///             Values = values,
    ///         });
    /// 
    ///     }
    /// }
    /// ```
    /// ### Deploy Chart into Namespace
    /// ```csharp
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var nginx = new Release("nginx-ingress", new ReleaseArgs
    ///         {
    ///             Chart = "nginx-ingress",
    ///             Version = "1.24.4",
    ///             Namespace = "test-namespace",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://charts.helm.sh/stable"
    ///             },
    ///         });
    /// 
    ///     }
    /// }
    /// ```
    /// 
    /// ### Depend on a Chart resource
    /// ```csharp
    /// using System.Threading.Tasks;
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Core.V1;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var nginx = new Release("nginx-ingress", new ReleaseArgs
    ///         {
    ///             Chart = "nginx-ingress",
    ///             Version = "1.24.4",
    ///             Namespace = "test-namespace",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://charts.helm.sh/stable"
    ///             },
    ///             SkipAwait = false,
    ///         });
    /// 
    ///         // Create a ConfigMap depending on the Chart. The ConfigMap will not be created until after all of the Chart
    ///         // resources are ready. Notice SkipAwait is set to false above. This is the default and will cause Helm
    ///         // to await the underlying resources to be available. Setting it to true will make the ConfigMap available right away.
    ///         new ConfigMap("foo", new Pulumi.Kubernetes.Types.Inputs.Core.V1.ConfigMapArgs
    ///         {
    ///             Data = new InputMap&lt;string&gt;
    ///             {
    ///                 {"foo", "bar"}
    ///             },
    ///         }, new CustomResourceOptions
    ///         {
    ///             DependsOn = nginx,
    ///         });
    /// 
    ///     }
    /// }
    /// ```
    /// ### Specify Helm Chart Values in File and Code
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var nginx = new Release("redis", new ReleaseArgs
    ///         {
    ///             Chart = "redis",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://raw.githubusercontent.com/bitnami/charts/eb5f9a9513d987b519f0ecd732e7031241c50328/bitnami"
    ///             },
    ///             ValueYamlFiles = new FileAsset("./metrics.yml");
    ///             Values = new InputMap&lt;object&gt;
    ///             {
    ///                 ["cluster"] = new Dictionary&lt;string,object&gt;
    ///                 {
    ///                     ["enabled"] = true,
    ///                 },
    ///                 ["rbac"] = new Dictionary&lt;string,object&gt;
    ///                 {
    ///                     ["create"] = true,
    ///                 }
    ///             },
    ///         });
    ///     }
    /// }
    /// 
    /// // -- Contents of metrics.yml --
    /// // metrics:
    /// //     enabled: true
    /// ```
    /// ### Query Kubernetes Resource Installed By Helm Chart
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Pulumi.Kubernetes.Types.Inputs.Helm.V3;
    /// using Pulumi.Kubernetes.Helm.V3;
    /// 
    /// class HelmStack : Stack
    /// {
    ///     public HelmStack()
    ///     {
    ///         var redis = new Release("redis", new ReleaseArgs
    ///         {
    ///             Chart = "redis",
    ///             RepositoryOpts = new RepositoryOptsArgs
    ///             {
    ///                 Repo = "https://raw.githubusercontent.com/bitnami/charts/eb5f9a9513d987b519f0ecd732e7031241c50328/bitnami"
    ///             },
    ///             Values = new InputMap&lt;object&gt;
    ///             {
    ///                 ["cluster"] = new Dictionary&lt;string,object&gt;
    ///                 {
    ///                     ["enabled"] = true,
    ///                 },
    ///                 ["rbac"] = new Dictionary&lt;string,object&gt;
    ///                 {
    ///                     ["create"] = true,
    ///                 }
    ///             },
    ///         });
    /// 
    ///         var status = redis.Status;
    ///         // srv will only resolve after the redis chart is installed.
    ///         var srv = Service.Get("redist-master-svc", Output.All(status).Apply(
    ///             s =&gt; $"{s[0].Namespace}/{s[0].Name}-master"));
    ///         this.RedisMasterClusterIP = srv.Spec.Apply(spec =&gt; spec.ClusterIP);
    ///     }
    /// 
    ///     [Output]
    ///     public Output&lt;string&gt; RedisMasterClusterIP { get; set; }
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing Helm Release resource can be imported using its `type token`, `name` and identifier, e.g.
    /// 
    /// ```sh
    /// $ pulumi import kubernetes:helm.sh/v3:Release myRelease &lt;namespace&gt;/&lt;releaseName&gt;
    /// ```
    /// </summary>
    [KubernetesResourceType("kubernetes:helm.sh/v3:Release")]
    public partial class Release : KubernetesResource
    {
        /// <summary>
        /// Whether to allow Null values in helm chart configs.
        /// </summary>
        [Output("allowNullValues")]
        public Output<bool> AllowNullValues { get; private set; } = null!;

        /// <summary>
        /// If set, installation process purges chart on fail. `skipAwait` will be disabled automatically if atomic is used.
        /// </summary>
        [Output("atomic")]
        public Output<bool> Atomic { get; private set; } = null!;

        /// <summary>
        /// Chart name to be installed. A path may be used.
        /// </summary>
        [Output("chart")]
        public Output<string> Chart { get; private set; } = null!;

        /// <summary>
        /// Allow deletion of new resources created in this upgrade when upgrade fails.
        /// </summary>
        [Output("cleanupOnFail")]
        public Output<bool> CleanupOnFail { get; private set; } = null!;

        /// <summary>
        /// Create the namespace if it does not exist.
        /// </summary>
        [Output("createNamespace")]
        public Output<bool> CreateNamespace { get; private set; } = null!;

        /// <summary>
        /// Run helm dependency update before installing the chart.
        /// </summary>
        [Output("dependencyUpdate")]
        public Output<bool> DependencyUpdate { get; private set; } = null!;

        /// <summary>
        /// Add a custom description
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// Use chart development versions, too. Equivalent to version '&gt;0.0.0-0'. If `version` is set, this is ignored.
        /// </summary>
        [Output("devel")]
        public Output<bool> Devel { get; private set; } = null!;

        /// <summary>
        /// Prevent CRD hooks from running, but run other hooks.  See helm install --no-crd-hook
        /// </summary>
        [Output("disableCRDHooks")]
        public Output<bool> DisableCRDHooks { get; private set; } = null!;

        /// <summary>
        /// If set, the installation process will not validate rendered templates against the Kubernetes OpenAPI Schema
        /// </summary>
        [Output("disableOpenapiValidation")]
        public Output<bool> DisableOpenapiValidation { get; private set; } = null!;

        /// <summary>
        /// Prevent hooks from running.
        /// </summary>
        [Output("disableWebhooks")]
        public Output<bool> DisableWebhooks { get; private set; } = null!;

        /// <summary>
        /// Force resource update through delete/recreate if needed.
        /// </summary>
        [Output("forceUpdate")]
        public Output<bool> ForceUpdate { get; private set; } = null!;

        /// <summary>
        /// Location of public keys used for verification. Used only if `verify` is true
        /// </summary>
        [Output("keyring")]
        public Output<string> Keyring { get; private set; } = null!;

        /// <summary>
        /// Run helm lint when planning.
        /// </summary>
        [Output("lint")]
        public Output<bool> Lint { get; private set; } = null!;

        /// <summary>
        /// The rendered manifests as JSON. Not yet supported.
        /// </summary>
        [Output("manifest")]
        public Output<ImmutableDictionary<string, object>> Manifest { get; private set; } = null!;

        /// <summary>
        /// Limit the maximum number of revisions saved per release. Use 0 for no limit.
        /// </summary>
        [Output("maxHistory")]
        public Output<int> MaxHistory { get; private set; } = null!;

        /// <summary>
        /// Release name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Namespace to install the release into.
        /// </summary>
        [Output("namespace")]
        public Output<string> Namespace { get; private set; } = null!;

        /// <summary>
        /// Postrender command to run.
        /// </summary>
        [Output("postrender")]
        public Output<string> Postrender { get; private set; } = null!;

        /// <summary>
        /// Perform pods restart during upgrade/rollback.
        /// </summary>
        [Output("recreatePods")]
        public Output<bool> RecreatePods { get; private set; } = null!;

        /// <summary>
        /// If set, render subchart notes along with the parent.
        /// </summary>
        [Output("renderSubchartNotes")]
        public Output<bool> RenderSubchartNotes { get; private set; } = null!;

        /// <summary>
        /// Re-use the given name, even if that name is already used. This is unsafe in production
        /// </summary>
        [Output("replace")]
        public Output<bool> Replace { get; private set; } = null!;

        /// <summary>
        /// Specification defining the Helm chart repository to use.
        /// </summary>
        [Output("repositoryOpts")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Helm.V3.RepositoryOpts> RepositoryOpts { get; private set; } = null!;

        /// <summary>
        /// When upgrading, reset the values to the ones built into the chart.
        /// </summary>
        [Output("resetValues")]
        public Output<bool> ResetValues { get; private set; } = null!;

        /// <summary>
        /// Names of resources created by the release grouped by "kind/version".
        /// </summary>
        [Output("resourceNames")]
        public Output<ImmutableDictionary<string, ImmutableArray<string>>> ResourceNames { get; private set; } = null!;

        /// <summary>
        /// When upgrading, reuse the last release's values and merge in any overrides. If 'resetValues' is specified, this is ignored
        /// </summary>
        [Output("reuseValues")]
        public Output<bool> ReuseValues { get; private set; } = null!;

        /// <summary>
        /// By default, the provider waits until all resources are in a ready state before marking the release as successful. Setting this to true will skip such await logic.
        /// </summary>
        [Output("skipAwait")]
        public Output<bool> SkipAwait { get; private set; } = null!;

        /// <summary>
        /// If set, no CRDs will be installed. By default, CRDs are installed if not already present.
        /// </summary>
        [Output("skipCrds")]
        public Output<bool> SkipCrds { get; private set; } = null!;

        /// <summary>
        /// Status of the deployed release.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Helm.V3.ReleaseStatus> Status { get; private set; } = null!;

        /// <summary>
        /// Time in seconds to wait for any individual kubernetes operation.
        /// </summary>
        [Output("timeout")]
        public Output<int> Timeout { get; private set; } = null!;

        /// <summary>
        /// List of assets (raw yaml files). Content is read and merged with values (with values taking precedence).
        /// </summary>
        [Output("valueYamlFiles")]
        public Output<ImmutableArray<AssetOrArchive>> ValueYamlFiles { get; private set; } = null!;

        /// <summary>
        /// Custom values set for the release.
        /// </summary>
        [Output("values")]
        public Output<ImmutableDictionary<string, object>> Values { get; private set; } = null!;

        /// <summary>
        /// Verify the package before installing it.
        /// </summary>
        [Output("verify")]
        public Output<bool> Verify { get; private set; } = null!;

        /// <summary>
        /// Specify the exact chart version to install. If this is not specified, the latest version is installed.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;

        /// <summary>
        /// Will wait until all Jobs have been completed before marking the release as successful. This is ignored if `skipAwait` is enabled.
        /// </summary>
        [Output("waitForJobs")]
        public Output<bool> WaitForJobs { get; private set; } = null!;


        /// <summary>
        /// Create a Release resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Release(string name, Pulumi.Kubernetes.Types.Inputs.Helm.V3.ReleaseArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:helm.sh/v3:Release", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal Release(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:helm.sh/v3:Release", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private Release(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:helm.sh/v3:Release", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Helm.V3.ReleaseArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Helm.V3.ReleaseArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Helm.V3.ReleaseArgs();
            args.Compat = "true";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Release resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Release Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Release(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Helm.V3
{

    public class ReleaseArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow Null values in helm chart configs.
        /// </summary>
        [Input("allowNullValues")]
        public Input<bool>? AllowNullValues { get; set; }

        /// <summary>
        /// If set, installation process purges chart on fail. `skipAwait` will be disabled automatically if atomic is used.
        /// </summary>
        [Input("atomic")]
        public Input<bool>? Atomic { get; set; }

        /// <summary>
        /// Chart name to be installed. A path may be used.
        /// </summary>
        [Input("chart", required: true)]
        public Input<string> Chart { get; set; } = null!;

        /// <summary>
        /// Allow deletion of new resources created in this upgrade when upgrade fails.
        /// </summary>
        [Input("cleanupOnFail")]
        public Input<bool>? CleanupOnFail { get; set; }

        [Input("compat")]
        public Input<string>? Compat { get; set; }

        /// <summary>
        /// Create the namespace if it does not exist.
        /// </summary>
        [Input("createNamespace")]
        public Input<bool>? CreateNamespace { get; set; }

        /// <summary>
        /// Run helm dependency update before installing the chart.
        /// </summary>
        [Input("dependencyUpdate")]
        public Input<bool>? DependencyUpdate { get; set; }

        /// <summary>
        /// Add a custom description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Use chart development versions, too. Equivalent to version '&gt;0.0.0-0'. If `version` is set, this is ignored.
        /// </summary>
        [Input("devel")]
        public Input<bool>? Devel { get; set; }

        /// <summary>
        /// Prevent CRD hooks from running, but run other hooks.  See helm install --no-crd-hook
        /// </summary>
        [Input("disableCRDHooks")]
        public Input<bool>? DisableCRDHooks { get; set; }

        /// <summary>
        /// If set, the installation process will not validate rendered templates against the Kubernetes OpenAPI Schema
        /// </summary>
        [Input("disableOpenapiValidation")]
        public Input<bool>? DisableOpenapiValidation { get; set; }

        /// <summary>
        /// Prevent hooks from running.
        /// </summary>
        [Input("disableWebhooks")]
        public Input<bool>? DisableWebhooks { get; set; }

        /// <summary>
        /// Force resource update through delete/recreate if needed.
        /// </summary>
        [Input("forceUpdate")]
        public Input<bool>? ForceUpdate { get; set; }

        /// <summary>
        /// Location of public keys used for verification. Used only if `verify` is true
        /// </summary>
        [Input("keyring")]
        public Input<string>? Keyring { get; set; }

        /// <summary>
        /// Run helm lint when planning.
        /// </summary>
        [Input("lint")]
        public Input<bool>? Lint { get; set; }

        [Input("manifest")]
        private InputMap<object>? _manifest;

        /// <summary>
        /// The rendered manifests as JSON. Not yet supported.
        /// </summary>
        public InputMap<object> Manifest
        {
            get => _manifest ?? (_manifest = new InputMap<object>());
            set => _manifest = value;
        }

        /// <summary>
        /// Limit the maximum number of revisions saved per release. Use 0 for no limit.
        /// </summary>
        [Input("maxHistory")]
        public Input<int>? MaxHistory { get; set; }

        /// <summary>
        /// Release name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Namespace to install the release into.
        /// </summary>
        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        /// <summary>
        /// Postrender command to run.
        /// </summary>
        [Input("postrender")]
        public Input<string>? Postrender { get; set; }

        /// <summary>
        /// Perform pods restart during upgrade/rollback.
        /// </summary>
        [Input("recreatePods")]
        public Input<bool>? RecreatePods { get; set; }

        /// <summary>
        /// If set, render subchart notes along with the parent.
        /// </summary>
        [Input("renderSubchartNotes")]
        public Input<bool>? RenderSubchartNotes { get; set; }

        /// <summary>
        /// Re-use the given name, even if that name is already used. This is unsafe in production
        /// </summary>
        [Input("replace")]
        public Input<bool>? Replace { get; set; }

        /// <summary>
        /// Specification defining the Helm chart repository to use.
        /// </summary>
        [Input("repositoryOpts")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Helm.V3.RepositoryOptsArgs>? RepositoryOpts { get; set; }

        /// <summary>
        /// When upgrading, reset the values to the ones built into the chart.
        /// </summary>
        [Input("resetValues")]
        public Input<bool>? ResetValues { get; set; }

        [Input("resourceNames")]
        private InputMap<ImmutableArray<string>>? _resourceNames;

        /// <summary>
        /// Names of resources created by the release grouped by "kind/version".
        /// </summary>
        public InputMap<ImmutableArray<string>> ResourceNames
        {
            get => _resourceNames ?? (_resourceNames = new InputMap<ImmutableArray<string>>());
            set => _resourceNames = value;
        }

        /// <summary>
        /// When upgrading, reuse the last release's values and merge in any overrides. If 'resetValues' is specified, this is ignored
        /// </summary>
        [Input("reuseValues")]
        public Input<bool>? ReuseValues { get; set; }

        /// <summary>
        /// By default, the provider waits until all resources are in a ready state before marking the release as successful. Setting this to true will skip such await logic.
        /// </summary>
        [Input("skipAwait")]
        public Input<bool>? SkipAwait { get; set; }

        /// <summary>
        /// If set, no CRDs will be installed. By default, CRDs are installed if not already present.
        /// </summary>
        [Input("skipCrds")]
        public Input<bool>? SkipCrds { get; set; }

        /// <summary>
        /// Time in seconds to wait for any individual kubernetes operation.
        /// </summary>
        [Input("timeout")]
        public Input<int>? Timeout { get; set; }

        [Input("valueYamlFiles")]
        private InputList<AssetOrArchive>? _valueYamlFiles;

        /// <summary>
        /// List of assets (raw yaml files). Content is read and merged with values.
        /// </summary>
        public InputList<AssetOrArchive> ValueYamlFiles
        {
            get => _valueYamlFiles ?? (_valueYamlFiles = new InputList<AssetOrArchive>());
            set => _valueYamlFiles = value;
        }

        [Input("values")]
        private InputMap<object>? _values;

        /// <summary>
        /// Custom values set for the release.
        /// </summary>
        public InputMap<object> Values
        {
            get => _values ?? (_values = new InputMap<object>());
            set => _values = value;
        }

        /// <summary>
        /// Verify the package before installing it.
        /// </summary>
        [Input("verify")]
        public Input<bool>? Verify { get; set; }

        /// <summary>
        /// Specify the exact chart version to install. If this is not specified, the latest version is installed.
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        /// <summary>
        /// Will wait until all Jobs have been completed before marking the release as successful. This is ignored if `skipAwait` is enabled.
        /// </summary>
        [Input("waitForJobs")]
        public Input<bool>? WaitForJobs { get; set; }

        public ReleaseArgs()
        {
        }
        public static new ReleaseArgs Empty => new ReleaseArgs();
    }
}
