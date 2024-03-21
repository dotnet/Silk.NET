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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* semaphores);

        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public partial void GenSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data);

        [NativeApi(EntryPoint = "glIsSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* dstLayouts);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Texture* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureLayout* srcLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Texture textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TextureLayout srcLayouts);

        public unsafe void DeleteSemaphore([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphores)
        {
            // ArrayParameterOverloader
            DeleteSemaphores(1, &semaphores);
        }

        public unsafe void DeleteSemaphores([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> semaphores)
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

        public unsafe void GenSemaphores([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> semaphores)
        {
            // ImplicitCountSpanOverloader
            GenSemaphores((uint) semaphores.Length, out semaphores.GetPinnableReference());
        }

        public unsafe byte GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        public unsafe byte GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        public unsafe uint GenSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenSemaphores(n, out uint silkRet);
            return silkRet;
        }

        public unsafe ulong GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetSemaphoreParameter(semaphore, pname, out ulong silkRet);
            return silkRet;
        }

        public unsafe ulong GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SemaphoreParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetSemaphoreParameter(semaphore, pname, out ulong silkRet);
            return silkRet;
        }

        public unsafe byte GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetUnsignedByte(target, index, out byte silkRet);
            return silkRet;
        }

        public ExtSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

