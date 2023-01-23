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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_bindless_texture")]
    public unsafe partial class NVBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_bindless_texture";
        [NativeApi(EntryPoint = "glGetImageHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] NV format);

        [NativeApi(EntryPoint = "glGetImageHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        [NativeApi(EntryPoint = "glGetImageHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] NV format);

        [NativeApi(EntryPoint = "glGetImageHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        [NativeApi(EntryPoint = "glGetTextureHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleNV", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glIsImageHandleResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glIsTextureHandleResidentNV", Convention = CallingConvention.Winapi)]
        public partial bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeTextureHandleResidentNV", Convention = CallingConvention.Winapi)]
        public partial void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64NV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vNV", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong values);

        [NativeApi(EntryPoint = "glUniformHandleui64NV", Convention = CallingConvention.Winapi)]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformHandleui64vNV", Convention = CallingConvention.Winapi)]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        public unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformHandle(program, location, (uint) values.Length, in values.GetPinnableReference());
        }

        public unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // ImplicitCountSpanOverloader
            UniformHandle(location, (uint) value.Length, in value.GetPinnableReference());
        }

        public NVBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

