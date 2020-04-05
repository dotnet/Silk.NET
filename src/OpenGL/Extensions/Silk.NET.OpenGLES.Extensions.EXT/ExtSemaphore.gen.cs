// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public abstract unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public abstract unsafe void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public abstract void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> semaphores);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public abstract unsafe void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public abstract void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsSemaphoreEXT")]
        public abstract bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT dstLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT srcLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] string data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] string data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout dstLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout srcLayouts);

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
        public unsafe byte GetUnsignedByte([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        public ExtSemaphore(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

