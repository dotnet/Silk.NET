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

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_spatial_anchors")]
    public unsafe partial class MLSpatialAnchors : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_spatial_anchors";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsAsyncML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateInfoBaseHeaderML* createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsAsyncML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateInfoBaseHeaderML* createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsAsyncML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsCreateInfoBaseHeaderML createInfo, [Count(Count = 0)] FutureEXT* future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsAsyncML", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorsAsyncML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorsCreateInfoBaseHeaderML createInfo, [Count(Count = 0)] ref FutureEXT future);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorsCompleteML([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] CreateSpatialAnchorsCompletionML* completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorsCompleteML", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorsCompleteML([Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] ref CreateSpatialAnchorsCompletionML completion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialAnchorStateML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialAnchorStateML([Count(Count = 0)] Space anchor, [Count(Count = 0)] SpatialAnchorStateML* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialAnchorStateML", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialAnchorStateML([Count(Count = 0)] Space anchor, [Count(Count = 0)] ref SpatialAnchorStateML state);

        public MLSpatialAnchors(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

