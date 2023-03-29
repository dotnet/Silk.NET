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
    public static class KhrIlProgramOverloads
    {
        public static unsafe nint CreateProgramWithIL<T0>(this KhrIlProgram thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] Span<T0> il, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* ilSpp = il)
                return thisApi.CreateProgramWithIL(context, ilSpp, length, out errcode_ret.GetPinnableReference());
        }

    }
}

