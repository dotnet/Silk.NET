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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_host_image_copy")]
    public unsafe partial class ExtHostImageCopy : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_host_image_copy";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyImageToImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyImageToImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageToImageInfoEXT* pCopyImageToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyImageToImageEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyImageToImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyImageToImageInfoEXT pCopyImageToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyImageToMemoryEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyImageToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyImageToMemoryInfoEXT* pCopyImageToMemoryInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyImageToMemoryEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyImageToMemory([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyImageToMemoryInfoEXT pCopyImageToMemoryInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CopyMemoryToImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] CopyMemoryToImageInfoEXT* pCopyMemoryToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCopyMemoryToImageEXT", Convention = CallingConvention.Winapi)]
        public partial Result CopyMemoryToImage([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CopyMemoryToImageInfoEXT pCopyMemoryToImageInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SubresourceLayout2KHR* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out SubresourceLayout2KHR pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkTransitionImageLayoutEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result TransitionImageLayout([Count(Count = 0)] Device device, [Count(Count = 0)] uint transitionCount, [Count(Parameter = "transitionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] HostImageLayoutTransitionInfoEXT* pTransitions);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkTransitionImageLayoutEXT", Convention = CallingConvention.Winapi)]
        public partial Result TransitionImageLayout([Count(Count = 0)] Device device, [Count(Count = 0)] uint transitionCount, [Count(Parameter = "transitionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in HostImageLayoutTransitionInfoEXT pTransitions);

        /// <summary>To be documented.</summary>
        public unsafe Result TransitionImageLayout([Count(Count = 0)] Device device, [Count(Parameter = "transitionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HostImageLayoutTransitionInfoEXT> pTransitions)
        {
            // ImplicitCountSpanOverloader
            return TransitionImageLayout(device, (uint) pTransitions.Length, in pTransitions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSubresource2KHR* pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, pSubresource, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Khr);")]
        public unsafe SubresourceLayout2KHR GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageSubresource2KHR pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, in pSubresource, out SubresourceLayout2KHR silkRet);
            return silkRet;
        }

        public ExtHostImageCopy(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

