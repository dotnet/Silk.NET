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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_convolution")]
    public unsafe partial class ExtConvolution : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_convolution";
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
        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image)
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
        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image)
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
        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glConvolutionParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image)
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
        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetSeparableFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSeparableFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span)
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
        [NativeApi(EntryPoint = "glGetSeparableFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetSeparableFilter<T0, T1, T2>(target, format, type, row, column, span);

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
        [NativeApi(EntryPoint = "glSeparableFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column)
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
        [NativeApi(EntryPoint = "glSeparableFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged
            => ImplSeparableFilter2D<T0, T1>(target, internalformat, width, height, format, type, row, column);

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
        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image)
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
        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image)
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
        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glConvolutionParameterfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
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
        [NativeApi(EntryPoint = "glConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width)
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
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
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
        /// <param name="image">
        /// To be added.
        /// This parameter's element count is computed from target, format, and type.
        /// </param>
        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image)
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
        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
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
        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetConvolutionParameter(target, pname, @params);

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
        [NativeApi(EntryPoint = "glGetSeparableFilterEXT")]
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
        [NativeApi(EntryPoint = "glGetSeparableFilterEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
            => ImplGetSeparableFilter<T0, T1, T2>(target, format, type, row, column, span);

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
        [NativeApi(EntryPoint = "glSeparableFilter2DEXT")]
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
        [NativeApi(EntryPoint = "glSeparableFilter2DEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged
            => ImplSeparableFilter2D<T0, T1>(target, internalformat, width, height, format, type, row, column);

        public ExtConvolution(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

