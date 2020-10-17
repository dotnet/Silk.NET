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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVExplicitMultisampleOverloads
    {
        public static unsafe void GetMultisample(this NVExplicitMultisample thisApi, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

        public static unsafe void GetMultisample(this NVExplicitMultisample thisApi, [Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

    }
}

