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

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    [Extension("ANGLE_translated_shader_source")]
    public unsafe partial class AngleTranslatedShaderSource : NativeExtension<GL>
    {
        public const string ExtensionName = "ANGLE_translated_shader_source";
        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTranslatedShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source);

        public AngleTranslatedShaderSource(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

