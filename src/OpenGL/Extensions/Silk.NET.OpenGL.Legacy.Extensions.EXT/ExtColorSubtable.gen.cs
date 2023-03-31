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
    [Extension("EXT_color_subtable")]
    public unsafe partial class ExtColorSubtable : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_color_subtable";
        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorSubTableEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        public ExtColorSubtable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

