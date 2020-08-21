// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_window_pos")]
    public unsafe partial class MesaWindowPos : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_window_pos";
        [NativeApi(EntryPoint = "glWindowPos2dMESA")]
        public partial void WindowPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glWindowPos2dvMESA")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos2dvMESA")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glWindowPos2fMESA")]
        public partial void WindowPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glWindowPos2fvMESA")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos2fvMESA")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glWindowPos2iMESA")]
        public partial void WindowPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glWindowPos2ivMESA")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos2ivMESA")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glWindowPos2sMESA")]
        public partial void WindowPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glWindowPos2svMESA")]
        public unsafe partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos2svMESA")]
        public partial void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glWindowPos3dMESA")]
        public partial void WindowPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glWindowPos3dvMESA")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos3dvMESA")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glWindowPos3fMESA")]
        public partial void WindowPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glWindowPos3fvMESA")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos3fvMESA")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glWindowPos3iMESA")]
        public partial void WindowPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glWindowPos3ivMESA")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos3ivMESA")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glWindowPos3sMESA")]
        public partial void WindowPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glWindowPos3svMESA")]
        public unsafe partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos3svMESA")]
        public partial void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glWindowPos4dMESA")]
        public partial void WindowPos4([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glWindowPos4dvMESA")]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glWindowPos4dvMESA")]
        public partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glWindowPos4fMESA")]
        public partial void WindowPos4([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glWindowPos4fvMESA")]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glWindowPos4fvMESA")]
        public partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glWindowPos4iMESA")]
        public partial void WindowPos4([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glWindowPos4ivMESA")]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glWindowPos4ivMESA")]
        public partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glWindowPos4sMESA")]
        public partial void WindowPos4([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glWindowPos4svMESA")]
        public unsafe partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glWindowPos4svMESA")]
        public partial void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] in short v);

        public MesaWindowPos(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

