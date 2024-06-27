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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrLocateSpacesOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this KhrLocateSpaces thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpacesLocateInfo* locateInfo, [Count(Count = 0)] Span<SpaceLocations> spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, locateInfo, ref spaceLocations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this KhrLocateSpaces thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpacesLocateInfo> locateInfo, [Count(Count = 0)] SpaceLocations* spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, in locateInfo.GetPinnableReference(), spaceLocations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateSpaces(this KhrLocateSpaces thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpacesLocateInfo> locateInfo, [Count(Count = 0)] Span<SpaceLocations> spaceLocations)
        {
            // SpanOverloader
            return thisApi.LocateSpaces(session, in locateInfo.GetPinnableReference(), ref spaceLocations.GetPinnableReference());
        }

    }
}

