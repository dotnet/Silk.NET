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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_buffer_marker")]
    public unsafe partial class AmdBufferMarker : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_buffer_marker";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteBufferMarkerAMD", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteBufferMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] uint marker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteBufferMarker2AMD", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteBufferMarker2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags2 stage, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] uint marker);

        public AmdBufferMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

