// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_query_driver")]
    public unsafe partial class MesaQueryDriver : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_query_driver";
        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig")]
        public unsafe partial byte* GetDisplayDriverConfig([Flow(FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig")]
        public partial string GetDisplayDriverConfigS([Flow(FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverName")]
        public unsafe partial byte* GetDisplayDriverName([Flow(FlowDirection.In)] nint dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverName")]
        public partial string GetDisplayDriverNameS([Flow(FlowDirection.In)] nint dpy);

        public MesaQueryDriver(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

