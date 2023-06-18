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

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI", Convention = CallingConvention.Winapi)]
        public partial void CopyColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetColorTableParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        public SgiColorTable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

