// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public unsafe partial void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores);

        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT")]
        public partial void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public unsafe partial void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT")]
        public partial void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public unsafe partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public unsafe partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glIsSemaphoreEXT")]
        public partial bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref EXT srcLayouts);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT")]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT")]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT")]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] string data);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT")]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT")]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT")]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] ref uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] ref TextureLayout srcLayouts);

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

        public ExtSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

