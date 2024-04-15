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

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    [Extension("IMG_bindless_texture")]
    public unsafe partial class ImgBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "IMG_bindless_texture";
        [NativeApi(EntryPoint = "glGetTextureHandleIMG", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleIMG", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureSamplerHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64IMG", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vIMG", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vIMG", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong values);

        [NativeApi(EntryPoint = "glUniformHandleui64IMG", Convention = CallingConvention.Winapi)]
        public partial void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vIMG", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformHandleui64vIMG", Convention = CallingConvention.Winapi)]
        public partial void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong value);

        public unsafe void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformHandle(program, location, (uint) values.Length, in values.GetPinnableReference());
        }

        public unsafe void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            UniformHandle(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public ImgBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

