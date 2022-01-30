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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* semaphores);

        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public partial void GenSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glIsSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsSemaphore([Flow(FlowDirection.In)] uint semaphore);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] in ulong @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] in ulong @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in uint buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] Buffer* buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(FlowDirection.In)] in Buffer buffers, [Flow(FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(FlowDirection.In)] in TextureLayout srcLayouts);

        public unsafe void DeleteSemaphore([Count(Parameter = "n"), Flow(FlowDirection.In)] uint semaphores)
        {
            // ArrayParameterOverloader
            DeleteSemaphores(1, &semaphores);
        }

        public unsafe void DeleteSemaphores([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> semaphores)
        {
            // ImplicitCountSpanOverloader
            DeleteSemaphores((uint) semaphores.Length, in semaphores.GetPinnableReference());
        }

        public unsafe uint GenSemaphore()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSemaphores(n, &ret);
            return ret;
        }

        public unsafe void GenSemaphores([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores)
        {
            // ImplicitCountSpanOverloader
            GenSemaphores((uint) semaphores.Length, out semaphores.GetPinnableReference());
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

