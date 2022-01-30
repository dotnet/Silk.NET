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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    [Extension("SGI_color_table")]
    public unsafe partial class SgiColorTable : NativeExtension<GL>
    {
        public const string ExtensionName = "SGI_color_table";
        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public SgiColorTable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

