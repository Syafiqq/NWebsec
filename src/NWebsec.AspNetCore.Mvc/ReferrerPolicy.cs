// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

namespace NWebsec.AspNetCore.Mvc
{

    public enum ReferrerPolicy
    {
        /// <summary>Specifies that the Referrer-Policy header should not be set in the HTTP response.</summary>
        Disabled,
        /// <summary>
        /// Enables the no-referrer policy, instructing the browser to not send referrer information.
        /// </summary>
        NoReferrer,
        /// <summary>
        /// Enables the no-referrer-when-downgrade policy, instructing the browser to send full referrer
        /// information unless navigation is from HTTPS->HTTP.
        /// </summary>
        NoReferrerWhenDowngrade,
        /// <summary>
        /// Enables the same-origin policy, instructing the browser to send full referrer information for
        /// same-origin requests and no referrer for cross-origin requests.
        /// </summary>
        SameOrigin,
        /// <summary>
        /// Enables the origin policy, instructing the browser to send origin (no path and query) as
        /// referrer information for both same-origin and cross-origin requests.
        /// </summary>
        Origin,
        /// <summary>
        /// Enables the strict-origin policy, instructing the browser to send origin (no path and query) as
        /// referrer information for both same-origin and cross-origin HTTPS -> HTTPS and HTTP -> HTTP requests.
        /// HTTPS -> HTTP requests will not include referrer information.
        /// </summary>
        StrictOrigin,
        /// <summary>
        /// Enables the origin-when-cross-origin policy, instructing the browser to send full referrer information for
        /// same-origin requests and origin (no path and query) as referrer information for cross-origin requests (includes HTTPS -> HTTP and HTTP -> HTTPS).
        /// </summary>
        OriginWhenCrossOrigin,
        /// <summary>
        /// Enables the strict-origin-when-cross-origin policy, instructing the browser to send full referrer information for
        /// same-origin requests and origin (no path and query) as referrer information for cross-origin requests. Referrer information
        /// is not sent for HTTPS -> HTTP requests.
        /// </summary>
        StrictOriginWhenCrossOrigin,
        /// <summary>
        /// Enables the unsafe-url policy, instructing the browser to send full referrer information for all requests.
        /// Note that this will leak full referrer information for HTTPS -> HTTP requests, which is even more unsafe than default browser behaviour.
        /// </summary>
        UnsafeUrl
    }
}