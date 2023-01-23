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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVFragmentProgramOverloads
    {
        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), x, y, z, w);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), v);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), x, y, z, w);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] byte* name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.In)] double* v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), v);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint len, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

    }
}

