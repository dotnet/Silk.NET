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
    [Extension("ARB_get_texture_sub_image")]
    public unsafe partial class ArbGetTextureSubImage : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_get_texture_sub_image";
        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public unsafe partial void GetCompressedTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public partial void GetCompressedTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        public ArbGetTextureSubImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

