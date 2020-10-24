// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_texture_buffer_object")]
    public unsafe partial class ArbTextureBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_buffer_object";
        [NativeApi(EntryPoint = "glTexBufferARB")]
        public partial void TexBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferARB")]
        public partial void TexBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferARB")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferARB")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        public ArbTextureBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

