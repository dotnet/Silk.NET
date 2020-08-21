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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixReferencePlaneOverloads
    {
        public static unsafe void ReferencePlane(this SgixReferencePlane thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> equation)
        {
            // SpanOverloader
            thisApi.ReferencePlane(in equation.GetPinnableReference());
        }

    }
}

