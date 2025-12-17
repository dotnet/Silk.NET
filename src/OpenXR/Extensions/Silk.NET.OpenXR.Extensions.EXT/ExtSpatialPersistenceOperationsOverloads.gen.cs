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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtSpatialPersistenceOperationsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityPersistInfoEXT* persistInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialEntityAsync(persistenceContext, persistInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityPersistInfoEXT> persistInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialEntityAsync(persistenceContext, in persistInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityPersistInfoEXT> persistInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PersistSpatialEntityAsync(persistenceContext, in persistInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialEntityComplete(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<PersistSpatialEntityCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.PersistSpatialEntityComplete(persistenceContext, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityUnpersistInfoEXT* unpersistInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialEntityAsync(persistenceContext, unpersistInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityUnpersistInfoEXT> unpersistInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialEntityAsync(persistenceContext, in unpersistInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialEntityAsync(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityUnpersistInfoEXT> unpersistInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialEntityAsync(persistenceContext, in unpersistInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialEntityComplete(this ExtSpatialPersistenceOperations thisApi, [Count(Count = 0)] SpatialPersistenceContextEXT persistenceContext, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<UnpersistSpatialEntityCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialEntityComplete(persistenceContext, future, ref completion.GetPinnableReference());
        }

    }
}

