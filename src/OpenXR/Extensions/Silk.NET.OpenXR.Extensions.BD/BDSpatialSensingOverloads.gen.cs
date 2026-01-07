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
    public static class BDSpatialSensingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpaceBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoBD* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpaceBD(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpaceBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSpaceCreateInfoBD> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpaceBD(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpaceBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSpaceCreateInfoBD> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpaceBD(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSenseDataProviderBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderCreateInfoBD* createInfo, [Count(Count = 0)] Span<SenseDataProviderBD> provider)
        {
            // SpanOverloader
            return thisApi.CreateSenseDataProviderBD(session, createInfo, ref provider.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSenseDataProviderBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataProviderCreateInfoBD> createInfo, [Count(Count = 0)] SenseDataProviderBD* provider)
        {
            // SpanOverloader
            return thisApi.CreateSenseDataProviderBD(session, in createInfo.GetPinnableReference(), provider);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSenseDataProviderBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataProviderCreateInfoBD> createInfo, [Count(Count = 0)] Span<SenseDataProviderBD> provider)
        {
            // SpanOverloader
            return thisApi.CreateSenseDataProviderBD(session, in createInfo.GetPinnableReference(), ref provider.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityAnchorBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityAnchorCreateInfoBD* createInfo, [Count(Count = 0)] Span<AnchorBD> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityAnchorBD(provider, createInfo, ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityAnchorBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityAnchorCreateInfoBD> createInfo, [Count(Count = 0)] AnchorBD* anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityAnchorBD(provider, in createInfo.GetPinnableReference(), anchor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialEntityAnchorBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityAnchorCreateInfoBD> createInfo, [Count(Count = 0)] Span<AnchorBD> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialEntityAnchorBD(provider, in createInfo.GetPinnableReference(), ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialEntityComponentTypesBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpatialEntityComponentTypeBD> componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialEntityComponentTypesBD(snapshot, entityId, componentTypeCapacityInput, componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialEntityComponentTypesBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] Span<uint> componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpatialEntityComponentTypeBD* componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialEntityComponentTypesBD(snapshot, entityId, componentTypeCapacityInput, ref componentTypeCountOutput.GetPinnableReference(), componentTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpatialEntityComponentTypesBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] Span<uint> componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpatialEntityComponentTypeBD> componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpatialEntityComponentTypesBD(snapshot, entityId, componentTypeCapacityInput, ref componentTypeCountOutput.GetPinnableReference(), ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAnchorUuidBD(this BDSpatialSensing thisApi, [Count(Count = 0)] AnchorBD anchor, [Count(Count = 0)] Span<UuidEXT> uuid)
        {
            // SpanOverloader
            return thisApi.GetAnchorUuidBD(anchor, ref uuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetQueriedSenseDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] QueriedSenseDataGetInfoBD* getInfo, [Count(Count = 0)] Span<QueriedSenseDataBD> queriedSenseData)
        {
            // SpanOverloader
            return thisApi.GetQueriedSenseDataBD(snapshot, getInfo, ref queriedSenseData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetQueriedSenseDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] Span<QueriedSenseDataGetInfoBD> getInfo, [Count(Count = 0)] QueriedSenseDataBD* queriedSenseData)
        {
            // SpanOverloader
            return thisApi.GetQueriedSenseDataBD(snapshot, ref getInfo.GetPinnableReference(), queriedSenseData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetQueriedSenseDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] Span<QueriedSenseDataGetInfoBD> getInfo, [Count(Count = 0)] Span<QueriedSenseDataBD> queriedSenseData)
        {
            // SpanOverloader
            return thisApi.GetQueriedSenseDataBD(snapshot, ref getInfo.GetPinnableReference(), ref queriedSenseData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSenseDataProviderStateBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] Span<SenseDataProviderStateBD> state)
        {
            // SpanOverloader
            return thisApi.GetSenseDataProviderStateBD(provider, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialEntityComponentDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityComponentGetInfoBD* getInfo, [Count(Count = 0)] Span<SpatialEntityComponentDataBaseHeaderBD> componentData)
        {
            // SpanOverloader
            return thisApi.GetSpatialEntityComponentDataBD(snapshot, getInfo, ref componentData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialEntityComponentDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityComponentGetInfoBD> getInfo, [Count(Count = 0)] SpatialEntityComponentDataBaseHeaderBD* componentData)
        {
            // SpanOverloader
            return thisApi.GetSpatialEntityComponentDataBD(snapshot, in getInfo.GetPinnableReference(), componentData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialEntityComponentDataBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialEntityComponentGetInfoBD> getInfo, [Count(Count = 0)] Span<SpatialEntityComponentDataBaseHeaderBD> componentData)
        {
            // SpanOverloader
            return thisApi.GetSpatialEntityComponentDataBD(snapshot, in getInfo.GetPinnableReference(), ref componentData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialEntityUuidBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] Span<UuidEXT> uuid)
        {
            // SpanOverloader
            return thisApi.GetSpatialEntityUuidBD(snapshot, entityId, ref uuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySenseDataAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataQueryInfoBD* queryInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.QuerySenseDataAsyncBD(provider, queryInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySenseDataAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataQueryInfoBD> queryInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.QuerySenseDataAsyncBD(provider, in queryInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySenseDataAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataQueryInfoBD> queryInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.QuerySenseDataAsyncBD(provider, in queryInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySenseDataCompleteBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<SenseDataQueryCompletionBD> completion)
        {
            // SpanOverloader
            return thisApi.QuerySenseDataCompleteBD(provider, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StartSenseDataProviderAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderStartInfoBD* startInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.StartSenseDataProviderAsyncBD(provider, startInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StartSenseDataProviderAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataProviderStartInfoBD> startInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.StartSenseDataProviderAsyncBD(provider, in startInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StartSenseDataProviderAsyncBD(this BDSpatialSensing thisApi, [Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SenseDataProviderStartInfoBD> startInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.StartSenseDataProviderAsyncBD(provider, in startInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result StartSenseDataProviderCompleteBD(this BDSpatialSensing thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<FutureCompletionEXT> completion)
        {
            // SpanOverloader
            return thisApi.StartSenseDataProviderCompleteBD(session, future, ref completion.GetPinnableReference());
        }

    }
}

