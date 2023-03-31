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
    public static class ArbVertexShaderOverloads
    {
        public static unsafe void BindAttribLocation(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindAttribLocation(programObj, index, in name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<AttributeType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveAttrib(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe int GetAttribLocation(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetAttribLocation(programObj, in name.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttrib(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttrib(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4N(this ArbVertexShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4N(index, in v.GetPinnableReference());
        }

    }
}

