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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_mesh_shader")]
    public unsafe partial class NVMeshShader : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_mesh_shader";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksNV", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawMeshTask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint taskCount, [Count(Count = 0)] uint firstTask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectNV", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawMeshTasksIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawMeshTasksIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        public NVMeshShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

