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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.KHR
{
    [Extension("KHR_parallel_shader_compile")]
    public unsafe partial class KhrParallelShaderCompile : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_parallel_shader_compile";
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsKHR", Convention = CallingConvention.Winapi)]
        public partial void MaxShaderCompilerThreads([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        public KhrParallelShaderCompile(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

