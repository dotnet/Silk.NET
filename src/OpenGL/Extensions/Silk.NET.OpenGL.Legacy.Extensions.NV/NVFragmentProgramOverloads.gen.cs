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
        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, in name.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramNamedParameter(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetProgramNamedParameter(id, len, name, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), x, y, z, w);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), v);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), x, y, z, w);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), v);
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, in name.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ProgramNamedParameter4(this NVFragmentProgram thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.ProgramNamedParameter4(id, len, name, in v.GetPinnableReference());
        }

    }
}

