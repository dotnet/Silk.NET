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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiElementArrayOverloads
    {
        public static unsafe void ElementPointer<T0>(this AtiElementArray thisApi, [Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ElementPointer(type, in pointer.GetPinnableReference());
        }

        public static unsafe void ElementPointer<T0>(this AtiElementArray thisApi, [Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ElementPointer(type, in pointer.GetPinnableReference());
        }

    }
}

