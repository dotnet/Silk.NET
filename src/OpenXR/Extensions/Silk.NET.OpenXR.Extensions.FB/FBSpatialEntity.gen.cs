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

namespace Silk.NET.OpenXR.Extensions.FB
{
    [Extension("XR_FB_spatial_entity")]
    public unsafe partial class FBSpatialEntity : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_spatial_entity";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSpatialAnchorFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateSpatialAnchorFB", Convention = CallingConvention.Winapi)]
        public partial Result CreateSpatialAnchorFB([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpatialAnchorCreateInfoFB info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpaceSupportedComponentsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpaceComponentTypeFB* componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpaceSupportedComponentsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] ref SpaceComponentTypeFB componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpaceSupportedComponentsFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpaceComponentTypeFB* componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateSpaceSupportedComponentsFB", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] ref SpaceComponentTypeFB componentTypes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0)] SpaceComponentTypeFB componentType, [Count(Count = 0)] SpaceComponentStatusFB* status);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0)] SpaceComponentTypeFB componentType, [Count(Count = 0)] ref SpaceComponentStatusFB status);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceUuidFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSpaceUuidFB([Count(Count = 0)] Space space, [Count(Count = 0)] UuidEXT* uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSpaceUuidFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSpaceUuidFB([Count(Count = 0)] Space space, [Count(Count = 0)] ref UuidEXT uuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceComponentStatusSetInfoFB* info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceComponentStatusSetInfoFB* info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceComponentStatusSetInfoFB info, [Count(Count = 0)] ulong* requestId);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetSpaceComponentStatusFB", Convention = CallingConvention.Winapi)]
        public partial Result SetSpaceComponentStatusFB([Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SpaceComponentStatusSetInfoFB info, [Count(Count = 0)] ref ulong requestId);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpaceComponentTypeFB> componentTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpaceSupportedComponentsFB(space, (uint) componentTypes.Length, componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateSpaceSupportedComponentsFB([Count(Count = 0)] Space space, [Count(Count = 0)] ref uint componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpaceComponentTypeFB> componentTypes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateSpaceSupportedComponentsFB(space, (uint) componentTypes.Length, ref componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        public FBSpatialEntity(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

