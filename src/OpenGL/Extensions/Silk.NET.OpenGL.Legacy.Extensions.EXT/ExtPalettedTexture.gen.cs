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
    [Extension("EXT_paletted_texture")]
    public unsafe partial class ExtPalettedTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_paletted_texture";
        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetColorTable(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
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

        public unsafe int GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableParameterPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetColorTableParameter(target, pname, out int silkRet);
            return silkRet;
        }

        public ExtPalettedTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

