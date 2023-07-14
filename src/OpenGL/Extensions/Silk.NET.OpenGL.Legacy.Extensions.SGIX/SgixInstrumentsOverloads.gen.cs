// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
    public static class SgixInstrumentsOverloads
    {
        public static unsafe void InstrumentsBuffer(this SgixInstruments thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> buffer)
        {
            // SpanOverloader
            thisApi.InstrumentsBuffer(size, out buffer.GetPinnableReference());
        }

        public static unsafe int PollInstruments(this SgixInstruments thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> marker_p)
        {
            // SpanOverloader
            return thisApi.PollInstruments(out marker_p.GetPinnableReference());
        }

    }
}

