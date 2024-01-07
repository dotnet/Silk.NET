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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_display_swapchain")]
    public unsafe partial class KhrDisplaySwapchain : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_display_swapchain";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSharedSwapchainsKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SwapchainCreateInfoKHR pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SwapchainKHR pSwapchains);

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pSwapchains.Length, pCreateInfos, pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SwapchainCreateInfoKHR* pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pSwapchains.Length, pCreateInfos, in pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), pAllocator, pSwapchains);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pSwapchains.Length, in pCreateInfos.GetPinnableReference(), pAllocator, out pSwapchains.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SwapchainKHR* pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pCreateInfos.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, pSwapchains);
        }

        /// <summary>To be documented.</summary>
        public unsafe Result CreateSharedSwapchain([Count(Count = 0)] Device device, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SwapchainCreateInfoKHR> pCreateInfos, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Parameter = "swapchainCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SwapchainKHR> pSwapchains)
        {
            // ImplicitCountSpanOverloader
            return CreateSharedSwapchain(device, (uint) pSwapchains.Length, in pCreateInfos.GetPinnableReference(), in pAllocator, out pSwapchains.GetPinnableReference());
        }

        public KhrDisplaySwapchain(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

