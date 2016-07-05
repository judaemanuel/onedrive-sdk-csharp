// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.Graph;

    /// <summary>
    /// The type DriveRecentRequestBuilder.
    /// </summary>
    public partial class DriveRecentRequestBuilder : BaseGetMethodRequestBuilder<IDriveRecentRequest>, IDriveRecentRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DriveRecentRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DriveRecentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
            this.passParametersInQueryString = true;
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDriveRecentRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DriveRecentRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
