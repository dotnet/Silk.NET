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
    [Extension("XR_FB_display_refresh_rate")]
    public unsafe partial class FBDisplayRefreshRate : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_display_refresh_rate";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateDisplayRefreshRatesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] uint* displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] float* displayRefreshRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateDisplayRefreshRatesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] uint* displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] ref float displayRefreshRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateDisplayRefreshRatesFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] ref uint displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] float* displayRefreshRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateDisplayRefreshRatesFB", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] ref uint displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] ref float displayRefreshRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDisplayRefreshRateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDisplayRefreshRateFB([Count(Count = 0)] Session session, [Count(Count = 0)] float* displayRefreshRate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetDisplayRefreshRateFB", Convention = CallingConvention.Winapi)]
        public partial Result GetDisplayRefreshRateFB([Count(Count = 0)] Session session, [Count(Count = 0)] ref float displayRefreshRate);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestDisplayRefreshRateFB", Convention = CallingConvention.Winapi)]
        public partial Result RequestDisplayRefreshRateFB([Count(Count = 0)] Session session, [Count(Count = 0)] float displayRefreshRate);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] uint* displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // ImplicitCountSpanOverloader
            return EnumerateDisplayRefreshRatesFB(session, (uint) displayRefreshRates.Length, displayRefreshRateCountOutput, ref displayRefreshRates.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateDisplayRefreshRatesFB([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // ImplicitCountSpanOverloader
            return EnumerateDisplayRefreshRatesFB(session, (uint) displayRefreshRates.Length, ref displayRefreshRateCountOutput, ref displayRefreshRates.GetPinnableReference());
        }

        public FBDisplayRefreshRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

