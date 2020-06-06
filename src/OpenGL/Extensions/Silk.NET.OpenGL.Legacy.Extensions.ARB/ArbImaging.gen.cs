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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_imaging")]
    public unsafe partial class ArbImaging : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_imaging";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="red">
        /// To be added.
        /// </param>
        /// <param name="green">
        /// To be added.
        /// </param>
        /// <param name="blue">
        /// To be added.
        /// </param>
        /// <param name="alpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendColor")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha)
            => ImplBlendColor(red, green, blue, alpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] ARB mode)
            => ImplBlendEquation(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format, type, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data)
            => ImplColorSubTable(target, start, count, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format, type, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplColorSubTable<T0>(target, start, count, format, type, data);

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
        [NativeApi(EntryPoint = "glColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table)
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
        [NativeApi(EntryPoint = "glColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
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
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
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
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
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
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
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
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image)
            => ImplConvolutionFilter1D(target, internalformat, width, format, type, image);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
            => ImplConvolutionFilter1D<T0>(target, internalformat, width, format, type, image);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image)
            => ImplConvolutionFilter2D(target, internalformat, width, height, format, type, image);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
            => ImplConvolutionFilter2D<T0>(target, internalformat, width, height, format, type, image);

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
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
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
        [NativeApi(EntryPoint = "glCopyColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorSubTable(target, start, x, y, width);

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
        [NativeApi(EntryPoint = "glCopyColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorTable(target, internalformat, x, y, width);

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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyConvolutionFilter1D(target, internalformat, x, y, width);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyConvolutionFilter2D(target, internalformat, x, y, width, height);

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
        [NativeApi(EntryPoint = "glGetColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table)
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
        [NativeApi(EntryPoint = "glGetColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetColorTableParameter(target, pname, @params);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image)
            => ImplGetConvolutionFilter(target, format, type, image);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged
            => ImplGetConvolutionFilter<T0>(target, format, type, image);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetConvolutionParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetHistogram(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetHistogram<T0>(target, reset, format, type, values);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetMinmax(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetMinmax<T0>(target, reset, format, type, values);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span)
            => ImplGetSeparableFilter(target, format, type, row, column, span);

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
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetSeparableFilter<T0, T1, T2>(target, format, type, row, column, span);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplHistogram(target, width, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplMinmax(target, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetHistogram([Flow(FlowDirection.In)] ARB target)
            => ImplResetHistogram(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetMinmax([Flow(FlowDirection.In)] ARB target)
            => ImplResetMinmax(target);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and width.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and height.
        /// </param>
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column)
            => ImplSeparableFilter2D(target, internalformat, width, height, format, type, row, column);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and width.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and height.
        /// </param>
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged
            => ImplSeparableFilter2D<T0, T1>(target, internalformat, width, height, format, type, row, column);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquation")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode)
            => ImplBlendEquation(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format, type, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data)
            => ImplColorSubTable(target, start, count, format, type, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from format, type, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
            => ImplColorSubTable<T0>(target, start, count, format, type, data);

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
        [NativeApi(EntryPoint = "glColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table)
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
        [NativeApi(EntryPoint = "glColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
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
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
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
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
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
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
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
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image)
            => ImplConvolutionFilter1D(target, internalformat, width, format, type, image);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, and width.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
            => ImplConvolutionFilter1D<T0>(target, internalformat, width, format, type, image);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image)
            => ImplConvolutionFilter2D(target, internalformat, width, height, format, type, image);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from format, type, width, and height.
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
            => ImplConvolutionFilter2D<T0>(target, internalformat, width, height, format, type, image);

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
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        /// </param>
        [NativeApi(EntryPoint = "glConvolutionParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="start">
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
        [NativeApi(EntryPoint = "glCopyColorSubTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorSubTable(target, start, x, y, width);

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
        [NativeApi(EntryPoint = "glCopyColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyColorTable(target, internalformat, x, y, width);

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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
            => ImplCopyConvolutionFilter1D(target, internalformat, x, y, width);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplCopyConvolutionFilter2D(target, internalformat, x, y, width, height);

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
        [NativeApi(EntryPoint = "glGetColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table)
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
        [NativeApi(EntryPoint = "glGetColorTable")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetColorTableParameter(target, pname, @params);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image)
            => ImplGetConvolutionFilter(target, format, type, image);

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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged
            => ImplGetConvolutionFilter<T0>(target, format, type, image);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetConvolutionParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetHistogram(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetHistogram<T0>(target, reset, format, type, values);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetHistogramParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetHistogramParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values)
            => ImplGetMinmax(target, reset, format, type, values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="reset">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged
            => ImplGetMinmax<T0>(target, reset, format, type, values);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMinmaxParameter(target, pname, @params);

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
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span)
            => ImplGetSeparableFilter(target, format, type, row, column, span);

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
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        /// <param name="span">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetSeparableFilter<T0, T1, T2>(target, format, type, row, column, span);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplHistogram(target, width, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="sink">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink)
            => ImplMinmax(target, internalformat, sink);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetHistogram")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target)
            => ImplResetHistogram(target);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glResetMinmax")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target)
            => ImplResetMinmax(target);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and width.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and height.
        /// </param>
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column)
            => ImplSeparableFilter2D(target, internalformat, width, height, format, type, row, column);

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
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="row">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and width.
        /// </param>
        /// <param name="column">
        /// To be added.
        /// This parameter's element count is computed from target, format, type, and height.
        /// </param>
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged
            => ImplSeparableFilter2D<T0, T1>(target, internalformat, width, height, format, type, row, column);

        public ArbImaging(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

