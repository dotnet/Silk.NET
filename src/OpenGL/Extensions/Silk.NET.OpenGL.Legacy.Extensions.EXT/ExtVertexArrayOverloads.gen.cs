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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtVertexArrayOverloads
    {
        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        public static unsafe void EdgeFlagPointer(this ExtVertexArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<bool> pointer)
        {
            // SpanOverloader
            thisApi.EdgeFlagPointer(stride, count, in pointer.GetPinnableReference());
        }

    }
}

