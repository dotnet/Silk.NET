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
    public static class AmdSamplePositionsOverloads
    {
        public static unsafe void SetMultisample(this AmdSamplePositions thisApi, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> val)
        {
            // SpanOverloader
            thisApi.SetMultisample(pname, index, in val.GetPinnableReference());
        }

    }
}

