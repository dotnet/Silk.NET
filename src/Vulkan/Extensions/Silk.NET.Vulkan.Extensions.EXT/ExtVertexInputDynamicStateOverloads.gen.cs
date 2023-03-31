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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtVertexInputDynamicStateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtVertexInputDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputBindingDescription2EXT* pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, pVertexBindingDescriptions, vertexAttributeDescriptionCount, in pVertexAttributeDescriptions.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtVertexInputDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputBindingDescription2EXT> pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexInputAttributeDescription2EXT* pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, in pVertexBindingDescriptions.GetPinnableReference(), vertexAttributeDescriptionCount, pVertexAttributeDescriptions);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetVertexInput(this ExtVertexInputDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint vertexBindingDescriptionCount, [Count(Parameter = "vertexBindingDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputBindingDescription2EXT> pVertexBindingDescriptions, [Count(Count = 0)] uint vertexAttributeDescriptionCount, [Count(Parameter = "vertexAttributeDescriptionCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexInputAttributeDescription2EXT> pVertexAttributeDescriptions)
        {
            // SpanOverloader
            thisApi.CmdSetVertexInput(commandBuffer, vertexBindingDescriptionCount, in pVertexBindingDescriptions.GetPinnableReference(), vertexAttributeDescriptionCount, in pVertexAttributeDescriptions.GetPinnableReference());
        }

    }
}

