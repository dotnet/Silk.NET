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
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double v);

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
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float values);

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
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] out T0 row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) (table.Length * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) (image.Length * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
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

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] Boolean reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) (values.Length * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] ARB map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
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

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) (column.Length * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] void* column, [Count(Count = 0), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) (row.Length * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) (column.Length * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) (img.Length * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) (data.Length * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

