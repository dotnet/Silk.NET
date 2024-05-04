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
    [Extension("EXT_memory_object")]
    public unsafe partial class ExtMemoryObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object";
        [NativeApi(EntryPoint = "glBufferStorageMemEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorageMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glBufferStorageMemEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorageMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateMemoryObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* memoryObjects);

        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public partial void CreateMemoryObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint memoryObjects);

        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteMemoryObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* memoryObjects);

        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteMemoryObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint memoryObjects);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryObjectParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryObjectParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

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

        [NativeApi(EntryPoint = "glIsMemoryObjectEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsMemoryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryObjectParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryObjectParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glNamedBufferStorageMemEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorageMem([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedSampleLocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong offset);

        public unsafe uint CreateMemoryObject()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateMemoryObjects(n, &ret);
            return ret;
        }

        public unsafe void DeleteMemoryObject([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObjects)
        {
            // ArrayParameterOverloader
            DeleteMemoryObjects(1, &memoryObjects);
        }

        public unsafe void DeleteMemoryObjects([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> memoryObjects)
        {
            // ImplicitCountSpanOverloader
            DeleteMemoryObjects((uint) memoryObjects.Length, in memoryObjects.GetPinnableReference());
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

        public unsafe uint CreateMemoryObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateMemoryObjects(n, out uint silkRet);
            return silkRet;
        }

        public unsafe int GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMemoryObjectParameter(memoryObject, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetMemoryObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint memoryObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryObjectParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetMemoryObjectParameter(memoryObject, pname, out int silkRet);
            return silkRet;
        }

        public unsafe byte GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetUnsignedByte(target, index, out byte silkRet);
            return silkRet;
        }

        public ExtMemoryObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

