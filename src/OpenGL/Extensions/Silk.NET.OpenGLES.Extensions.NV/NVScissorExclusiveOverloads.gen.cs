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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVScissorExclusiveOverloads
    {
        public static unsafe void ScissorExclusiveArray(this NVScissorExclusive thisApi, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorExclusiveArray(first, count, in v.GetPinnableReference());
        }

    }
}

