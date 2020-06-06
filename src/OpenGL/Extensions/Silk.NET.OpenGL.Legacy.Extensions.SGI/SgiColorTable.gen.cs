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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    [Extension("SGI_color_table")]
    public unsafe partial class SgiColorTable : NativeExtension<GL>
    {
        public const string ExtensionName = "SGI_color_table";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table)
            => ImplColorTable(target, internalformat, width, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged
            => ImplColorTable<T0>(target, internalformat, width, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorTable(target, internalformat, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table)
            => ImplGetColorTable(target, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged
            => ImplGetColorTable<T0>(target, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table)
            => ImplColorTable(target, internalformat, width, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged
            => ImplColorTable<T0>(target, internalformat, width, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="x">
        /// To be added.
        /// </param>
        /// <param name="y">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorTable(target, internalformat, x, y, width);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table)
            => ImplGetColorTable(target, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="table">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged
            => ImplGetColorTable<T0>(target, format, type, table);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetColorTableParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetColorTableParameter(target, pname, @params);

        public SgiColorTable(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

