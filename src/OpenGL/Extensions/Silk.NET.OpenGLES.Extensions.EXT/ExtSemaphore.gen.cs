// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores)
            => ImplDeleteSemaphores(n, semaphores);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> semaphores)
            => ImplDeleteSemaphores(n, semaphores);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores)
            => ImplGenSemaphores(n, semaphores);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores)
            => ImplGenSemaphores(n, semaphores);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params)
            => ImplGetSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
            => ImplGetSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data)
            => ImplGetUnsignedByte(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data)
            => ImplGetUnsignedByte(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data)
            => ImplGetUnsignedByte(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data)
            => ImplGetUnsignedByte(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore)
            => ImplIsSemaphore(semaphore);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params)
            => ImplSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<ulong> @params)
            => ImplSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="dstLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts)
            => ImplSignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="dstLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT dstLayouts)
            => ImplSignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="srcLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts)
            => ImplWaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="srcLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT srcLayouts)
            => ImplWaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params)
            => ImplGetSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
            => ImplGetSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] string data)
            => ImplGetUnsignedByte(pname, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] string data)
            => ImplGetUnsignedByte(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params)
            => ImplSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] Span<ulong> @params)
            => ImplSemaphoreParameter(semaphore, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="dstLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts)
            => ImplSignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="dstLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout dstLayouts)
            => ImplSignalSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="srcLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts)
            => ImplWaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="numBufferBarriers">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is computed from numBufferBarriers.
        /// </param>
        /// <param name="numTextureBarriers">
        /// To be added.
        /// </param>
        /// <param name="textures">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        /// <param name="srcLayouts">
        /// To be added.
        /// This parameter's element count is computed from numTextureBarriers.
        /// </param>
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout srcLayouts)
            => ImplWaitSemaphore(semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSemaphore([Count(Parameter = "n"), Flow(FlowDirection.In)] uint semaphores)
        {
            // ArrayParameterOverloader
            DeleteSemaphores(1, &semaphores);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="semaphores">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenSemaphore()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSemaphores(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe byte GetUnsignedByte([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        public ExtSemaphore(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

