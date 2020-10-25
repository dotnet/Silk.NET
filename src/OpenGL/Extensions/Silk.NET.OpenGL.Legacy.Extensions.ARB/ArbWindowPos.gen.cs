// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_window_pos")]
    public unsafe partial class ArbWindowPos : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_window_pos";
        [NativeApi(EntryPoint = "glWindowPos2dARB")]
        public partial void WindowPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glWindowPos2dvARB")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos2dvARB")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glWindowPos2fARB")]
        public partial void WindowPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glWindowPos2fvARB")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos2fvARB")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glWindowPos2iARB")]
        public partial void WindowPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glWindowPos2ivARB")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos2ivARB")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glWindowPos2sARB")]
        public partial void WindowPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glWindowPos2svARB")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos2svARB")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glWindowPos3dARB")]
        public partial void WindowPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glWindowPos3dvARB")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos3dvARB")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glWindowPos3fARB")]
        public partial void WindowPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glWindowPos3fvARB")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos3fvARB")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glWindowPos3iARB")]
        public partial void WindowPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glWindowPos3ivARB")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos3ivARB")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glWindowPos3sARB")]
        public partial void WindowPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glWindowPos3svARB")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos3svARB")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        public ArbWindowPos(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

