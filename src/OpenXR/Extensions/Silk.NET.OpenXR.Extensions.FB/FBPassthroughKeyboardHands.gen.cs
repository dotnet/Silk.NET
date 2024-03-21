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
    [Extension("XR_FB_passthrough_keyboard_hands")]
    public unsafe partial class FBPassthroughKeyboardHands : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_passthrough_keyboard_hands";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerSetKeyboardHandsIntensityFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result PassthroughLayerSetKeyboardHandsIntensityFB([Count(Count = 0)] PassthroughLayerFB layer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughKeyboardHandsIntensityFB* intensity);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrPassthroughLayerSetKeyboardHandsIntensityFB", Convention = CallingConvention.Winapi)]
        public partial Result PassthroughLayerSetKeyboardHandsIntensityFB([Count(Count = 0)] PassthroughLayerFB layer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PassthroughKeyboardHandsIntensityFB intensity);

        public FBPassthroughKeyboardHands(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

