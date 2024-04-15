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
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter1D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image);

        [NativeApi(EntryPoint = "glConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameteriEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void ConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter1DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter1D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyConvolutionFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void CopyConvolutionFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetConvolutionFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetConvolutionParameterivEXT", Convention = CallingConvention.Winapi)]
        public partial void GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* span) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glGetSeparableFilterEXT", Convention = CallingConvention.Winapi)]
        public partial void GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T2 span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column);

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SeparableFilter2D<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* column) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSeparableFilter2DEXT", Convention = CallingConvention.Winapi)]
        public partial void SeparableFilter2D<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type, width"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 row, [Count(Computed = "target, format, type, height"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T1 column) where T0 : unmanaged where T1 : unmanaged;

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe T0 GetConvolutionFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionFilter(target, format, type, out T0 silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetConvolutionParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ConvolutionParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetConvolutionParameter(target, pname, out float silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public unsafe T0 GetSeparableFilter<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, column, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, row, out column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T1 GetSeparableFilter<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* column) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, column, out T1 silkRet);
            return silkRet;
        }

        public unsafe T2 GetSeparableFilter<T0, T1, T2>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SeparableTargetEXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 row, [Count(Computed = "target, format, type"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 column) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            GetSeparableFilter(target, format, type, out row, out column, out T2 silkRet);
            return silkRet;
        }

        public ExtConvolution(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

