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
    public static class ExtPipelinePropertiesOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineProperties(this ExtPipelineProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoEXT* pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BaseOutStructure> pPipelineProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineProperties(device, pPipelineInfo, out pPipelineProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineProperties(this ExtPipelineProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoEXT> pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BaseOutStructure* pPipelineProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineProperties(device, in pPipelineInfo.GetPinnableReference(), pPipelineProperties);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineProperties(this ExtPipelineProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoEXT> pPipelineInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BaseOutStructure> pPipelineProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineProperties(device, in pPipelineInfo.GetPinnableReference(), out pPipelineProperties.GetPinnableReference());
        }

    }
}

