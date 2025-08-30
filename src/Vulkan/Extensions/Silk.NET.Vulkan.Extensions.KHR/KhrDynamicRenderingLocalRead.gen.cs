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
    [Extension("VK_KHR_dynamic_rendering_local_read")]
    public unsafe partial class KhrDynamicRenderingLocalRead : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_dynamic_rendering_local_read";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetRenderingAttachmentLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingAttachmentLocationInfoKHR* pLocationInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRenderingAttachmentLocationsKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRenderingAttachmentLocation([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingAttachmentLocationInfoKHR pLocationInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetRenderingInputAttachmentIndices([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderingInputAttachmentIndexInfoKHR* pInputAttachmentIndexInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetRenderingInputAttachmentIndicesKHR", Convention = CallingConvention.Winapi)]
        public partial void CmdSetRenderingInputAttachmentIndices([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in RenderingInputAttachmentIndexInfoKHR pInputAttachmentIndexInfo);

        public KhrDynamicRenderingLocalRead(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

