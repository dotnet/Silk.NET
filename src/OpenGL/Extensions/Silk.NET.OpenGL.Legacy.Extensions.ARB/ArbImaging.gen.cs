// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_imaging")]
    public abstract unsafe partial class ArbImaging : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendColor")]
        public abstract void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] ARB mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorSubTable")]
        public abstract unsafe void ColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorSubTable")]
        public abstract void ColorSubTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTable")]
        public abstract unsafe void ColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTable")]
        public abstract void ColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        public abstract unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        public abstract void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        public abstract unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        public abstract void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterf")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        public abstract unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteri")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        public abstract unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyColorSubTable")]
        public abstract void CopyColorSubTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyColorTable")]
        public abstract void CopyColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D")]
        public abstract void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D")]
        public abstract void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTable")]
        public abstract unsafe void GetColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTable")]
        public abstract void GetColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        public abstract unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        public abstract void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        public abstract unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        public abstract void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        public abstract unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        public abstract void GetConvolutionParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogram")]
        public abstract unsafe void GetHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogram")]
        public abstract void GetHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmax")]
        public abstract unsafe void GetMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmax")]
        public abstract void GetMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        public abstract unsafe void GetSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        public abstract void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHistogram")]
        public abstract void Histogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMinmax")]
        public abstract void Minmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetHistogram")]
        public abstract void ResetHistogram([Flow(FlowDirection.In)] ARB target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetMinmax")]
        public abstract void ResetMinmax([Flow(FlowDirection.In)] ARB target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        public abstract unsafe void SeparableFilter2D([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        public abstract void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorSubTable")]
        public abstract unsafe void ColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorSubTable")]
        public abstract void ColorSubTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTable")]
        public abstract unsafe void ColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTable")]
        public abstract void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameterfv")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorTableParameteriv")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        public abstract unsafe void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter1D")]
        public abstract void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        public abstract unsafe void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionFilter2D")]
        public abstract void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterf")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        public abstract unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameterfv")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteri")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        public abstract unsafe void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glConvolutionParameteriv")]
        public abstract void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyColorSubTable")]
        public abstract void CopyColorSubTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyColorTable")]
        public abstract void CopyColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyConvolutionFilter1D")]
        public abstract void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyConvolutionFilter2D")]
        public abstract void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTable")]
        public abstract unsafe void GetColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTable")]
        public abstract void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameterfv")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetColorTableParameteriv")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        public abstract unsafe void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionFilter")]
        public abstract void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        public abstract unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameterfv")]
        public abstract void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        public abstract unsafe void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetConvolutionParameteriv")]
        public abstract void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogram")]
        public abstract unsafe void GetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogram")]
        public abstract void GetHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameterfv")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        public abstract unsafe void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHistogramParameteriv")]
        public abstract void GetHistogramParameter([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] GetHistogramParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmax")]
        public abstract unsafe void GetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* values);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmax")]
        public abstract void GetMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameterfv")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        public abstract unsafe void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetMinmaxParameteriv")]
        public abstract void GetMinmaxParameter([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] GetMinmaxParameterPNameEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        public abstract unsafe void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetSeparableFilter")]
        public abstract void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glHistogram")]
        public abstract void Histogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMinmax")]
        public abstract void Minmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] bool sink);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetHistogram")]
        public abstract void ResetHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glResetMinmax")]
        public abstract void ResetMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        public abstract unsafe void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSeparableFilter2D")]
        public abstract void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] ref T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] ref T1 column) where T0 : unmanaged where T1 : unmanaged;

        public ArbImaging(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

