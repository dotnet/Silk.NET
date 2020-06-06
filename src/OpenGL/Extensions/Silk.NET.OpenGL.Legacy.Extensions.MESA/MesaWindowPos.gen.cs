// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.MESA
{
    [Extension("MESA_window_pos")]
    public unsafe partial class MesaWindowPos : NativeExtension<GL>
    {
        public const string ExtensionName = "MESA_window_pos";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2dMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y)
            => ImplWindowPos2(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2fMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y)
            => ImplWindowPos2(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2iMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y)
            => ImplWindowPos2(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2sMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y)
            => ImplWindowPos2(x, y);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos2svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v)
            => ImplWindowPos2(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3dMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z)
            => ImplWindowPos3(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3fMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z)
            => ImplWindowPos3(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3iMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z)
            => ImplWindowPos3(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3sMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z)
            => ImplWindowPos3(x, y, z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos3svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplWindowPos3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4dMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w)
            => ImplWindowPos4(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] double* v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4dvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<double> v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4fMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w)
            => ImplWindowPos4(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] float* v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4fvMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<float> v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4iMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w)
            => ImplWindowPos4(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] int* v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4ivMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<int> v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="z">
        /// To be added.
        /// </param>
        /// <param name="w">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4sMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w)
            => ImplWindowPos4(x, y, z, w);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] short* v)
            => ImplWindowPos4(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glWindowPos4svMESA")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowPos4([Count(Count = 4), Flow(FlowDirection.In)] Span<short> v)
            => ImplWindowPos4(v);

        public MesaWindowPos(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

