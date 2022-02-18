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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_convolution")]
    public unsafe partial class ExtConvolution : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_convolution";
        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Flow(FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(FlowDirection.In)] ConvolutionTargetEXT target, [Flow(FlowDirection.In)] ConvolutionParameterEXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(FlowDirection.In)] in T0 row, [Count(Computed = "target, format, type, height"), Flow(FlowDirection.In)] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        public ExtConvolution(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

