// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtExternalMemoryHostOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryHostPointerProperties(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, pHostPointer, out pMemoryHostPointerProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryHostPointerProperties<T0>(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, ref pHostPointer.GetPinnableReference(), pMemoryHostPointerProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryHostPointerProperties<T0>(this ExtExternalMemoryHost thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryHostPointerPropertiesEXT> pMemoryHostPointerProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryHostPointerProperties(device, handleType, ref pHostPointer.GetPinnableReference(), out pMemoryHostPointerProperties.GetPinnableReference());
        }

    }
}

