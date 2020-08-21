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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtShaderPixelLocalStorage2Overloads
    {
        public static unsafe void ClearPixelLocalStorage(this ExtShaderPixelLocalStorage2 thisApi, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> values)
        {
            // SpanOverloader
            thisApi.ClearPixelLocalStorage(offset, n, in values.GetPinnableReference());
        }

    }
}

