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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    [Extension("XR_MSFT_spatial_anchor_persistence")]
    public unsafe partial class MsftSpatialAnchorPersistence : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_anchor_persistence";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrClearSpatialAnchorStoreMSFT", Convention = CallingConvention.Winapi)]
        public partial Result ClearSpatialAnchorStoreMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPersistedNameMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFromPersistedNameMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, [Count(Count = 0)] SpatialAnchorMSFT* spatialAnchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPersistedNameMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFromPersistedNameMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorFromPersistedAnchorCreateInfoMSFT* spatialAnchorCreateInfo, [Count(Count = 0)] ref SpatialAnchorMSFT spatialAnchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPersistedNameMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFromPersistedNameMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorFromPersistedAnchorCreateInfoMSFT spatialAnchorCreateInfo, [Count(Count = 0)] SpatialAnchorMSFT* spatialAnchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFromPersistedNameMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorFromPersistedNameMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorFromPersistedAnchorCreateInfoMSFT spatialAnchorCreateInfo, [Count(Count = 0)] ref SpatialAnchorMSFT spatialAnchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorStoreConnectionMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorStoreConnectionMsft([Count(Count = 0)] Session session, [Count(Count = 0)] SpatialAnchorStoreConnectionMSFT* spatialAnchorStore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorStoreConnectionMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorStoreConnectionMsft([Count(Count = 0)] Session session, [Count(Count = 0)] ref SpatialAnchorStoreConnectionMSFT spatialAnchorStore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialAnchorStoreConnectionMSFT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialAnchorStoreConnectionMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedSpatialAnchorNamesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] uint* spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] SpatialAnchorPersistenceNameMSFT* spatialAnchorNames);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedSpatialAnchorNamesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] uint* spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] ref SpatialAnchorPersistenceNameMSFT spatialAnchorNames);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedSpatialAnchorNamesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] ref uint spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] SpatialAnchorPersistenceNameMSFT* spatialAnchorNames);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumeratePersistedSpatialAnchorNamesMSFT", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint spatialAnchorNameCapacityInput, [Count(Count = 0)] ref uint spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] ref SpatialAnchorPersistenceNameMSFT spatialAnchorNames);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PersistSpatialAnchorMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorPersistenceInfoMSFT* spatialAnchorPersistenceInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPersistSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public partial Result PersistSpatialAnchorMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorPersistenceInfoMSFT spatialAnchorPersistenceInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnpersistSpatialAnchorMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorPersistenceNameMSFT* spatialAnchorPersistenceName);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUnpersistSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public partial Result UnpersistSpatialAnchorMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorPersistenceNameMSFT spatialAnchorPersistenceName);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] uint* spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] Span<SpatialAnchorPersistenceNameMSFT> spatialAnchorNames)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePersistedSpatialAnchorNamesMsft(spatialAnchorStore, (uint) spatialAnchorNames.Length, spatialAnchorNameCountOutput, ref spatialAnchorNames.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumeratePersistedSpatialAnchorNamesMsft([Count(Count = 0)] SpatialAnchorStoreConnectionMSFT spatialAnchorStore, [Count(Count = 0)] ref uint spatialAnchorNameCountOutput, [Count(Parameter = "spatialAnchorNameCapacityInput")] Span<SpatialAnchorPersistenceNameMSFT> spatialAnchorNames)
        {
            // ImplicitCountSpanOverloader
            return EnumeratePersistedSpatialAnchorNamesMsft(spatialAnchorStore, (uint) spatialAnchorNames.Length, ref spatialAnchorNameCountOutput, ref spatialAnchorNames.GetPinnableReference());
        }

        public MsftSpatialAnchorPersistence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

