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
    [Extension("XR_MSFT_spatial_graph_bridge")]
    public unsafe partial class MsftSpatialGraphBridge : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_MSFT_spatial_graph_bridge";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphNodeSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphNodeSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphNodeSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] Space* space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialGraphNodeSpaceMSFT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialGraphNodeSpaceMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphNodeSpaceCreateInfoMSFT createInfo, [Count(Count = 0)] ref Space space);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroySpatialGraphNodeBindingMSFT", Convention = CallingConvention.Winapi)]
        public partial Result DestroySpatialGraphNodeBindingMsft([Count(Count = 0)] SpatialGraphNodeBindingMSFT nodeBinding);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialGraphNodeBindingPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialGraphNodeBindingPropertiesMsft([Count(Count = 0)] SpatialGraphNodeBindingMSFT nodeBinding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, [Count(Count = 0)] SpatialGraphNodeBindingPropertiesMSFT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialGraphNodeBindingPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialGraphNodeBindingPropertiesMsft([Count(Count = 0)] SpatialGraphNodeBindingMSFT nodeBinding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphNodeBindingPropertiesGetInfoMSFT* getInfo, [Count(Count = 0)] ref SpatialGraphNodeBindingPropertiesMSFT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialGraphNodeBindingPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpatialGraphNodeBindingPropertiesMsft([Count(Count = 0)] SpatialGraphNodeBindingMSFT nodeBinding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphNodeBindingPropertiesGetInfoMSFT getInfo, [Count(Count = 0)] SpatialGraphNodeBindingPropertiesMSFT* properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpatialGraphNodeBindingPropertiesMSFT", Convention = CallingConvention.Winapi)]
        public partial Result GetSpatialGraphNodeBindingPropertiesMsft([Count(Count = 0)] SpatialGraphNodeBindingMSFT nodeBinding, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphNodeBindingPropertiesGetInfoMSFT getInfo, [Count(Count = 0)] ref SpatialGraphNodeBindingPropertiesMSFT properties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTryCreateSpatialGraphStaticNodeBindingMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TryCreateSpatialGraphStaticNodeBindingMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, [Count(Count = 0)] SpatialGraphNodeBindingMSFT* nodeBinding);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTryCreateSpatialGraphStaticNodeBindingMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TryCreateSpatialGraphStaticNodeBindingMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialGraphStaticNodeBindingCreateInfoMSFT* createInfo, [Count(Count = 0)] ref SpatialGraphNodeBindingMSFT nodeBinding);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTryCreateSpatialGraphStaticNodeBindingMSFT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TryCreateSpatialGraphStaticNodeBindingMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphStaticNodeBindingCreateInfoMSFT createInfo, [Count(Count = 0)] SpatialGraphNodeBindingMSFT* nodeBinding);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrTryCreateSpatialGraphStaticNodeBindingMSFT", Convention = CallingConvention.Winapi)]
        public partial Result TryCreateSpatialGraphStaticNodeBindingMsft([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialGraphStaticNodeBindingCreateInfoMSFT createInfo, [Count(Count = 0)] ref SpatialGraphNodeBindingMSFT nodeBinding);

        public MsftSpatialGraphBridge(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

