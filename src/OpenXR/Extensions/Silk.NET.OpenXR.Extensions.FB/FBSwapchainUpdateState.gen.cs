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
    [Extension("XR_FB_swapchain_update_state")]
    public unsafe partial class FBSwapchainUpdateState : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_FB_swapchain_update_state";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSwapchainStateFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetSwapchainStateFB([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] SwapchainStateBaseHeaderFB* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetSwapchainStateFB", Convention = CallingConvention.Winapi)]
        public partial Result GetSwapchainStateFB([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0)] ref SwapchainStateBaseHeaderFB state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSwapchainFB", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UpdateSwapchainFB([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainStateBaseHeaderFB* state);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrUpdateSwapchainFB", Convention = CallingConvention.Winapi)]
        public partial Result UpdateSwapchainFB([Count(Count = 0)] Swapchain swapchain, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainStateBaseHeaderFB state);

        public FBSwapchainUpdateState(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

