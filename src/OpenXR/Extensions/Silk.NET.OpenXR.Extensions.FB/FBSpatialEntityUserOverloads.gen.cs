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
    public static class FBSpatialEntityUserOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpaceUserFB(this FBSpatialEntityUser thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpaceUserCreateInfoFB* info, [Count(Count = 0)] Span<SpaceUserFB> user)
        {
            // SpanOverloader
            return thisApi.CreateSpaceUserFB(session, info, ref user.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpaceUserFB(this FBSpatialEntityUser thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpaceUserCreateInfoFB> info, [Count(Count = 0)] SpaceUserFB* user)
        {
            // SpanOverloader
            return thisApi.CreateSpaceUserFB(session, in info.GetPinnableReference(), user);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpaceUserFB(this FBSpatialEntityUser thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpaceUserCreateInfoFB> info, [Count(Count = 0)] Span<SpaceUserFB> user)
        {
            // SpanOverloader
            return thisApi.CreateSpaceUserFB(session, in info.GetPinnableReference(), ref user.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpaceUserIdFB(this FBSpatialEntityUser thisApi, [Count(Count = 0)] SpaceUserFB user, [Count(Count = 0)] Span<ulong> userId)
        {
            // SpanOverloader
            return thisApi.GetSpaceUserIdFB(user, ref userId.GetPinnableReference());
        }

    }
}

