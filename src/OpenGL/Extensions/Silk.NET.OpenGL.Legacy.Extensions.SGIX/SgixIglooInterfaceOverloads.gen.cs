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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixIglooInterfaceOverloads
    {
        public static unsafe void IglooInterface<T0>(this SgixIglooInterface thisApi, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @params) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.IglooInterface(pname, in @params.GetPinnableReference());
        }

    }
}

