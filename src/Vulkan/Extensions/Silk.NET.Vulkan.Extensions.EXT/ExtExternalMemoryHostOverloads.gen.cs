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
    public static class ExtExternalMemoryHostOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryHostPointerProperties = new(StructureType.MemoryHostPointerPropertiesExt);")]
        public static unsafe Result GetMemoryHostPointerProperties(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHostPointer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, pHostPointer, out pMemoryHostPointerProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryHostPointerProperties<T0>(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHostPointer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, ref pHostPointer.GetPinnableReference(), pMemoryHostPointerProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryHostPointerProperties = new(StructureType.MemoryHostPointerPropertiesExt);")]
        public static unsafe Result GetMemoryHostPointerProperties<T0>(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHostPointer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, ref pHostPointer.GetPinnableReference(), out pMemoryHostPointerProperties.GetPinnableReference());
        }

    }
}

