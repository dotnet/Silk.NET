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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_direct_state_access")]
    public unsafe partial class ArbDirectStateAccess : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_direct_state_access";
        [NativeApi(EntryPoint = "glBindTextureUnit", Convention = CallingConvention.Winapi)]
        public partial void BindTextureUnit([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint unit, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearBufferMask mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB filter);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer", Convention = CallingConvention.Winapi)]
        public partial void BlitNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawFramebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearBufferMask mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckNamedFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus", Convention = CallingConvention.Winapi)]
        public partial ARB CheckNamedFramebufferStatus([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi", Convention = CallingConvention.Winapi)]
        public partial void ClearNamedFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferKind buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int drawbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompressedTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void CompressedTextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void CopyNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glCreateBuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint buffers);

        [NativeApi(EntryPoint = "glCreateBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Buffer* buffers);

        [NativeApi(EntryPoint = "glCreateBuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Buffer buffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glCreateProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines", Convention = CallingConvention.Winapi)]
        public partial void CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Query* ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Query ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Query* ids);

        [NativeApi(EntryPoint = "glCreateQueries", Convention = CallingConvention.Winapi)]
        public partial void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Query ids);

        [NativeApi(EntryPoint = "glCreateRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers", Convention = CallingConvention.Winapi)]
        public partial void CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glCreateSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glCreateSamplers", Convention = CallingConvention.Winapi)]
        public partial void CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint samplers);

        [NativeApi(EntryPoint = "glCreateSamplers", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Sampler* samplers);

        [NativeApi(EntryPoint = "glCreateSamplers", Convention = CallingConvention.Winapi)]
        public partial void CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Sampler samplers);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Texture* textures);

        [NativeApi(EntryPoint = "glCreateTextures", Convention = CallingConvention.Winapi)]
        public partial void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Texture textures);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TransformFeedback* ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TransformFeedback ids);

        [NativeApi(EntryPoint = "glCreateVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VertexArray arrays);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexArrayAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange", Convention = CallingConvention.Winapi)]
        public partial void FlushMappedNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glGenerateTextureMipmap", Convention = CallingConvention.Winapi)]
        public partial void GenerateTextureMipmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetCompressedTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage", Convention = CallingConvention.Winapi)]
        public partial void GetCompressedTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void GetNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetFramebufferParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetFramebufferParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryBufferObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v", Convention = CallingConvention.Winapi)]
        public partial void GetQueryBufferObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryObjectParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage", Convention = CallingConvention.Winapi)]
        public partial void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v", Convention = CallingConvention.Winapi)]
        public partial void GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv", Convention = CallingConvention.Winapi)]
        public partial void GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment* attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData", Convention = CallingConvention.Winapi)]
        public partial void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FramebufferAttachment attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMapNamedBuffer", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapNamedBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapBufferAccessMask access);

        [NativeApi(EntryPoint = "glNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage);

        [NativeApi(EntryPoint = "glNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferData", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferObjectUsage usage);

        [NativeApi(EntryPoint = "glNamedBufferData", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorage", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorage", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorage", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags);

        [NativeApi(EntryPoint = "glNamedBufferStorage", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedBufferSubData", Convention = CallingConvention.Winapi)]
        public partial void NamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferDrawBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferDrawBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBuffer buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBuffer* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorBuffer bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB src);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferReadBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorBuffer src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferRenderbuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferTextureLayer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureBuffer", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBuffer", Convention = CallingConvention.Winapi)]
        public partial void TextureBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TextureBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTextureParameterf", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterf", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float param);

        [NativeApi(EntryPoint = "glTextureParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float param);

        [NativeApi(EntryPoint = "glTextureParameteri", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteri", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glTextureParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int param);

        [NativeApi(EntryPoint = "glTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv", Convention = CallingConvention.Winapi)]
        public partial void TextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint @params);

        [NativeApi(EntryPoint = "glTextureStorage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage2DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint levels, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample", Convention = CallingConvention.Winapi)]
        public partial void TextureStorage3DMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SizedInternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public unsafe partial void TextureSubImage3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D", Convention = CallingConvention.Winapi)]
        public partial void TextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackBufferBase([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TransformFeedbackBufferRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glUnmapNamedBuffer", Convention = CallingConvention.Winapi)]
        public partial bool UnmapNamedBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayAttribBinding", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribBinding([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribIType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayAttribLFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attribindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribLType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayBindingDivisor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayElementBuffer", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayElementBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bindingindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers", Convention = CallingConvention.Winapi)]
        public partial void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Buffer buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides);

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, level, xoffset, width, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage1D(texture, level, xoffset, width, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void CompressedTextureSubImage3D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat format, [Count(Parameter = "imageSize"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        public unsafe void CreateBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> buffers)
        {
            // ImplicitCountSpanOverloader
            CreateBuffers((uint) buffers.Length, out buffers.GetPinnableReference());
        }

        public unsafe void CreateBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Buffer> buffers)
        {
            // ImplicitCountSpanOverloader
            CreateBuffers((uint) buffers.Length, out buffers.GetPinnableReference());
        }

        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        public unsafe void CreateFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> framebuffers)
        {
            // ImplicitCountSpanOverloader
            CreateFramebuffers((uint) framebuffers.Length, out framebuffers.GetPinnableReference());
        }

        public unsafe void CreateFramebuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Framebuffer> framebuffers)
        {
            // ImplicitCountSpanOverloader
            CreateFramebuffers((uint) framebuffers.Length, out framebuffers.GetPinnableReference());
        }

        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe void CreateProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pipelines)
        {
            // ImplicitCountSpanOverloader
            CreateProgramPipelines((uint) pipelines.Length, out pipelines.GetPinnableReference());
        }

        public unsafe void CreateProgramPipelines([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ProgramPipeline> pipelines)
        {
            // ImplicitCountSpanOverloader
            CreateProgramPipelines((uint) pipelines.Length, out pipelines.GetPinnableReference());
        }

        public unsafe uint CreateQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target)
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateQueries(target, n, &ret);
            return ret;
        }

        public unsafe void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            CreateQueries(target, (uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Query> ids)
        {
            // ImplicitCountSpanOverloader
            CreateQueries(target, (uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe uint CreateQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target)
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateQueries(target, n, &ret);
            return ret;
        }

        public unsafe void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            CreateQueries(target, (uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe void CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Query> ids)
        {
            // ImplicitCountSpanOverloader
            CreateQueries(target, (uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe void CreateRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            CreateRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public unsafe void CreateRenderbuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Renderbuffer> renderbuffers)
        {
            // ImplicitCountSpanOverloader
            CreateRenderbuffers((uint) renderbuffers.Length, out renderbuffers.GetPinnableReference());
        }

        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        public unsafe void CreateSamplers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> samplers)
        {
            // ImplicitCountSpanOverloader
            CreateSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public unsafe void CreateSamplers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Sampler> samplers)
        {
            // ImplicitCountSpanOverloader
            CreateSamplers((uint) samplers.Length, out samplers.GetPinnableReference());
        }

        public unsafe uint CreateTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target)
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTextures(target, n, &ret);
            return ret;
        }

        public unsafe void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures)
        {
            // ImplicitCountSpanOverloader
            CreateTextures(target, (uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            CreateTextures(target, (uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe uint CreateTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target)
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTextures(target, n, &ret);
            return ret;
        }

        public unsafe void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> textures)
        {
            // ImplicitCountSpanOverloader
            CreateTextures(target, (uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe void CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Texture> textures)
        {
            // ImplicitCountSpanOverloader
            CreateTextures(target, (uint) textures.Length, out textures.GetPinnableReference());
        }

        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe void CreateTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            CreateTransformFeedbacks((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe void CreateTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // ImplicitCountSpanOverloader
            CreateTransformFeedbacks((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void CreateVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> arrays)
        {
            // ImplicitCountSpanOverloader
            CreateVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe void CreateVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // ImplicitCountSpanOverloader
            CreateVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe void GetCompressedTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetCompressedTextureImage(texture, level, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetNamedBufferSubData(buffer, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureImage(texture, level, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureImage(texture, level, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureImage(texture, level, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetTextureImage(texture, level, format, type, (uint) ((pixels.Length) * Unsafe.SizeOf<T0>()), out pixels.GetPinnableReference());
        }

        public unsafe void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateNamedFramebufferData(framebuffer, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateNamedFramebufferData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferAttachment> attachments)
        {
            // ImplicitCountSpanOverloader
            InvalidateNamedFramebufferData(framebuffer, (uint) attachments.Length, in attachments.GetPinnableReference());
        }

        public unsafe void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateNamedFramebufferSubData(framebuffer, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public unsafe void InvalidateNamedFramebufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "numAttachments"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FramebufferAttachment> attachments, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height)
        {
            // ImplicitCountSpanOverloader
            InvalidateNamedFramebufferSubData(framebuffer, (uint) attachments.Length, in attachments.GetPinnableReference(), x, y, width, height);
        }

        public unsafe void NamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferData(buffer, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferData(buffer, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), usage);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferStorage(buffer, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferStorageMask flags) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferStorage(buffer, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference(), flags);
        }

        public unsafe void NamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Count(Parameter = "size"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            NamedBufferSubData(buffer, offset, (nuint) ((data.Length) * Unsafe.SizeOf<T0>()), in data.GetPinnableReference());
        }

        public unsafe void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> bufs)
        {
            // ImplicitCountSpanOverloader
            NamedFramebufferDrawBuffers(framebuffer, (uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public unsafe void NamedFramebufferDrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ColorBuffer> bufs)
        {
            // ImplicitCountSpanOverloader
            NamedFramebufferDrawBuffers(framebuffer, (uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, buffers, offsets, in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) offsets.Length, buffers, in offsets.GetPinnableReference(), strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, buffers, in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) buffers.Length, in buffers.GetPinnableReference(), offsets, strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, in buffers.GetPinnableReference(), offsets, in strides.GetPinnableReference());
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) offsets.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), strides);
        }

        public unsafe void VertexArrayVertexBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Buffer> buffers, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> offsets, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> strides)
        {
            // ImplicitCountSpanOverloader
            VertexArrayVertexBuffers(vaobj, first, (uint) strides.Length, in buffers.GetPinnableReference(), in offsets.GetPinnableReference(), in strides.GetPinnableReference());
        }

        public unsafe uint CreateBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateBuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateFramebuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateFramebuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateProgramPipelines([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateProgramPipelines(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateQueries(target, n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateQueries([Flow(Silk.NET.Core.Native.FlowDirection.In)] QueryTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateQueries(target, n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateRenderbuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateRenderbuffers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateSamplers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateSamplers(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateTextures(target, n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateTextures([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateTextures(target, n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateTransformFeedbacks(n, out uint silkRet);
            return silkRet;
        }

        public unsafe uint CreateVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            CreateVertexArrays(n, out uint silkRet);
            return silkRet;
        }

        public unsafe T0 GetCompressedTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetCompressedTextureImage(texture, level, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe int GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedBufferParameter(buffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedBufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedBufferParameter(buffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe void* GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedBufferPointer(buffer, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe void* GetNamedBufferPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferPointerNameARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedBufferPointer(buffer, pname, out void* silkRet);
            return silkRet;
        }

        public unsafe T0 GetNamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetNamedBufferSubData(buffer, offset, size, out T0 silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferAttachmentParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachment attachment, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferAttachmentParameter(framebuffer, attachment, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferParameter(framebuffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetFramebufferParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferParameter(framebuffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedRenderbufferParameter(renderbuffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetNamedRenderbufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint renderbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] RenderbufferParameterName pname)
        {
            // NonKhrReturnTypeOverloader
            GetNamedRenderbufferParameter(renderbuffer, pname, out int silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureImage(texture, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureImage(texture, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureImage(texture, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetTextureImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetTextureImage(texture, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureLevelParameter(texture, level, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetTextureLevelParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureLevelParameter(texture, level, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureParameter(texture, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetTextureParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureParameter(texture, pname, out float silkRet);
            return silkRet;
        }

        public unsafe int GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureParameterI(texture, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTextureParameterI([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetTextureParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetTextureParameterI(texture, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedback(xfb, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedback(xfb, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedback(xfb, pname, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedback(xfb, pname, index, out int silkRet);
            return silkRet;
        }

        public unsafe long GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedbacki64(xfb, pname, index, out long silkRet);
            return silkRet;
        }

        public unsafe long GetTransformFeedbacki64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint xfb, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedbackPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetTransformFeedbacki64(xfb, pname, index, out long silkRet);
            return silkRet;
        }

        public unsafe int GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArray(vaobj, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArray(vaobj, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArrayIndexed(vaobj, index, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetVertexArrayIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArrayIndexed(vaobj, index, pname, out int silkRet);
            return silkRet;
        }

        public unsafe long GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArrayIndexed64(vaobj, index, pname, out long silkRet);
            return silkRet;
        }

        public unsafe long GetVertexArrayIndexed64([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vaobj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArrayPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexArrayIndexed64(vaobj, index, pname, out long silkRet);
            return silkRet;
        }

        public ArbDirectStateAccess(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

