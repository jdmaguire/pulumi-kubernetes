// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Authentication.V1
{

    /// <summary>
    /// TokenRequestSpec contains client provided parameters of a token request.
    /// </summary>
    public class TokenRequestSpecPatchArgs : global::Pulumi.ResourceArgs
    {
        [Input("audiences")]
        private InputList<string>? _audiences;

        /// <summary>
        /// Audiences are the intendend audiences of the token. A recipient of a token must identitfy themself with an identifier in the list of audiences of the token, and otherwise should reject the token. A token issued for multiple audiences may be used to authenticate against any of the audiences listed but implies a high degree of trust between the target audiences.
        /// </summary>
        public InputList<string> Audiences
        {
            get => _audiences ?? (_audiences = new InputList<string>());
            set => _audiences = value;
        }

        /// <summary>
        /// BoundObjectRef is a reference to an object that the token will be bound to. The token will only be valid for as long as the bound object exists. NOTE: The API server's TokenReview endpoint will validate the BoundObjectRef, but other audiences may not. Keep ExpirationSeconds small if you want prompt revocation.
        /// </summary>
        [Input("boundObjectRef")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Authentication.V1.BoundObjectReferencePatchArgs>? BoundObjectRef { get; set; }

        /// <summary>
        /// ExpirationSeconds is the requested duration of validity of the request. The token issuer may return a token with a different validity duration so a client needs to check the 'expiration' field in a response.
        /// </summary>
        [Input("expirationSeconds")]
        public Input<int>? ExpirationSeconds { get; set; }

        public TokenRequestSpecPatchArgs()
        {
        }
        public static new TokenRequestSpecPatchArgs Empty => new TokenRequestSpecPatchArgs();
    }
}