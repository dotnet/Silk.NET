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
    [Extension("ARB_robustness")]
    public unsafe partial class ArbRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_robustness";
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusARB")]
        public partial ARB GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB")]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        public unsafe partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB")]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformfvARB")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvARB")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

