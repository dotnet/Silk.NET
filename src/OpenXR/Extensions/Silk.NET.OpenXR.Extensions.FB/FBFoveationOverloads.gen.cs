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
    public static class FBFoveationOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFoveationProfileFB(this FBFoveation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FoveationProfileCreateInfoFB* createInfo, [Count(Count = 0)] Span<FoveationProfileFB> profile)
        {
            // SpanOverloader
            return thisApi.CreateFoveationProfileFB(session, createInfo, ref profile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFoveationProfileFB(this FBFoveation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FoveationProfileCreateInfoFB> createInfo, [Count(Count = 0)] FoveationProfileFB* profile)
        {
            // SpanOverloader
            return thisApi.CreateFoveationProfileFB(session, in createInfo.GetPinnableReference(), profile);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFoveationProfileFB(this FBFoveation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FoveationProfileCreateInfoFB> createInfo, [Count(Count = 0)] Span<FoveationProfileFB> profile)
        {
            // SpanOverloader
            return thisApi.CreateFoveationProfileFB(session, in createInfo.GetPinnableReference(), ref profile.GetPinnableReference());
        }

    }
}

