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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtMemoryObjectWin32Overloads
    {
        public static unsafe void ImportMemoryWin32Handle<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportMemoryWin32Handle(memory, size, handleType, out handle.GetPinnableReference());
        }

        public static unsafe void ImportMemoryWin32Handle<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportMemoryWin32Handle(memory, size, handleType, out handle.GetPinnableReference());
        }

        public static unsafe void ImportMemoryWin32Name<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] ReadOnlySpan<T0> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportMemoryWin32Name(memory, size, handleType, in name.GetPinnableReference());
        }

        public static unsafe void ImportMemoryWin32Name<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] ReadOnlySpan<T0> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.ImportMemoryWin32Name(memory, size, handleType, in name.GetPinnableReference());
        }

    }
}

