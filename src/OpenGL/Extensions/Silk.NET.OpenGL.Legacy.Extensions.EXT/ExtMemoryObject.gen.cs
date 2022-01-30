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
        public partial void BufferStorageMem([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glBufferStorageMemEXT", Convention = CallingConvention.Winapi)]
        public partial void BufferStorageMem([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] uint* memoryObjects);

        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public partial void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] out uint memoryObjects);

        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* memoryObjects);

        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT", Convention = CallingConvention.Winapi)]
        public partial void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint memoryObjects);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] out int @params);

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

        [NativeApi(EntryPoint = "glIsMemoryObjectEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsMemoryObject([Flow(FlowDirection.In)] uint memoryObject);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glNamedBufferStorageMemEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorageMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset);

        public unsafe uint CreateMemoryObject()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateMemoryObjects(n, &ret);
            return ret;
        }

        public unsafe void DeleteMemoryObject([Count(Parameter = "n"), Flow(FlowDirection.In)] uint memoryObjects)
        {
            // ArrayParameterOverloader
            DeleteMemoryObjects(1, &memoryObjects);
        }

        public unsafe void DeleteMemoryObjects([Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> memoryObjects)
        {
            // ImplicitCountSpanOverloader
            DeleteMemoryObjects((uint) memoryObjects.Length, in memoryObjects.GetPinnableReference());
        }

        public unsafe byte GetUnsignedByte([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            byte ret = default;
            GetUnsignedByte(pname, &ret);
            return ret;
        }

        public ExtMemoryObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

