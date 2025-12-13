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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.BD
{
    [Extension("XR_BD_spatial_sensing")]
    public unsafe partial class BDSpatialSensing : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_spatial_sensing";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpaceBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoBD* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpaceBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoBD* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateAnchorSpaceBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSpaceCreateInfoBD createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateAnchorSpaceBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateAnchorSpaceBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AnchorSpaceCreateInfoBD createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSenseDataProviderBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderCreateInfoBD* createInfo, [Count(Count = 0)] SenseDataProviderBD* provider);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSenseDataProviderBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderCreateInfoBD* createInfo, [Count(Count = 0)] ref SenseDataProviderBD provider);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSenseDataProviderBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataProviderCreateInfoBD createInfo, [Count(Count = 0)] SenseDataProviderBD* provider);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateSenseDataProviderBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataProviderCreateInfoBD createInfo, [Count(Count = 0)] ref SenseDataProviderBD provider);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityAnchorBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityAnchorBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityAnchorCreateInfoBD* createInfo, [Count(Count = 0)] AnchorBD* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityAnchorBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityAnchorBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityAnchorCreateInfoBD* createInfo, [Count(Count = 0)] ref AnchorBD anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityAnchorBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialEntityAnchorBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityAnchorCreateInfoBD createInfo, [Count(Count = 0)] AnchorBD* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialEntityAnchorBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialEntityAnchorBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityAnchorCreateInfoBD createInfo, [Count(Count = 0)] ref AnchorBD anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyAnchorBD", Convention = CallingConvention.Winapi)]
        public partial Result DestroyAnchorBD([Count(Count = 0)] AnchorBD anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public partial Result DestroySenseDataProviderBD([Count(Count = 0)] SenseDataProviderBD provider);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySenseDataSnapshotBD", Convention = CallingConvention.Winapi)]
        public partial Result DestroySenseDataSnapshotBD([Count(Count = 0)] SenseDataSnapshotBD snapshot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialEntityComponentTypesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpatialEntityComponentTypeBD* componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialEntityComponentTypesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] ref SpatialEntityComponentTypeBD componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialEntityComponentTypesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpatialEntityComponentTypeBD* componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpatialEntityComponentTypesBD", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] ref SpatialEntityComponentTypeBD componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorUuidBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetAnchorUuidBD([Count(Count = 0)] AnchorBD anchor, [Count(Count = 0)] UuidEXT* uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetAnchorUuidBD", Convention = CallingConvention.Winapi)]
        public partial Result GetAnchorUuidBD([Count(Count = 0)] AnchorBD anchor, [Count(Count = 0)] ref UuidEXT uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetQueriedSenseDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetQueriedSenseDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] QueriedSenseDataGetInfoBD* getInfo, [Count(Count = 0)] QueriedSenseDataBD* queriedSenseData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetQueriedSenseDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetQueriedSenseDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] QueriedSenseDataGetInfoBD* getInfo, [Count(Count = 0)] ref QueriedSenseDataBD queriedSenseData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetQueriedSenseDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetQueriedSenseDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ref QueriedSenseDataGetInfoBD getInfo, [Count(Count = 0)] QueriedSenseDataBD* queriedSenseData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetQueriedSenseDataBD", Convention = CallingConvention.Winapi)]
        public partial Result GetQueriedSenseDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ref QueriedSenseDataGetInfoBD getInfo, [Count(Count = 0)] ref QueriedSenseDataBD queriedSenseData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSenseDataProviderStateBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSenseDataProviderStateBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] SenseDataProviderStateBD* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSenseDataProviderStateBD", Convention = CallingConvention.Winapi)]
        public partial Result GetSenseDataProviderStateBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] ref SenseDataProviderStateBD state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityComponentDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialEntityComponentDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityComponentGetInfoBD* getInfo, [Count(Count = 0)] SpatialEntityComponentDataBaseHeaderBD* componentData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityComponentDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialEntityComponentDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialEntityComponentGetInfoBD* getInfo, [Count(Count = 0)] ref SpatialEntityComponentDataBaseHeaderBD componentData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityComponentDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialEntityComponentDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityComponentGetInfoBD getInfo, [Count(Count = 0)] SpatialEntityComponentDataBaseHeaderBD* componentData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityComponentDataBD", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialEntityComponentDataBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialEntityComponentGetInfoBD getInfo, [Count(Count = 0)] ref SpatialEntityComponentDataBaseHeaderBD componentData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityUuidBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialEntityUuidBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] UuidEXT* uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialEntityUuidBD", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialEntityUuidBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] ref UuidEXT uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySenseDataAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataQueryInfoBD* queryInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySenseDataAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataQueryInfoBD* queryInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySenseDataAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataQueryInfoBD queryInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result QuerySenseDataAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataQueryInfoBD queryInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QuerySenseDataCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] SenseDataQueryCompletionBD* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQuerySenseDataCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result QuerySenseDataCompleteBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref SenseDataQueryCompletionBD completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StartSenseDataProviderAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderStartInfoBD* startInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StartSenseDataProviderAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SenseDataProviderStartInfoBD* startInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderAsyncBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StartSenseDataProviderAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataProviderStartInfoBD startInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderAsyncBD", Convention = CallingConvention.Winapi)]
        public partial Result StartSenseDataProviderAsyncBD([Count(Count = 0)] SenseDataProviderBD provider, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SenseDataProviderStartInfoBD startInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderCompleteBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result StartSenseDataProviderCompleteBD([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] FutureCompletionEXT* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStartSenseDataProviderCompleteBD", Convention = CallingConvention.Winapi)]
        public partial Result StartSenseDataProviderCompleteBD([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref FutureCompletionEXT completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrStopSenseDataProviderBD", Convention = CallingConvention.Winapi)]
        public partial Result StopSenseDataProviderBD([Count(Count = 0)] SenseDataProviderBD provider);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpatialEntityComponentTypeBD> componentTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialEntityComponentTypesBD(snapshot, entityId, (uint) componentTypes.Length, componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpatialEntityComponentTypesBD([Count(Count = 0)] SenseDataSnapshotBD snapshot, [Count(Count = 0)] ulong entityId, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpatialEntityComponentTypeBD> componentTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpatialEntityComponentTypesBD(snapshot, entityId, (uint) componentTypes.Length, ref componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        public BDSpatialSensing(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

