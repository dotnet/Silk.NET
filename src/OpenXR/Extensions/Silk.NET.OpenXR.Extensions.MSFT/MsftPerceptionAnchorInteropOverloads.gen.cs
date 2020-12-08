// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftPerceptionAnchorInteropOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPerceptionAnchorMsft(this MsftPerceptionAnchorInterop thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Silk.NET.Core.Native.IUnknown* perceptionAnchor, [Count(Count = 0)] Span<SpatialAnchorMSFT> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPerceptionAnchorMsft(session, perceptionAnchor, ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPerceptionAnchorMsft(this MsftPerceptionAnchorInterop thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<Silk.NET.Core.Native.IUnknown> perceptionAnchor, [Count(Count = 0)] SpatialAnchorMSFT* anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPerceptionAnchorMsft(session, ref perceptionAnchor.GetPinnableReference(), anchor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorFromPerceptionAnchorMsft(this MsftPerceptionAnchorInterop thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<Silk.NET.Core.Native.IUnknown> perceptionAnchor, [Count(Count = 0)] Span<SpatialAnchorMSFT> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorFromPerceptionAnchorMsft(session, ref perceptionAnchor.GetPinnableReference(), ref anchor.GetPinnableReference());
        }

    }
}

