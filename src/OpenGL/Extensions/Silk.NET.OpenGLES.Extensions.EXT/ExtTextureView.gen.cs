// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_view")]
    public unsafe partial class ExtTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_view";
        [NativeApi(EntryPoint = "glTextureViewEXT")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glTextureViewEXT")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        public ExtTextureView(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

