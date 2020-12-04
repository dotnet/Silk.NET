// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrPushDescriptorOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe void CmdPushDescriptorSet(this KhrPushDescriptor thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineBindPoint pipelineBindPoint, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] uint descriptorWriteCount, [Count(Computed = "descriptorWriteCount"), Flow(FlowDirection.In)] ReadOnlySpan<WriteDescriptorSet> pDescriptorWrites)
        {
            // SpanOverloader
            thisApi.CmdPushDescriptorSet(commandBuffer, pipelineBindPoint, layout, set, descriptorWriteCount, in pDescriptorWrites.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void CmdPushDescriptorSetWithTemplate<T0>(this KhrPushDescriptor thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DescriptorUpdateTemplate descriptorUpdateTemplate, [Count(Count = 0)] PipelineLayout layout, [Count(Count = 0)] uint set, [Count(Count = 0)] Span<T0> pData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.CmdPushDescriptorSetWithTemplate(commandBuffer, descriptorUpdateTemplate, layout, set, ref pData.GetPinnableReference());
        }

    }
}

