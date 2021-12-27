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
        public partial void BindMultiTexture([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindMultiTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindMultiTexture([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindMultiTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindMultiTexture([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindMultiTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void BindMultiTexture([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatusEXT", Convention = CallingConvention.Winapi)]
        public partial EXT CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] nuint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void ClientAttribDefault([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void ClientAttribDefault([Flow(FlowDirection.In)] ClientAttribMask mask);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* bits);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 bits) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyMultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDisableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array);

        [NativeApi(EntryPoint = "glDisableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttribEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientState([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateiEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientState([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientStateIndexed([Flow(FlowDirection.In)] EXT array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableClientStateIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableClientStateIndexed([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT array);

        [NativeApi(EntryPoint = "glEnableVertexArrayEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EnableCap array);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttribEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glFramebufferDrawBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] DrawBufferMode mode);

        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* bufs);

        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in EXT bufs);

        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glFramebufferDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in DrawBufferMode bufs);

        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glFramebufferReadBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void FramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ReadBufferMode mode);

        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMultiTexMipmap([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMultiTexMipmap([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMultiTexMipmap([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenerateMultiTexMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateMultiTexMipmap([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target);

        [NativeApi(EntryPoint = "glGenerateTextureMipmapEXT", Convention = CallingConvention.Winapi)]
        public partial void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Computed = "target, lod"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetDoublei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetDoublei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetDoublei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetDoublei_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDoubleIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetDoubleIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoubleIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetDoubleIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloati_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFloati_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFloati_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFloati_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFloatIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFloatIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFloatIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexImage([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetMultiTexImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexImage<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexLevelParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetMultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramLocalParameterI([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] void* @string);

        [NativeApi(EntryPoint = "glGetNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramStringProperty pname, [Count(Computed = "program, pname"), Flow(FlowDirection.Out)] out T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] void** data);

        [NativeApi(EntryPoint = "glGetPointerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out void* data);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImageEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegervEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIntegeri_vEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayInteger([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** param);

        [NativeApi(EntryPoint = "glGetVertexArrayPointeri_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayPointer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* param);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMapNamedBufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT access);

        [NativeApi(EntryPoint = "glMapNamedBufferEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapNamedBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapNamedBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint length, [Flow(FlowDirection.In)] MapBufferAccessMask access);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixFrustumEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixFrustum([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoaddEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoad([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixLoadIdentityEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadIdentity([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixLoadTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixLoadTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultfEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultdEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMult([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in float m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] EXT mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMatrixMultTransposedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixMultTranspose([Flow(FlowDirection.In)] MatrixMode mode, [Count(Count = 16), Flow(FlowDirection.In)] in double m);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixOrthoEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixOrtho([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double left, [Flow(FlowDirection.In)] double right, [Flow(FlowDirection.In)] double bottom, [Flow(FlowDirection.In)] double top, [Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixPopEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPop([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glMatrixPushEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixPush([Flow(FlowDirection.In)] MatrixMode mode);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float angle, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixRotatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixRotate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double angle, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScalefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixScaledEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixScale([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatefEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMatrixTranslatedEXT", Convention = CallingConvention.Winapi)]
        public partial void MatrixTranslate([Flow(FlowDirection.In)] MatrixMode mode, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexBuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordPointer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordPointer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordPointer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexCoordPointer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnviEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexEnvivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexEnv([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureEnvTarget target, [Flow(FlowDirection.In)] TextureEnvParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glMultiTexGendvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexGenfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGeniEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexGenivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGen([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexGendEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexGend([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureCoordName coord, [Flow(FlowDirection.In)] TextureGenParameter pname, [Flow(FlowDirection.In)] double param);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameter([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glMultiTexParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexParameterI([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexRenderbuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexRenderbuffer([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexRenderbuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glMultiTexRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexRenderbuffer([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage1D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage2D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiTexSubImage3D([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glMultiTexSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void MultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] EXT usage);

        [NativeApi(EntryPoint = "glNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] EXT usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        [NativeApi(EntryPoint = "glNamedBufferDataEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glNamedBufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Computed = "size"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedCopyBufferSubDataEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedCopyBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] nint readOffset, [Flow(FlowDirection.In)] nint writeOffset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture1DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture1D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture2DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture2D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] EXT textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture3DEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture3D([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT face);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT face);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureFaceEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureFace([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] TextureTarget face);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayerEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameter4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameter4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4iEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameterI4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameterI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParameters4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glNamedProgramLocalParametersI4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedProgramString([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glNamedProgramStringEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glProgramUniform1fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform1ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1ivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform1uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform1dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glProgramUniform1dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform1dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniform2fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform2ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2ivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform2uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform2dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glProgramUniform2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniform3fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform3uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform3dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glProgramUniform3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniform4fEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4iEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform4ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4ivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform4uiEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uivEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform4dEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glProgramUniform4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in double value);

        [NativeApi(EntryPoint = "glPushClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void PushClientAttribDefault([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glPushClientAttribDefaultEXT", Convention = CallingConvention.Winapi)]
        public partial void PushClientAttribDefault([Flow(FlowDirection.In)] ClientAttribMask mask);

        [NativeApi(EntryPoint = "glTextureBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureBufferRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexturePageCommitmentEXT", Convention = CallingConvention.Winapi)]
        public partial void TexturePageCommitment([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool commit);

        [NativeApi(EntryPoint = "glTexturePageCommitmentEXT", Convention = CallingConvention.Winapi)]
        public partial void TexturePageCommitment([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean commit);

        [NativeApi(EntryPoint = "glTextureParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTextureParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTextureParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuivEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTextureRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glTextureRenderbufferEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureRenderbuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glTextureStorage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisampleEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] Boolean fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3DEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUnmapNamedBufferEXT", Convention = CallingConvention.Winapi)]
        public partial bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayBindVertexBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayBindVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayEdgeFlagOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayEdgeFlagOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayFogCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayFogCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] FogCoordinatePointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayIndexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayIndexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayMultiTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayMultiTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayNormalOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayNormalOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArraySecondaryColorOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArraySecondaryColorOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayTexCoordOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayTexCoordOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribBindingEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribDivisorEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribIOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribIOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLFormatEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribLOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexAttribOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexAttribOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexBindingDivisorEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glVertexArrayVertexOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexOffset([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] nint offset);

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage1D(texunit, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage2D(texunit, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexImage3D(texunit, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage1D(texunit, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage2D(texunit, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] EXT texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedMultiTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureUnit texunit, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedMultiTexSubImage3D(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage1D(texture, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage1D(texture, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage1D(texture, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage1D(texture, target, level, internalformat, width, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage2D(texture, target, level, internalformat, width, height, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureImage3D(texture, target, level, internalformat, width, height, depth, border, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, target, level, xoffset, width, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, target, level, xoffset, yoffset, width, height, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] ReadOnlySpan<T0> bits) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) (bits.Length * Unsafe.SizeOf<T0>()), in bits.GetPinnableReference());
        }

        public unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<EXT> bufs)
        {
            // ImplicitCountSpanOverloader
            FramebufferDrawBuffers(framebuffer, (uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public unsafe void FramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // ImplicitCountSpanOverloader
            FramebufferDrawBuffers(framebuffer, (uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferStorage(buffer, (nuint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferStorage(buffer, (nuint) (data.Length * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParameters4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramLocalParameters4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParameters4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParametersI4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParametersI4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParametersI4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramLocalParametersI4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // ImplicitCountSpanOverloader
            NamedProgramLocalParametersI4(program, target, index, (uint) @params.Length, in @params.GetPinnableReference());
        }

        public unsafe void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedProgramString(program, target, format, (uint) (@string.Length * Unsafe.SizeOf<T0>()), in @string.GetPinnableReference());
        }

        public unsafe void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ProgramFormat format, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedProgramString(program, target, format, (uint) (@string.Length * Unsafe.SizeOf<T0>()), in @string.GetPinnableReference());
        }

        public unsafe void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] EXT format, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedProgramString(program, target, format, (uint) (@string.Length * Unsafe.SizeOf<T0>()), in @string.GetPinnableReference());
        }

        public unsafe void NamedProgramString<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] ProgramFormat format, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedProgramString(program, target, format, (uint) (@string.Length * Unsafe.SizeOf<T0>()), in @string.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform1(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform2(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform3(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniform4(program, location, (uint) value.Length, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix2x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix3x4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x2(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public unsafe void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] Boolean transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<double> value)
        {
            // ImplicitCountSpanOverloader
            ProgramUniformMatrix4x3(program, location, (uint) value.Length, transpose, in value.GetPinnableReference());
        }

        public ExtDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

