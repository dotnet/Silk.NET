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

namespace Silk.NET.OpenXR.Extensions.ML
{
    public static class MLSpatialAnchorsStorageOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsStorageML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateStorageInfoML* createInfo, [Count(Count = 0)] Span<SpatialAnchorsStorageML> storage)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsStorageML(session, createInfo, ref storage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsStorageML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsCreateStorageInfoML> createInfo, [Count(Count = 0)] SpatialAnchorsStorageML* storage)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsStorageML(session, in createInfo.GetPinnableReference(), storage);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsStorageML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsCreateStorageInfoML> createInfo, [Count(Count = 0)] Span<SpatialAnchorsStorageML> storage)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsStorageML(session, in createInfo.GetPinnableReference(), ref storage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DeleteSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsDeleteInfoML* deleteInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.DeleteSpatialAnchorsAsyncML(storage, deleteInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DeleteSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsDeleteInfoML> deleteInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.DeleteSpatialAnchorsAsyncML(storage, in deleteInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DeleteSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsDeleteInfoML> deleteInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.DeleteSpatialAnchorsAsyncML(storage, in deleteInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result DeleteSpatialAnchorsCompleteML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SpatialAnchorsDeleteCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.DeleteSpatialAnchorsCompleteML(storage, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PublishSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsPublishInfoML* publishInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PublishSpatialAnchorsAsyncML(storage, publishInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PublishSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsPublishInfoML> publishInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.PublishSpatialAnchorsAsyncML(storage, in publishInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PublishSpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsPublishInfoML> publishInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.PublishSpatialAnchorsAsyncML(storage, in publishInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PublishSpatialAnchorsCompleteML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SpatialAnchorsPublishCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.PublishSpatialAnchorsCompleteML(storage, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.QuerySpatialAnchorsAsyncML(storage, queryInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsQueryInfoBaseHeaderML> queryInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.QuerySpatialAnchorsAsyncML(storage, in queryInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialAnchorsAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsQueryInfoBaseHeaderML> queryInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.QuerySpatialAnchorsAsyncML(storage, in queryInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySpatialAnchorsCompleteML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SpatialAnchorsQueryCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.QuerySpatialAnchorsCompleteML(storage, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateSpatialAnchorsExpirationAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsUpdateExpirationInfoML* updateInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UpdateSpatialAnchorsExpirationAsyncML(storage, updateInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateSpatialAnchorsExpirationAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsUpdateExpirationInfoML> updateInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.UpdateSpatialAnchorsExpirationAsyncML(storage, in updateInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateSpatialAnchorsExpirationAsyncML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsUpdateExpirationInfoML> updateInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.UpdateSpatialAnchorsExpirationAsyncML(storage, in updateInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UpdateSpatialAnchorsExpirationCompleteML(this MLSpatialAnchorsStorage thisApi, [Count(Count = 0)] SpatialAnchorsStorageML storage, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SpatialAnchorsUpdateExpirationCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.UpdateSpatialAnchorsExpirationCompleteML(storage, future, ref completion.GetPinnableReference());
        }

    }
}

