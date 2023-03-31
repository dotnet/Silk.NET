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

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVFramebufferMixedSamplesOverloads
    {
        public static unsafe void CoverageModulationTable(this NVFramebufferMixedSamples thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.CoverageModulationTable(n, in v.GetPinnableReference());
        }

        public static unsafe void GetCoverageModulationTable(this NVFramebufferMixedSamples thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // SpanOverloader
            thisApi.GetCoverageModulationTable(bufSize, out v.GetPinnableReference());
        }

    }
}

