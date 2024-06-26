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
    [Extension("EXT_window_rectangles")]
    public unsafe partial class ExtWindowRectangles : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_window_rectangles";
        [NativeApi(EntryPoint = "glWindowRectanglesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WindowRectangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* box);

        [NativeApi(EntryPoint = "glWindowRectanglesEXT", Convention = CallingConvention.Winapi)]
        public partial void WindowRectangles([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int box);

        public ExtWindowRectangles(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

