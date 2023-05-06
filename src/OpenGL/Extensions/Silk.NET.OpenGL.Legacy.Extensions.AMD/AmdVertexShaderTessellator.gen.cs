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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_vertex_shader_tessellator")]
    public unsafe partial class AmdVertexShaderTessellator : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_vertex_shader_tessellator";
        [NativeApi(EntryPoint = "glTessellationFactorAMD", Convention = CallingConvention.Winapi)]
        public partial void TessellationFactor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glTessellationModeAMD", Convention = CallingConvention.Winapi)]
        public partial void TessellationMode([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD mode);

        public AmdVertexShaderTessellator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

