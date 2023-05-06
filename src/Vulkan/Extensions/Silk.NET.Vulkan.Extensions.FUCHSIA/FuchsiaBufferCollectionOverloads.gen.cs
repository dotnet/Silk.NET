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

namespace Silk.NET.Vulkan.Extensions.FUCHSIA
{
    public static class FuchsiaBufferCollectionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferCollectionFUCHSIA> pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, pCreateInfo, pAllocator, out pCollection.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, pCreateInfo, in pAllocator.GetPinnableReference(), pCollection);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferCollectionCreateInfoFUCHSIA* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferCollectionFUCHSIA> pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pCollection.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCollectionCreateInfoFUCHSIA> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, in pCreateInfo.GetPinnableReference(), pAllocator, pCollection);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCollectionCreateInfoFUCHSIA> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferCollectionFUCHSIA> pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pCollection.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCollectionCreateInfoFUCHSIA> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] BufferCollectionFUCHSIA* pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pCollection);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferCollectionCreateInfoFUCHSIA> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferCollectionFUCHSIA> pCollection)
        {
            // SpanOverloader
            return thisApi.CreateBufferCollectionFuchsia(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pCollection.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyBufferCollectionFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyBufferCollectionFuchsia(device, collection, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.BufferCollectionPropertiesFuchsia);")]
        public static unsafe Result GetBufferCollectionPropertiesFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<BufferCollectionPropertiesFUCHSIA> pProperties)
        {
            // SpanOverloader
            return thisApi.GetBufferCollectionPropertiesFuchsia(device, collection, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetBufferCollectionBufferConstraintsFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BufferConstraintsInfoFUCHSIA> pBufferConstraintsInfo)
        {
            // SpanOverloader
            return thisApi.SetBufferCollectionBufferConstraintsFuchsia(device, collection, in pBufferConstraintsInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SetBufferCollectionImageConstraintsFuchsia(this FuchsiaBufferCollection thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] BufferCollectionFUCHSIA collection, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImageConstraintsInfoFUCHSIA> pImageConstraintsInfo)
        {
            // SpanOverloader
            return thisApi.SetBufferCollectionImageConstraintsFuchsia(device, collection, in pImageConstraintsInfo.GetPinnableReference());
        }

    }
}

