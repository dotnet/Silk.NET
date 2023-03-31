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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_instanced_arrays")]
    public unsafe partial class NVInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        public NVInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

