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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_direct_state_access")]
    public unsafe partial class ExtDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_direct_state_access";
        [NativeApi(EntryPoint = "glBindMultiTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindMultiTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckNamedFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void ClientAttribDefault([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDisableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientState([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientStateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttribEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientState([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientStateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT array);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttribEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferDrawBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* bufs);

        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMultiTexMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateTextureMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedMultiTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetDoublei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDoubleIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetFloati_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloatIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabledIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMapNamedBufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT access);

        [NativeApi(EntryPoint = "glMapNamedBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double left, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double right, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bottom, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double top, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zNear, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double angle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT coord, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT usage);

        [NativeApi(EntryPoint = "glNamedBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedCopyBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedCopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT textarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureFace([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT face);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameters4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramString([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisampleCoverage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint coverageSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorSamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glProgramUniform1fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glProgramUniform1dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform2fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glProgramUniform2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform3fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glProgramUniform3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform4fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramUniform4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*6"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*8"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*12"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glPushClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void PushClientAttribDefault([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTextureBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int border, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexturePageCommitmentEXT", Convention = CallingConvention.Winapi)]
        public partial void TexturePageCommitment([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTextureParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTextureParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glTextureStorage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glUnmapNamedBufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool UnmapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayBindVertexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayBindVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayColorOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayEdgeFlagOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayEdgeFlagOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayFogCoordOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayIndexOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayMultiTexCoordOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT texunit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayNormalOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArraySecondaryColorOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayTexCoordOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribBindingEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribDivisorEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexBindingDivisorEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBindingDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        public ExtDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

