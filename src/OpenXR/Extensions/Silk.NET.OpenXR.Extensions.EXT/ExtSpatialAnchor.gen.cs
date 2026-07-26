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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_spatial_anchor")]
    public unsafe partial class ExtSpatialAnchor : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_spatial_anchor";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] ref SpatialEntityEXT anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] ref ulong anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] ref ulong anchorEntityId, [Count(Count = 0)] ref SpatialEntityEXT anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoEXT createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoEXT createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] ref SpatialEntityEXT anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoEXT createInfo, [Count(Count = 0)] ref ulong anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchor([Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SpatialAnchorCreateInfoEXT createInfo, [Count(Count = 0)] ref ulong anchorEntityId, [Count(Count = 0)] ref SpatialEntityEXT anchorEntity);

        public ExtSpatialAnchor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

