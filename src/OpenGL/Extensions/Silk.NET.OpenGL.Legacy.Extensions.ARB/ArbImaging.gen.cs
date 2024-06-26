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
    [Extension("ARB_imaging")]
    public unsafe partial class ArbImaging : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_imaging";
        [NativeApi(EntryPoint = "glBlendColor", Convention = CallingConvention.Winapi)]
        public partial void BlendColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] float red, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float green, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float blue, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glBlendEquation", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glCopyColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glResetHistogram", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glResetHistogram", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target);

        [NativeApi(EntryPoint = "glResetMinmax", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glResetMinmax", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetHistogram(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetHistogramParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetHistogramParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetHistogramParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetMinmax(target, reset, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetMinmaxParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMinmaxParameterPNameEXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetMinmaxParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public ArbImaging(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

