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
    public static class FuchsiaExternalMemoryOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryZirconHandleFuchsia(this FuchsiaExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryZirconHandleFuchsia(device, pGetZirconHandleInfo, out pZirconHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryZirconHandleFuchsia(this FuchsiaExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetZirconHandleInfoFUCHSIA> pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryZirconHandleFuchsia(device, in pGetZirconHandleInfo.GetPinnableReference(), pZirconHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryZirconHandleFuchsia(this FuchsiaExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetZirconHandleInfoFUCHSIA> pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryZirconHandleFuchsia(device, in pGetZirconHandleInfo.GetPinnableReference(), out pZirconHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryZirconHandleProperties = new(StructureType.MemoryZirconHandlePropertiesFuchsia);")]
        public static unsafe Result GetMemoryZirconHandlePropertiesFuchsia(this FuchsiaExternalMemory thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint zirconHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryZirconHandlePropertiesFUCHSIA> pMemoryZirconHandleProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryZirconHandlePropertiesFuchsia(device, handleType, zirconHandle, out pMemoryZirconHandleProperties.GetPinnableReference());
        }

    }
}

