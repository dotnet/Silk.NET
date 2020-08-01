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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_texture_buffer")]
    public unsafe partial class OesTextureBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_buffer";
        [NativeApi(EntryPoint = "glTexBufferOES")]
        public partial void TexBuffer([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRangeOES")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexBufferOES")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRangeOES")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public OesTextureBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

