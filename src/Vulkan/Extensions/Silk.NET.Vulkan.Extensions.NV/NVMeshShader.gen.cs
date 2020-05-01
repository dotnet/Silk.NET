// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_mesh_shader")]
    public abstract unsafe partial class NVMeshShader : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_mesh_shader";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksNV")]
        public abstract void CmdDrawMeshTask([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint taskCount, [Count(Count = 0)] uint firstTask);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectNV")]
        public abstract void CmdDrawMeshTasksIndirect([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] uint drawCount, [Count(Count = 0)] uint stride);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV")]
        public abstract void CmdDrawMeshTasksIndirectCount([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset, [Count(Count = 0)] Buffer countBuffer, [Count(Count = 0)] ulong countBufferOffset, [Count(Count = 0)] uint maxDrawCount, [Count(Count = 0)] uint stride);

        public NVMeshShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

