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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_buffer_marker")]
    public abstract unsafe partial class AmdBufferMarker : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdWriteBufferMarkerAMD")]
        public abstract void CmdWriteBufferMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] uint marker);

        public AmdBufferMarker(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

