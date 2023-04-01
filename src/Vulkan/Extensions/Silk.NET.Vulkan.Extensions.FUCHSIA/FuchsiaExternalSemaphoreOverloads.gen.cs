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
    public static class FuchsiaExternalSemaphoreOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreZirconHandleFuchsia(this FuchsiaExternalSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreZirconHandleFuchsia(device, pGetZirconHandleInfo, out pZirconHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreZirconHandleFuchsia(this FuchsiaExternalSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreGetZirconHandleInfoFUCHSIA> pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreZirconHandleFuchsia(device, in pGetZirconHandleInfo.GetPinnableReference(), pZirconHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreZirconHandleFuchsia(this FuchsiaExternalSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SemaphoreGetZirconHandleInfoFUCHSIA> pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pZirconHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreZirconHandleFuchsia(device, in pGetZirconHandleInfo.GetPinnableReference(), out pZirconHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportSemaphoreZirconHandleFuchsia(this FuchsiaExternalSemaphore thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImportSemaphoreZirconHandleInfoFUCHSIA> pImportSemaphoreZirconHandleInfo)
        {
            // SpanOverloader
            return thisApi.ImportSemaphoreZirconHandleFuchsia(device, in pImportSemaphoreZirconHandleInfo.GetPinnableReference());
        }

    }
}

