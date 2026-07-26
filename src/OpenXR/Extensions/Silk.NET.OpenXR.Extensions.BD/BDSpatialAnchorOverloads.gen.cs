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
    public static class BDSpatialAnchorOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorCompleteBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SpatialAnchorCreateCompletionBD> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorPersistInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialAnchorAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorPersistInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorPersistInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialAnchorCompleteBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.PersistSpatialAnchorCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorUnpersistInfoBD* info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialAnchorAsyncBD(provider, info, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorUnpersistInfoBD> info, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialAnchorAsyncBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorUnpersistInfoBD> info, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialAnchorAsyncBD(provider, in info.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialAnchorCompleteBD(this BDSpatialAnchor thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialAnchorCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

    }
}

