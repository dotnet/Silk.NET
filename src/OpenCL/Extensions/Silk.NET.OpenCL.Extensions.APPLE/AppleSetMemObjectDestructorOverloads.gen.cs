// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe int SetMemObjectDestructor<T0>(this AppleSetMemObjectDestructor thisApi, [Flow(FlowDirection.In)] nint memobj, [Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] NotifyCallback pfn_notify, [Flow(FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetMemObjectDestructor(memobj, pfn_notify, out user_data.GetPinnableReference());
        }

    }
}

