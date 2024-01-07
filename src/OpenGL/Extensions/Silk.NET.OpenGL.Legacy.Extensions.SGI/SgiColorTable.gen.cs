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
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTargetSGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public SgiColorTable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

