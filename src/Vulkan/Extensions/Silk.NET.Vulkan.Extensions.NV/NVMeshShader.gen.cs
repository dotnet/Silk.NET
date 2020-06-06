// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_mesh_shader")]
    public unsafe partial class NVMeshShader : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_mesh_shader";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawMeshTask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint taskCount, [Count(Count = 0)] uint firstTask)
            => ImplCmdDrawMeshTask(commandBuffer, taskCount, firstTask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawMeshTasksIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawMeshTasksIndirect(commandBuffer, buffer, offset, drawCount, stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDrawMeshTasksIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride)
            => ImplCmdDrawMeshTasksIndirectCount(commandBuffer, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);

        public NVMeshShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

