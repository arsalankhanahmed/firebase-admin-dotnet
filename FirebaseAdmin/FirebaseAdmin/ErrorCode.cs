// Copyright 2019, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace FirebaseAdmin
{
    /// <summary>
    /// Platform-wide error codes that can be raised by Admin SDK APIs.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// Client specified an invalid argument.
        /// </summary>
        InvalidArgument,

        /// <summary>
        /// Request can not be executed in the current system state, such as deleting a non-empty
        /// directory.
        /// </summary>
        FailedPrecondition,

        /// <summary>
        /// Client specified an invalid range.
        /// </summary>
        OutOfRange,

        /// <summary>
        /// Request not authenticated due to missing, invalid, or expired OAuth token.
        /// </summary>
        Unauthenticated,

        /// <summary>
        /// Client does not have sufficient permission. This can happen because the OAuth token
        /// does not have the right scopes, the client doesn't have permission, or the API has not
        /// been enabled for the client project.
        /// </summary>
        PermissionDenied,

        /// <summary>
        /// A specified resource is not found, or the request is rejected due to undisclosed
        /// reasons, such as whitelisting.
        /// </summary>
        NotFound,

        /// <summary>
        /// Concurrency conflict, such as read-modify-write conflict.
        /// </summary>
        Conflict,

        /// <summary>
        /// Concurrency conflict, such as read-modify-write conflict.
        /// </summary>
        Aborted,

        /// <summary>
        /// The resource that a client tried to create already exists.
        /// </summary>
        AlreadyExists,

        /// <summary>
        /// Either out of resource quota or reaching rate limiting.
        /// </summary>
        ResourceExhausted,

        /// <summary>
        /// Request cancelled by the client.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Unrecoverable data loss or data corruption.
        /// </summary>
        DataLoss,

        /// <summary>
        /// Unknown server error.
        /// </summary>
        Unknown,

        /// <summary>
        /// Internal server error.
        /// </summary>
        Internal,

        /// <summary>
        /// Service unavailable. Typically the server is down.
        /// </summary>
        Unavailable,

        /// <summary>
        /// Request deadline exceeded. This will happen only if the caller sets a deadline that is
        /// shorter than the method's default deadline (i.e. requested deadline is not enough for
        /// the server to process the request) and the request did not finish within the deadline.
        /// </summary>
        DeadlineExceeded,
    }
}
