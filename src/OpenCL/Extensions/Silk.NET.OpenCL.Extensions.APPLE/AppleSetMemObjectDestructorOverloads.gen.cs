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

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    public static class AppleSetMemObjectDestructorOverloads
    {
        public static unsafe int SetMemObjectDestructor<T0>(this AppleSetMemObjectDestructor thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint memobj, [Flow(Silk.NET.Core.Native.FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] ObjectNotifyCallback pfn_notify, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetMemObjectDestructor(memobj, pfn_notify, out user_data.GetPinnableReference());
        }

    }
}

