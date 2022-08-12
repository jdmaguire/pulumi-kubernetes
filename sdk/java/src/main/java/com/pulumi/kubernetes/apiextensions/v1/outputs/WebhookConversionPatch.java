// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.kubernetes.apiextensions.v1.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.kubernetes.apiextensions.v1.outputs.WebhookClientConfigPatch;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class WebhookConversionPatch {
    /**
     * @return clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.
     * 
     */
    private @Nullable WebhookClientConfigPatch clientConfig;
    /**
     * @return conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
     * 
     */
    private @Nullable List<String> conversionReviewVersions;

    private WebhookConversionPatch() {}
    /**
     * @return clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.
     * 
     */
    public Optional<WebhookClientConfigPatch> clientConfig() {
        return Optional.ofNullable(this.clientConfig);
    }
    /**
     * @return conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects. The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
     * 
     */
    public List<String> conversionReviewVersions() {
        return this.conversionReviewVersions == null ? List.of() : this.conversionReviewVersions;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(WebhookConversionPatch defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private @Nullable WebhookClientConfigPatch clientConfig;
        private @Nullable List<String> conversionReviewVersions;
        public Builder() {}
        public Builder(WebhookConversionPatch defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.clientConfig = defaults.clientConfig;
    	      this.conversionReviewVersions = defaults.conversionReviewVersions;
        }

        @CustomType.Setter
        public Builder clientConfig(@Nullable WebhookClientConfigPatch clientConfig) {
            this.clientConfig = clientConfig;
            return this;
        }
        @CustomType.Setter
        public Builder conversionReviewVersions(@Nullable List<String> conversionReviewVersions) {
            this.conversionReviewVersions = conversionReviewVersions;
            return this;
        }
        public Builder conversionReviewVersions(String... conversionReviewVersions) {
            return conversionReviewVersions(List.of(conversionReviewVersions));
        }
        public WebhookConversionPatch build() {
            final var o = new WebhookConversionPatch();
            o.clientConfig = clientConfig;
            o.conversionReviewVersions = conversionReviewVersions;
            return o;
        }
    }
}