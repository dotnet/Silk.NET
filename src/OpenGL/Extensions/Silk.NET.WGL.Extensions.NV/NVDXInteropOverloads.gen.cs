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

namespace Silk.NET.WGL.Extensions.NV
{
    public static class NVDXInteropOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 DxlockObjects(this NVDXInterop thisApi, [Flow(FlowDirection.In)] nint hDevice, [Flow(FlowDirection.In)] int count, [Flow(FlowDirection.Out)] Span<nint> hObjects)
        {
            // SpanOverloader
            return thisApi.DxlockObjects(hDevice, count, out hObjects.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 DxunlockObjects(this NVDXInterop thisApi, [Flow(FlowDirection.In)] nint hDevice, [Flow(FlowDirection.In)] int count, [Flow(FlowDirection.Out)] Span<nint> hObjects)
        {
            // SpanOverloader
            return thisApi.DxunlockObjects(hDevice, count, out hObjects.GetPinnableReference());
        }

    }
}

