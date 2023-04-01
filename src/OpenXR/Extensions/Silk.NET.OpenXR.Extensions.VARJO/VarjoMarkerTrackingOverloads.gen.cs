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

namespace Silk.NET.OpenXR.Extensions.VARJO
{
    public static class VarjoMarkerTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceVarjo(this VarjoMarkerTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoVARJO* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceVarjo(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceVarjo(this VarjoMarkerTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerSpaceCreateInfoVARJO> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceVarjo(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceVarjo(this VarjoMarkerTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerSpaceCreateInfoVARJO> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceVarjo(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerSizeVarjo(this VarjoMarkerTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ulong markerId, [Count(Count = 0)] Span<Extent2Df> size)
        {
            // SpanOverloader
            return thisApi.GetMarkerSizeVarjo(session, markerId, ref size.GetPinnableReference());
        }

    }
}

