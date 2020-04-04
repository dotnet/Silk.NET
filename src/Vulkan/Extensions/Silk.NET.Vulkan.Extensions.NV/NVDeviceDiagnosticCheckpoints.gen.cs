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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_device_diagnostic_checkpoints")]
    public abstract unsafe partial class NVDeviceDiagnosticCheckpoints : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV")]
        public abstract unsafe void CmdSetCheckpoint([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] void* pCheckpointMarker);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV")]
        public abstract void CmdSetCheckpoint<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ref T0 pCheckpointMarker) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV")]
        public abstract unsafe void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Computed = "pCheckpointDataCount"), Flow(FlowDirection.Out)] CheckpointDataNV* pCheckpointData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV")]
        public abstract void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Computed = "pCheckpointDataCount"), Flow(FlowDirection.Out)] out CheckpointDataNV pCheckpointData);

        public NVDeviceDiagnosticCheckpoints(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

