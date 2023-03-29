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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtMemoryObjectWin32Overloads
    {
        public static unsafe void ImportMemoryWin32Handle<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* handleSpp = handle)
                thisApi.ImportMemoryWin32Handle(memory, size, handleType, handleSpp);
        }

        public static unsafe void ImportMemoryWin32Name<T0>(this ExtMemoryObjectWin32 thisApi, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong size, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : struct
        {
            // SpanOverloader
            fixed (void* nameSpp = name)
                thisApi.ImportMemoryWin32Name(memory, size, handleType, nameSpp);
        }

    }
}

