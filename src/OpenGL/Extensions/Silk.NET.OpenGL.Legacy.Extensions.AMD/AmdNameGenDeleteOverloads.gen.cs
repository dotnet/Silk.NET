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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdNameGenDeleteOverloads
    {
        public static unsafe void DeleteNames(this AmdNameGenDelete thisApi, [Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] ReadOnlySpan<uint> names)
        {
            // SpanOverloader
            thisApi.DeleteNames(identifier, num, in names.GetPinnableReference());
        }

        public static unsafe void GenNames(this AmdNameGenDelete thisApi, [Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] Span<uint> names)
        {
            // SpanOverloader
            thisApi.GenNames(identifier, num, out names.GetPinnableReference());
        }

    }
}

