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

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public abstract unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public abstract unsafe void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores);

        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public abstract void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public abstract unsafe void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public abstract void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract unsafe void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glIsSemaphoreEXT")]
        public abstract bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT srcLayouts);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract unsafe void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public abstract void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public abstract void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] string data);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract unsafe void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public abstract void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract unsafe void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public abstract void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract unsafe void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public abstract void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout srcLayouts);

        public unsafe void DeleteSemaphore([Count(Parameter = "n"), Flow(FlowDirection.In)] uint semaphores)
        {
            // ArrayParameterOverloader
            DeleteSemaphores(1, &semaphores);
        }

        public unsafe uint GenSemaphore()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSemaphores(n, &ret);
            return ret;
        }

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

