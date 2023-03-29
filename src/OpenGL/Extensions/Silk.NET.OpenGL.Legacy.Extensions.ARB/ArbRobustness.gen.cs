// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_robustness")]
    public unsafe partial class ArbRobustness : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_robustness";
        [NativeApi(EntryPoint = "glGetGraphicsResetStatusARB", Convention = CallingConvention.Winapi)]
        public partial ARB GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        public unsafe double GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length / 8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length / 8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length / 8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length / 8, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe float GetnPixelMap([Flow(FlowDirection.In)] ARB map)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnPixelMap(map, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length / 4, out values.GetPinnableReference());
        }

        public unsafe float GetnPixelMap([Flow(FlowDirection.In)] PixelMap map)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnPixelMap(map, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length / 4, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ushort> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        public unsafe void GetnPolygonStipple([Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> pattern)
        {
            // ImplicitCountSpanOverloader
            GetnPolygonStipple((uint) pattern.Length, out pattern.GetPinnableReference());
        }

        public unsafe void GetnPolygonStipple([Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> pattern)
        {
            // ImplicitCountSpanOverloader
            GetnPolygonStipple((uint) pattern.Length, out pattern.GetPinnableReference());
        }

        public unsafe float GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnUniform(program, location, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length / 4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length / 4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length / 4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length / 8, out @params.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe float GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPixelMap(map, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe float GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPixelMap(map, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe byte GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPolygonStipple(bufSize, out byte silkRet);
            return silkRet;
        }

        public unsafe float GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnUniform(program, location, bufSize, out float silkRet);
            return silkRet;
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

