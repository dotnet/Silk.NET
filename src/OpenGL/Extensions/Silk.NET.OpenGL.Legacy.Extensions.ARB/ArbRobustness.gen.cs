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
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnColorTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTableARB", Convention = CallingConvention.Winapi)]
        public partial void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnCompressedTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnCompressedTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnHistogram([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogramARB", Convention = CallingConvention.Winapi)]
        public partial void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int v);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnMinmax([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmaxARB", Convention = CallingConvention.Winapi)]
        public partial void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort values);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnPolygonStipple([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPolygonStipple([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStippleARB", Convention = CallingConvention.Winapi)]
        public partial void GetnPolygonStipple([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetnSeparableFilterARB", Convention = CallingConvention.Winapi)]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetnTexImageARB", Convention = CallingConvention.Winapi)]
        public partial void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuivARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReadnPixels([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixelsARB", Convention = CallingConvention.Winapi)]
        public partial void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> table) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnColorTable(target, format, type, (uint) ((table.Length) * Unsafe.SizeOf<T0>()), out table.GetPinnableReference());
        }

        public unsafe void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnCompressedTexImage(target, lod, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> image) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnConvolutionFilter(target, format, type, (uint) ((image.Length) * Unsafe.SizeOf<T0>()), out image.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnHistogram(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length*8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length*8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length*8, out v.GetPinnableReference());
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            double ret = default;
            GetnMap(target, query, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length*8, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> v)
        {
            // ImplicitCountSpanOverloader
            GetnMap(target, query, (uint) v.Length, out v.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe void GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> values) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnMinmax(target, reset, format, type, (uint) ((values.Length) * Unsafe.SizeOf<T0>()), out values.GetPinnableReference());
        }

        public unsafe float GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnPixelMap(map, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length*4, out values.GetPinnableReference());
        }

        public unsafe float GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnPixelMap(map, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length*4, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> values)
        {
            // ImplicitCountSpanOverloader
            GetnPixelMap(map, (uint) values.Length, out values.GetPinnableReference());
        }

        public unsafe void GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> values)
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

        public unsafe void GetnPolygonStipple([Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> pattern)
        {
            // ImplicitCountSpanOverloader
            GetnPolygonStipple((uint) pattern.Length, out pattern.GetPinnableReference());
        }

        public unsafe void GetnPolygonStipple([Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> pattern)
        {
            // ImplicitCountSpanOverloader
            GetnPolygonStipple((uint) pattern.Length, out pattern.GetPinnableReference());
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, (uint) ((column.Length) * Unsafe.SizeOf<T0>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), columnBufSize, column, out span);
        }

        public unsafe void GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), span);
        }

        public unsafe void GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnSeparableFilter(target, format, type, (uint) ((row.Length) * Unsafe.SizeOf<T0>()), out row.GetPinnableReference(), (uint) ((column.Length) * Unsafe.SizeOf<T1>()), out column.GetPinnableReference(), out span);
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe void GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> img) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            GetnTexImage(target, level, format, type, (uint) ((img.Length) * Unsafe.SizeOf<T0>()), out img.GetPinnableReference());
        }

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetnUniform(program, location, bufSize, &ret);
            return ret;
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 4"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*4, out @params.GetPinnableReference());
        }

        public unsafe void GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "bufSize", Expression = " / 8"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> @params)
        {
            // ImplicitCountSpanOverloader
            GetnUniform(program, location, (uint) @params.Length*8, out @params.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe void ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            ReadnPixels(x, y, width, height, format, type, (uint) ((data.Length) * Unsafe.SizeOf<T0>()), out data.GetPinnableReference());
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnColorTable<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorTableTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnColorTable(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnCompressedTexImage(target, lod, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnCompressedTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int lod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnCompressedTexImage(target, lod, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnConvolutionFilter(target, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnHistogram<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] HistogramTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnHistogram(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe double GetnMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapQuery query, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnMap(target, query, bufSize, out double silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnMinmax<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] MinmaxTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool reset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnMinmax(target, reset, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPixelMap(map, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe float GetnPixelMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelMap map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPixelMap(map, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe byte GetnPolygonStipple([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnPolygonStipple(bufSize, out byte silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, out row, columnBufSize, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetnTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnTexImage(target, level, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetnUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize)
        {
            // NonKhrReturnTypeOverloader
            GetnUniform(program, location, bufSize, out float silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 ReadnPixels<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            ReadnPixels(x, y, width, height, format, type, bufSize, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint rowBufSize, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, rowBufSize, row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetnSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint columnBufSize, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, columnBufSize, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetnSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Parameter = "rowBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> row, [Count(Parameter = "columnBufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetnSeparableFilter(target, format, type, row, column, out T2 silkRet);
            return silkRet;
        }

        public ArbRobustness(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

