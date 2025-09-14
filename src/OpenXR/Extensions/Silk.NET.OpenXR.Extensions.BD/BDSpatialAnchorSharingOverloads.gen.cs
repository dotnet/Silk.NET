// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.BD
{
    public static class BDSpatialAnchorSharingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result DownloadSharedSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SharedSpatialAnchorDownloadInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.DownloadSharedSpatialAnchorAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DownloadSharedSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedSpatialAnchorDownloadInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.DownloadSharedSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DownloadSharedSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SharedSpatialAnchorDownloadInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.DownloadSharedSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DownloadSharedSpatialAnchorCompleteBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.DownloadSharedSpatialAnchorCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorShareInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.ShareSpatialAnchorAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorShareInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.ShareSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareSpatialAnchorAsyncBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorShareInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.ShareSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareSpatialAnchorCompleteBD(this BDSpatialAnchorSharing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.ShareSpatialAnchorCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

    }
}

