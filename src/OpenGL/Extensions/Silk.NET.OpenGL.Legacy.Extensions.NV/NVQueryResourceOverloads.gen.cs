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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVQueryResourceOverloads
    {
        public static unsafe int QueryResource(this NVQueryResource thisApi, [Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> buffer)
        {
            // SpanOverloader
            return thisApi.QueryResource(queryType, tagId, count, out buffer.GetPinnableReference());
        }

    }
}

