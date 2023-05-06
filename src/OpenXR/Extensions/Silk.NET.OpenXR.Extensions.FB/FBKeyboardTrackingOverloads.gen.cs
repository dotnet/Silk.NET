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
    public static class FBKeyboardTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateKeyboardSpaceFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardSpaceCreateInfoFB* createInfo, [Count(Count = 0)] Span<Space> keyboardSpace)
        {
            // SpanOverloader
            return thisApi.CreateKeyboardSpaceFB(session, createInfo, ref keyboardSpace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateKeyboardSpaceFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KeyboardSpaceCreateInfoFB> createInfo, [Count(Count = 0)] Space* keyboardSpace)
        {
            // SpanOverloader
            return thisApi.CreateKeyboardSpaceFB(session, in createInfo.GetPinnableReference(), keyboardSpace);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateKeyboardSpaceFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KeyboardSpaceCreateInfoFB> createInfo, [Count(Count = 0)] Span<Space> keyboardSpace)
        {
            // SpanOverloader
            return thisApi.CreateKeyboardSpaceFB(session, in createInfo.GetPinnableReference(), ref keyboardSpace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySystemTrackedKeyboardFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] KeyboardTrackingQueryFB* queryInfo, [Count(Count = 0)] Span<KeyboardTrackingDescriptionFB> keyboard)
        {
            // SpanOverloader
            return thisApi.QuerySystemTrackedKeyboardFB(session, queryInfo, ref keyboard.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySystemTrackedKeyboardFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KeyboardTrackingQueryFB> queryInfo, [Count(Count = 0)] KeyboardTrackingDescriptionFB* keyboard)
        {
            // SpanOverloader
            return thisApi.QuerySystemTrackedKeyboardFB(session, in queryInfo.GetPinnableReference(), keyboard);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QuerySystemTrackedKeyboardFB(this FBKeyboardTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<KeyboardTrackingQueryFB> queryInfo, [Count(Count = 0)] Span<KeyboardTrackingDescriptionFB> keyboard)
        {
            // SpanOverloader
            return thisApi.QuerySystemTrackedKeyboardFB(session, in queryInfo.GetPinnableReference(), ref keyboard.GetPinnableReference());
        }

    }
}

