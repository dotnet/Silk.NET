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
    public static class ArbShaderObjectsOverloads
    {
        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, count, out obj.GetPinnableReference());
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, out count.GetPinnableReference(), obj);
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, out count.GetPinnableReference(), out obj.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetObjectParameter(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectParameter(obj, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectParameter(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectParameter(obj, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), source);
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(programObj, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(programObj, location, out @params.GetPinnableReference());
        }

        public static unsafe int GetUniformLocation(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetUniformLocation(programObj, in name.GetPinnableReference());
        }

        public static unsafe void ShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shaderObj, count, @string, in length.GetPinnableReference());
        }

        public static unsafe void ShaderSource(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shaderObj, count, in @string, in length.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4(this ArbShaderObjects thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4(location, count, transpose, in value.GetPinnableReference());
        }

    }
}

