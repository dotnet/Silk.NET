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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrGetMemoryRequirements2Overloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetBufferMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetBufferMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetBufferMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetBufferMemoryRequirements2(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetImageMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageMemoryRequirementsInfo2* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, pInfo, out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryRequirements2* pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, in pInfo.GetPinnableReference(), pMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryRequirements = new(StructureType.MemoryRequirements2);")]
        public static unsafe void GetImageMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageMemoryRequirementsInfo2> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryRequirements2> pMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageMemoryRequirements2(device, in pInfo.GetPinnableReference(), out pMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageSparseMemoryRequirementsInfo2* pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, pInfo, ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] uint* pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), pSparseMemoryRequirementCount, out pSparseMemoryRequirements.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] SparseImageMemoryRequirements2* pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), pSparseMemoryRequirements);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pSparseMemoryRequirements = new(StructureType.SparseImageMemoryRequirements2);")]
        public static unsafe void GetImageSparseMemoryRequirements2(this KhrGetMemoryRequirements2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageSparseMemoryRequirementsInfo2> pInfo, [Count(Count = 0)] Span<uint> pSparseMemoryRequirementCount, [Count(Parameter = "pSparseMemoryRequirementCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SparseImageMemoryRequirements2> pSparseMemoryRequirements)
        {
            // SpanOverloader
            thisApi.GetImageSparseMemoryRequirements2(device, in pInfo.GetPinnableReference(), ref pSparseMemoryRequirementCount.GetPinnableReference(), out pSparseMemoryRequirements.GetPinnableReference());
        }

    }
}

