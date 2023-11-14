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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftSpatialAnchorPersistenceOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPersistedNameMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, [Count(Count = 0)] Span<SpatialAnchorMSFT> spatialAnchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPersistedNameMsft(session, spatialAnchorCreateInfo, ref spatialAnchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPersistedNameMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorFromPersistedAnchorCreateInfoMSFT> spatialAnchorCreateInfo, [Count(Count = 0)] SpatialAnchorMSFT* spatialAnchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPersistedNameMsft(session, in spatialAnchorCreateInfo.GetPinnableReference(), spatialAnchor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPersistedNameMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorFromPersistedAnchorCreateInfoMSFT> spatialAnchorCreateInfo, [Count(Count = 0)] Span<SpatialAnchorMSFT> spatialAnchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPersistedNameMsft(session, in spatialAnchorCreateInfo.GetPinnableReference(), ref spatialAnchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorStoreConnectionMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<SpatialAnchorStoreConnectionMSFT> spatialAnchorStore)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorStoreConnectionMsft(session, ref spatialAnchorStore.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedSpatialAnchorNamesMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] uint* spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] Span<SpatialAnchorPersistenceNameMSFT> spatialAnchorNames)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedSpatialAnchorNamesMsft(spatialAnchorStore, spatialAnchorNameCapacityInput, spatialAnchorNameCountOutput, ref spatialAnchorNames.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedSpatialAnchorNamesMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] Span<uint> spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] SpatialAnchorPersistenceNameMSFT* spatialAnchorNames)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedSpatialAnchorNamesMsft(spatialAnchorStore, spatialAnchorNameCapacityInput, ref spatialAnchorNameCountOutput.GetPinnableReference(), spatialAnchorNames);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumeratePersistedSpatialAnchorNamesMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] Span<uint> spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] Span<SpatialAnchorPersistenceNameMSFT> spatialAnchorNames)
        {
            // SpanOverloader
            return thisApi.EnumeratePersistedSpatialAnchorNamesMsft(spatialAnchorStore, spatialAnchorNameCapacityInput, ref spatialAnchorNameCountOutput.GetPinnableReference(), ref spatialAnchorNames.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PersistSpatialAnchorMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorPersistenceInfoMSFT> spatialAnchorPersistenceInfo)
        {
            // SpanOverloader
            return thisApi.PersistSpatialAnchorMsft(spatialAnchorStore, in spatialAnchorPersistenceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnpersistSpatialAnchorMsft(this MsftSpatialAnchorPersistence thisApi, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorPersistenceNameMSFT> spatialAnchorPersistenceName)
        {
            // SpanOverloader
            return thisApi.UnpersistSpatialAnchorMsft(spatialAnchorStore, in spatialAnchorPersistenceName.GetPinnableReference());
        }

    }
}

