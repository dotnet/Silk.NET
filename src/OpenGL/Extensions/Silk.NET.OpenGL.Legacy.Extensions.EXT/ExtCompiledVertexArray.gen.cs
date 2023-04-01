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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_compiled_vertex_array")]
    public unsafe partial class ExtCompiledVertexArray : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_compiled_vertex_array";
        [NativeApi(EntryPoint = "glLockArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void LockArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glUnlockArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void UnlockArrays();

        public ExtCompiledVertexArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

