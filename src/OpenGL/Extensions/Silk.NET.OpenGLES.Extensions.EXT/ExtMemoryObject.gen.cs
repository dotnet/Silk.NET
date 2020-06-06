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
    [Extension("EXT_memory_object")]
    public unsafe partial class ExtMemoryObject : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_memory_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferStorageMemEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferStorageMem([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplBufferStorageMem(target, size, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] uint* memoryObjects)
            => ImplCreateMemoryObjects(n, memoryObjects);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCreateMemoryObjectsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CreateMemoryObjects([Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.Out)] Span<uint> memoryObjects)
            => ImplCreateMemoryObjects(n, memoryObjects);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* memoryObjects)
            => ImplDeleteMemoryObjects(n, memoryObjects);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteMemoryObjectsEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteMemoryObjects([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> memoryObjects)
            => ImplDeleteMemoryObjects(n, memoryObjects);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetMemoryObjectParameter(memoryObject, pname, @params);

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
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsMemoryObjectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsMemoryObject([Flow(FlowDirection.In)] uint memoryObject)
            => ImplIsMemoryObject(memoryObject);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int* @params)
            => ImplMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] Span<int> @params)
            => ImplMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedBufferStorageMemEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedBufferStorageMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplNamedBufferStorageMem(buffer, size, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem2D(target, levels, internalFormat, width, height, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem2DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem2DMultisample(target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem3D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem3D(target, levels, internalFormat, width, height, depth, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem3DMultisample([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem3DMultisample(target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageMem2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageMem2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTextureStorageMem2D(texture, levels, internalFormat, width, height, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageMem2DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageMem2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTextureStorageMem2DMultisample(texture, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageMem3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageMem3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTextureStorageMem3D(texture, levels, internalFormat, width, height, depth, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureStorageMem3DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureStorageMem3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTextureStorageMem3DMultisample(texture, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferStorageMemEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferStorageMem([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplBufferStorageMem(target, size, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplGetMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplGetMemoryObjectParameter(memoryObject, pname, @params);

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
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] int* @params)
            => ImplMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="memoryObject">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMemoryObjectParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MemoryObjectParameter([Flow(FlowDirection.In)] uint memoryObject, [Flow(FlowDirection.In)] MemoryObjectParameterName pname, [Flow(FlowDirection.In)] Span<int> @params)
            => ImplMemoryObjectParameter(memoryObject, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem2D(target, levels, internalFormat, width, height, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem2DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem2DMultisample(target, samples, internalFormat, width, height, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="levels">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem3DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem3D(target, levels, internalFormat, width, height, depth, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="internalFormat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        /// <param name="fixedSampleLocations">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexStorageMem3DMultisampleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexStorageMem3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalFormat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedSampleLocations, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
            => ImplTexStorageMem3DMultisample(target, samples, internalFormat, width, height, depth, fixedSampleLocations, memory, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferStorageMem([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            BufferStorageMem(target, new UIntPtr(size), memory, offset);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint CreateMemoryObject()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateMemoryObjects(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="memoryObjects">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteMemoryObject([Count(Parameter = "n"), Flow(FlowDirection.In)] uint memoryObjects)
        {
            // ArrayParameterOverloader
            DeleteMemoryObjects(1, &memoryObjects);
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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedBufferStorageMem([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            NamedBufferStorageMem(buffer, new UIntPtr(size), memory, offset);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="memory">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferStorageMem([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint memory, [Flow(FlowDirection.In)] ulong offset)
        {
            // IntPtrOverloader
            BufferStorageMem(target, new UIntPtr(size), memory, offset);
        }

        public ExtMemoryObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

