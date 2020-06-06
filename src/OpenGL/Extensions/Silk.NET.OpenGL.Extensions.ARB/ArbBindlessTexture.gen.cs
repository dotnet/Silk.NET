// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_bindless_texture")]
    public unsafe partial class ArbBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_bindless_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB format)
            => ImplGetImageHandle(texture, level, layered, layer, format);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetTextureHandleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture)
            => ImplGetTextureHandle(texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetTextureSamplerHandleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler)
            => ImplGetTextureSamplerHandle(texture, sampler);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] ulong* @params)
            => ImplGetVertexAttribL(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
            => ImplGetVertexAttribL(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsImageHandleResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle)
            => ImplIsImageHandleResident(handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsTextureHandleResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle)
            => ImplIsTextureHandleResident(handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle)
            => ImplMakeImageHandleNonResident(handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMakeImageHandleResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] ARB access)
            => ImplMakeImageHandleResident(handle, access);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle)
            => ImplMakeTextureHandleNonResident(handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMakeTextureHandleResidentARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle)
            => ImplMakeTextureHandleResident(handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformHandleui64ARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value)
            => ImplProgramUniformHandle(program, location, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values)
            => ImplProgramUniformHandle(program, location, count, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values)
            => ImplProgramUniformHandle(program, location, count, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniformHandleui64ARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value)
            => ImplUniformHandle(location, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value)
            => ImplUniformHandle(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value)
            => ImplUniformHandle(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribL1ui64ARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x)
            => ImplVertexAttribL1(index, x);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong* v)
            => ImplVertexAttribL1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<ulong> v)
            => ImplVertexAttribL1(index, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        /// <param name="layered">
        /// To be added.
        /// </param>
        /// <param name="layer">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format)
            => ImplGetImageHandle(texture, level, layered, layer, format);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] ulong* @params)
            => ImplGetVertexAttribL(index, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
            => ImplGetVertexAttribL(index, pname, @params);

        public ArbBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

