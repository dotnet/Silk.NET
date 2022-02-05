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
        public unsafe partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source);

        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetTranslatedShaderSourceANGLE", Convention = CallingConvention.Winapi)]
        public partial void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source);

        public unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source)
        {
            // ImplicitCountSpanOverloader
            GetTranslatedShaderSource(shader, (uint) source.Length, length, out source.GetPinnableReference());
        }

        public unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // ImplicitCountSpanOverloader
            GetTranslatedShaderSource(shader, (uint) source.Length, length, out source.GetPinnableReference());
        }

        public unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source)
        {
            // ImplicitCountSpanOverloader
            GetTranslatedShaderSource(shader, (uint) source.Length, out length, out source.GetPinnableReference());
        }

        public unsafe void GetTranslatedShaderSource([Flow(FlowDirection.In)] uint shader, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> source)
        {
            // ImplicitCountSpanOverloader
            GetTranslatedShaderSource(shader, (uint) source.Length, out length, out source.GetPinnableReference());
        }

        public AngleTranslatedShaderSource(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

