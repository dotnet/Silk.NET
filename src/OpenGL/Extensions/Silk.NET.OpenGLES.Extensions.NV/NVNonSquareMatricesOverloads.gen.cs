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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVNonSquareMatricesOverloads
    {
        public static unsafe void UniformMatrix2x3(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2x4(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x2(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3x4(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3x4(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x2(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4x3(this NVNonSquareMatrices thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4x3(location, count, transpose, in value.GetPinnableReference());
        }

    }
}

