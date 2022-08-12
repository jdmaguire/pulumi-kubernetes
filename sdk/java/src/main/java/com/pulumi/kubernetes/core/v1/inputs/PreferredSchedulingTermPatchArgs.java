// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.core.v1.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.kubernetes.core.v1.inputs.NodeSelectorTermPatchArgs;
import java.lang.Integer;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


/**
 * An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it&#39;s a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).
 * 
 */
public final class PreferredSchedulingTermPatchArgs extends com.pulumi.resources.ResourceArgs {

    public static final PreferredSchedulingTermPatchArgs Empty = new PreferredSchedulingTermPatchArgs();

    /**
     * A node selector term, associated with the corresponding weight.
     * 
     */
    @Import(name="preference")
    private @Nullable Output<NodeSelectorTermPatchArgs> preference;

    /**
     * @return A node selector term, associated with the corresponding weight.
     * 
     */
    public Optional<Output<NodeSelectorTermPatchArgs>> preference() {
        return Optional.ofNullable(this.preference);
    }

    /**
     * Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
     * 
     */
    @Import(name="weight")
    private @Nullable Output<Integer> weight;

    /**
     * @return Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
     * 
     */
    public Optional<Output<Integer>> weight() {
        return Optional.ofNullable(this.weight);
    }

    private PreferredSchedulingTermPatchArgs() {}

    private PreferredSchedulingTermPatchArgs(PreferredSchedulingTermPatchArgs $) {
        this.preference = $.preference;
        this.weight = $.weight;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(PreferredSchedulingTermPatchArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private PreferredSchedulingTermPatchArgs $;

        public Builder() {
            $ = new PreferredSchedulingTermPatchArgs();
        }

        public Builder(PreferredSchedulingTermPatchArgs defaults) {
            $ = new PreferredSchedulingTermPatchArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param preference A node selector term, associated with the corresponding weight.
         * 
         * @return builder
         * 
         */
        public Builder preference(@Nullable Output<NodeSelectorTermPatchArgs> preference) {
            $.preference = preference;
            return this;
        }

        /**
         * @param preference A node selector term, associated with the corresponding weight.
         * 
         * @return builder
         * 
         */
        public Builder preference(NodeSelectorTermPatchArgs preference) {
            return preference(Output.of(preference));
        }

        /**
         * @param weight Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
         * 
         * @return builder
         * 
         */
        public Builder weight(@Nullable Output<Integer> weight) {
            $.weight = weight;
            return this;
        }

        /**
         * @param weight Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.
         * 
         * @return builder
         * 
         */
        public Builder weight(Integer weight) {
            return weight(Output.of(weight));
        }

        public PreferredSchedulingTermPatchArgs build() {
            return $;
        }
    }

}