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
    [Extension("VK_EXT_image_compression_control")]
    public unsafe partial class ExtImageCompressionControl : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_image_compression_control";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource2EXT* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout2EXT* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource2EXT* pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout2EXT pLayout);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSubresource2EXT pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] SubresourceLayout2EXT* pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        [NativeApi(EntryPoint = "vkGetImageSubresourceLayout2EXT", Convention = CallingConvention.Winapi)]
        public partial void GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSubresource2EXT pSubresource, [Count(Count = 0), Flow(FlowDirection.Out)] out SubresourceLayout2EXT pLayout);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        public unsafe SubresourceLayout2EXT GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] ImageSubresource2EXT* pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, pSubresource, out SubresourceLayout2EXT silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pLayout = new(StructureType.SubresourceLayout2Ext);")]
        public unsafe SubresourceLayout2EXT GetImageSubresourceLayout2([Count(Count = 0)] Device device, [Count(Count = 0)] Image image, [Count(Count = 0), Flow(FlowDirection.In)] in ImageSubresource2EXT pSubresource)
        {
            // NonKhrReturnTypeOverloader
            GetImageSubresourceLayout2(device, image, in pSubresource, out SubresourceLayout2EXT silkRet);
            return silkRet;
        }

        public ExtImageCompressionControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

