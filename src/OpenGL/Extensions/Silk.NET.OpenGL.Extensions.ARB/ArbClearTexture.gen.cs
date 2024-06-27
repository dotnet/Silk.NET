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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_clear_texture")]
    public unsafe partial class ArbClearTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_clear_texture";
        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClearTexSubImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage", Convention = CallingConvention.Winapi)]
        public partial void ClearTexSubImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int xoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int yoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int zoffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormat format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        public ArbClearTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

