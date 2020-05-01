// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_query_driver")]
    public abstract unsafe partial class MesaQueryDriver : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_query_driver";
        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig")]
        public abstract unsafe char* GetDisplayDriverConfig([Flow(FlowDirection.In)] IntPtr dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverName")]
        public abstract unsafe char* GetDisplayDriverName([Flow(FlowDirection.In)] IntPtr dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverConfig")]
        public abstract string GetDisplayDriverConfigS([Flow(FlowDirection.In)] IntPtr dpy);

        [NativeApi(EntryPoint = "eglGetDisplayDriverName")]
        public abstract string GetDisplayDriverNameS([Flow(FlowDirection.In)] IntPtr dpy);

        public unsafe char* GetDisplayDriverConfig([Flow(FlowDirection.In)] int dpy)
        {
            // IntPtrOverloader
            return GetDisplayDriverConfig(new IntPtr(dpy));
        }

        public unsafe char* GetDisplayDriverName([Flow(FlowDirection.In)] int dpy)
        {
            // IntPtrOverloader
            return GetDisplayDriverName(new IntPtr(dpy));
        }

        public unsafe string GetDisplayDriverConfigS([Flow(FlowDirection.In)] int dpy)
        {
            // IntPtrOverloader
            return GetDisplayDriverConfigS(new IntPtr(dpy));
        }

        public unsafe string GetDisplayDriverNameS([Flow(FlowDirection.In)] int dpy)
        {
            // IntPtrOverloader
            return GetDisplayDriverNameS(new IntPtr(dpy));
        }

        public MesaQueryDriver(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

