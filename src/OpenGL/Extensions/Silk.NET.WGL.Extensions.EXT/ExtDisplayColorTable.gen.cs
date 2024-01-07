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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.EXT
{
    [Extension("EXT_display_color_table")]
    public unsafe partial class ExtDisplayColorTable : NativeExtension<WGL>
    {
        public const string ExtensionName = "EXT_display_color_table";
        [NativeApi(EntryPoint = "wglBindDisplayColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial bool BindDisplayColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort id);

        [NativeApi(EntryPoint = "wglCreateDisplayColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial bool CreateDisplayColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort id);

        [NativeApi(EntryPoint = "wglDestroyDisplayColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyDisplayColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort id);

        [NativeApi(EntryPoint = "wglLoadDisplayColorTableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial bool LoadDisplayColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* table, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "wglLoadDisplayColorTableEXT", Convention = CallingConvention.Winapi)]
        public partial bool LoadDisplayColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort table, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        public ExtDisplayColorTable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

