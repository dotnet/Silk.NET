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
    [Extension("VK_NV_device_diagnostic_checkpoints")]
    public unsafe partial class NVDeviceDiagnosticCheckpoints : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_diagnostic_checkpoints";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdSetCheckpoint([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] void* pCheckpointMarker)
            => ImplCmdSetCheckpoint(commandBuffer, pCheckpointMarker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdSetCheckpoint<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ref T0 pCheckpointMarker) where T0 : unmanaged
            => ImplCmdSetCheckpoint<T0>(commandBuffer, pCheckpointMarker);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Computed = "pCheckpointDataCount"), Flow(FlowDirection.Out)] CheckpointDataNV* pCheckpointData)
            => ImplGetQueueCheckpointData(queue, pCheckpointDataCount, pCheckpointData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Computed = "pCheckpointDataCount"), Flow(FlowDirection.Out)] out CheckpointDataNV pCheckpointData)
            => ImplGetQueueCheckpointData(queue, pCheckpointDataCount, pCheckpointData);

        public NVDeviceDiagnosticCheckpoints(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

