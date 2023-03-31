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

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBSpatialEntityOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoFB* info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFB(session, info, ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoFB> info, [Count(Count = 0)] ulong* requestId)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFB(session, in info.GetPinnableReference(), requestId);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoFB> info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFB(session, in info.GetPinnableReference(), ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpaceSupportedComponentsFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] uint* componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpaceComponentTypeFB> componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpaceSupportedComponentsFB(space, componentTypeCapacityInput, componentTypeCountOutput, ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpaceSupportedComponentsFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] Span<uint> componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] SpaceComponentTypeFB* componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpaceSupportedComponentsFB(space, componentTypeCapacityInput, ref componentTypeCountOutput.GetPinnableReference(), componentTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSpaceSupportedComponentsFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] uint componentTypeCapacityInput, [Count(Count = 0)] Span<uint> componentTypeCountOutput, [Count(Parameter = "componentTypeCapacityInput")] Span<SpaceComponentTypeFB> componentTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSpaceSupportedComponentsFB(space, componentTypeCapacityInput, ref componentTypeCountOutput.GetPinnableReference(), ref componentTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceComponentStatusFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] SpaceComponentTypeFB componentType, [Count(Count = 0)] Span<SpaceComponentStatusFB> status)
        {
            // SpanOverloader
            return thisApi.GetSpaceComponentStatusFB(space, componentType, ref status.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceUuidFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0)] Span<UuidEXT> uuid)
        {
            // SpanOverloader
            return thisApi.GetSpaceUuidFB(space, ref uuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetSpaceComponentStatusFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceComponentStatusSetInfoFB* info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.SetSpaceComponentStatusFB(space, info, ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetSpaceComponentStatusFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpaceComponentStatusSetInfoFB> info, [Count(Count = 0)] ulong* requestId)
        {
            // SpanOverloader
            return thisApi.SetSpaceComponentStatusFB(space, in info.GetPinnableReference(), requestId);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetSpaceComponentStatusFB(this FBSpatialEntity thisApi, [Count(Count = 0)] Space space, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpaceComponentStatusSetInfoFB> info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.SetSpaceComponentStatusFB(space, in info.GetPinnableReference(), ref requestId.GetPinnableReference());
        }

    }
}

