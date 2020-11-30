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
    public static class ArbShaderObjectsOverloads
    {
        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<ARB> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, length, out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), size, out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), type, out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), name);
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetActiveUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> size, [Count(Count = 1), Flow(FlowDirection.Out)] Span<UniformType> type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // SpanOverloader
            thisApi.GetActiveUniform(programObj, index, maxLength, out length.GetPinnableReference(), out size.GetPinnableReference(), out type.GetPinnableReference(), out name.GetPinnableReference());
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, count, out obj.GetPinnableReference());
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, out count.GetPinnableReference(), obj);
        }

        public static unsafe void GetAttachedObjects(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> obj)
        {
            // SpanOverloader
            thisApi.GetAttachedObjects(containerObj, maxCount, out count.GetPinnableReference(), out obj.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, length, out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), infoLog);
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetInfoLog(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> infoLog)
        {
            // SpanOverloader
            thisApi.GetInfoLog(obj, maxLength, out length.GetPinnableReference(), out infoLog.GetPinnableReference());
        }

        public static unsafe void GetObjectParameter(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetObjectParameter(obj, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetObjectParameter(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetObjectParameter(obj, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, length, out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), source);
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // SpanOverloader
            thisApi.GetShaderSource(obj, maxLength, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(programObj, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(programObj, location, out @params.GetPinnableReference());
        }

        public static unsafe int GetUniformLocation(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] ReadOnlySpan<char> name)
        {
            // SpanOverloader
            return thisApi.GetUniformLocation(programObj, in name.GetPinnableReference());
        }

        public static unsafe void ShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shaderObj, count, @string, in length.GetPinnableReference());
        }

        public static unsafe void ShaderSource(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in char* @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // SpanOverloader
            thisApi.ShaderSource(shaderObj, count, in @string, in length.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix2(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix2(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix3(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix3(location, count, transpose, in value.GetPinnableReference());
        }

        public static unsafe void UniformMatrix4(this ArbShaderObjects thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.UniformMatrix4(location, count, transpose, in value.GetPinnableReference());
        }

    }
}

