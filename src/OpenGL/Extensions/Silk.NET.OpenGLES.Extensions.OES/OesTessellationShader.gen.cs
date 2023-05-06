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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_tessellation_shader")]
    public unsafe partial class OesTessellationShader : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_tessellation_shader";
        [NativeApi(EntryPoint = "glPatchParameteriOES", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameteriOES", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PatchParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        public OesTessellationShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

