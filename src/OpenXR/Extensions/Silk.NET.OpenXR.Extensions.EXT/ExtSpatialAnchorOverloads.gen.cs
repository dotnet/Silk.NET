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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtSpatialAnchorOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] Span<SpatialEntityEXT> anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, createInfo, anchorEntityId, ref anchorEntity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] Span<ulong> anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, createInfo, ref anchorEntityId.GetPinnableReference(), anchorEntity);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoEXT* createInfo, [Count(Count = 0)] Span<ulong> anchorEntityId, [Count(Count = 0)] Span<SpatialEntityEXT> anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, createInfo, ref anchorEntityId.GetPinnableReference(), ref anchorEntity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoEXT> createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, in createInfo.GetPinnableReference(), anchorEntityId, anchorEntity);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoEXT> createInfo, [Count(Count = 0)] ulong* anchorEntityId, [Count(Count = 0)] Span<SpatialEntityEXT> anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, in createInfo.GetPinnableReference(), anchorEntityId, ref anchorEntity.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoEXT> createInfo, [Count(Count = 0)] Span<ulong> anchorEntityId, [Count(Count = 0)] SpatialEntityEXT* anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, in createInfo.GetPinnableReference(), ref anchorEntityId.GetPinnableReference(), anchorEntity);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchor(this ExtSpatialAnchor thisApi, [Count(Count = 0)] SpatialContextEXT spatialContext, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoEXT> createInfo, [Count(Count = 0)] Span<ulong> anchorEntityId, [Count(Count = 0)] Span<SpatialEntityEXT> anchorEntity)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchor(spatialContext, in createInfo.GetPinnableReference(), ref anchorEntityId.GetPinnableReference(), ref anchorEntity.GetPinnableReference());
        }

    }
}

