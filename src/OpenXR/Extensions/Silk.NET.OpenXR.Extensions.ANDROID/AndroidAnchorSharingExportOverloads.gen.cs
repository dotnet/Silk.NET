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

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    public static class AndroidAnchorSharingExportOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result ShareAnchor(this AndroidAnchorSharingExport thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSharingInfoANDROID* sharingInfo, [Count(Count = 0)] Span<AnchorSharingTokenANDROID> anchorToken)
        {
            // SpanOverloader
            return thisApi.ShareAnchor(session, sharingInfo, ref anchorToken.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareAnchor(this AndroidAnchorSharingExport thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSharingInfoANDROID> sharingInfo, [Count(Count = 0)] AnchorSharingTokenANDROID* anchorToken)
        {
            // SpanOverloader
            return thisApi.ShareAnchor(session, in sharingInfo.GetPinnableReference(), anchorToken);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ShareAnchor(this AndroidAnchorSharingExport thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSharingInfoANDROID> sharingInfo, [Count(Count = 0)] Span<AnchorSharingTokenANDROID> anchorToken)
        {
            // SpanOverloader
            return thisApi.ShareAnchor(session, in sharingInfo.GetPinnableReference(), ref anchorToken.GetPinnableReference());
        }

    }
}

