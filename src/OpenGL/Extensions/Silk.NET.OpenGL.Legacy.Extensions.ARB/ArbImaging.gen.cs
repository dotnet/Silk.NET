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
        public partial void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glBlendEquation", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTable", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterf", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteri", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCopyColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorSubTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTable", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTable", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilter", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetHistogram", Convention = CallingConvention.Winapi)]
        public partial void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetHistogramParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetMinmax", Convention = CallingConvention.Winapi)]
        public partial void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameterfv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMinmaxParameteriv", Convention = CallingConvention.Winapi)]
        public partial void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilter", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glHistogram", Convention = CallingConvention.Winapi)]
        public partial void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        [NativeApi(EntryPoint = "glMinmax", Convention = CallingConvention.Winapi)]
        public partial void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] Boolean sink);

        [NativeApi(EntryPoint = "glResetHistogram", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glResetHistogram", Convention = CallingConvention.Winapi)]
        public partial void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target);

        [NativeApi(EntryPoint = "glResetMinmax", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(FlowDirection.In)] ARB target);

        [NativeApi(EntryPoint = "glResetMinmax", Convention = CallingConvention.Winapi)]
        public partial void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2D", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        public ArbImaging(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

