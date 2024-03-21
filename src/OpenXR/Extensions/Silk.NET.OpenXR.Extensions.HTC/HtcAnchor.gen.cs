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

namespace Silk.NET.OpenXR.Extensions.HTC
{
    [Extension("XR_HTC_anchor")]
    public unsafe partial class HtcAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_HTC_anchor";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoHTC* createInfo, [Count(Count = 0)] Space* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoHTC* createInfo, [Count(Count = 0)] ref Space anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoHTC createInfo, [Count(Count = 0)] Space* anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorHTC", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorHtc([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoHTC createInfo, [Count(Count = 0)] ref Space anchor);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialAnchorNameHTC", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialAnchorNameHtc([Count(Count = 0)] Space anchor, [Count(Count = 0)] SpatialAnchorNameHTC* name);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialAnchorNameHTC", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialAnchorNameHtc([Count(Count = 0)] Space anchor, [Count(Count = 0)] ref SpatialAnchorNameHTC name);

        public HtcAnchor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

