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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbProgramInterfaceQueryOverloads
    {
        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramResourceProperty* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

    }
}

