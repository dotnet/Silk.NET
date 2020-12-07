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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtWindowRectanglesOverloads
    {
        public static unsafe void WindowRectangles(this ExtWindowRectangles thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> box)
        {
            // SpanOverloader
            thisApi.WindowRectangles(mode, count, in box.GetPinnableReference());
        }

    }
}

