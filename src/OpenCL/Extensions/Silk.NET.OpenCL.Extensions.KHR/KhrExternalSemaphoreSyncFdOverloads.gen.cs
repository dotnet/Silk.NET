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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrExternalSemaphoreSyncFdOverloads
    {
        public static unsafe int ReImportSemaphoreSyncF(this KhrExternalSemaphoreSyncFd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<SemaphoreReimportProperties> reimport_props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int fd)
        {
            // SpanOverloader
            return thisApi.ReImportSemaphoreSyncF(sema_object, out reimport_props.GetPinnableReference(), fd);
        }

        [Obsolete("The \"ungrouped\" enums (KHR) are deprecated in favour of the \"grouped\" enums (SemaphoreReimportProperties). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int ReImportSemaphoreSyncF(this KhrExternalSemaphoreSyncFd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sema_object, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<KHR> reimport_props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int fd)
        {
            // SpanOverloader
            return thisApi.ReImportSemaphoreSyncF(sema_object, out reimport_props.GetPinnableReference(), fd);
        }

    }
}

