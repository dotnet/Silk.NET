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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbProgramInterfaceQueryOverloads
    {
        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramInterface(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramInterface(program, programInterface, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ARB* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, props, count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, length, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), @params);
        }

        public static unsafe void GetProgramResource(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ReadOnlySpan<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramResource(program, programInterface, index, propCount, in props.GetPinnableReference(), count, out length.GetPinnableReference(), out @params.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe uint GetProgramResourceIndex(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocation(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocation(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ARB programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, length, out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), name);
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetProgramResourceName(this ArbProgramInterfaceQuery thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetProgramResourceName(program, programInterface, index, bufSize, out length.GetPinnableReference(), out name.GetPinnableReference());
        }

    }
}

