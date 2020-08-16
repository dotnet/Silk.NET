// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_clear_texture")]
    public unsafe partial class ExtClearTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_clear_texture";
        [NativeApi(EntryPoint = "glClearTexImageEXT")]
        public unsafe partial void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImageEXT")]
        public partial void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImageEXT")]
        public unsafe partial void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImageEXT")]
        public partial void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImageEXT")]
        public unsafe partial void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImageEXT")]
        public partial void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImageEXT")]
        public unsafe partial void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImageEXT")]
        public partial void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        public ExtClearTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

