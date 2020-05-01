// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public abstract unsafe partial class ExtSemaphore : NativeExtension<GL>
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
        public abstract unsafe void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores);

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
        public abstract void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> semaphores);

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
        public abstract unsafe void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

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
        public abstract void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores);

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
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params);

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
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

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
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

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
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

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
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

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
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSemaphoreEXT")]
        public abstract bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore);

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
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params);

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
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<ulong> @params);

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
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

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
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT dstLayouts);

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
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

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
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT srcLayouts);

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
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params);

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
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

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
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] string data);

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
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] string data);

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
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params);

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
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] Span<ulong> @params);

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
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

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
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout dstLayouts);

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
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

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

