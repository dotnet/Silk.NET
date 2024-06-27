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
    [Extension("XR_MSFT_spatial_anchor")]
    public unsafe partial class MsftSpatialAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_anchor";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoMSFT createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoMSFT createInfo, [Count(Count = 0)] ref SpatialAnchorMSFT anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorSpaceMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialAnchorMSFT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialAnchorMsft([Count(Count = 0)] SpatialAnchorMSFT anchor);

        public MsftSpatialAnchor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

