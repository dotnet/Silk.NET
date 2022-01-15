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
    [Extension("EXT_light_texture")]
    public unsafe partial class ExtLightTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_light_texture";
        [NativeApi(EntryPoint = "glApplyTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void ApplyTexture([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glApplyTextureEXT", Convention = CallingConvention.Winapi)]
        public partial void ApplyTexture([Flow(FlowDirection.In)] LightTextureModeEXT mode);

        [NativeApi(EntryPoint = "glTextureLightEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureLight([Flow(FlowDirection.In)] EXT pname);

        [NativeApi(EntryPoint = "glTextureLightEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureLight([Flow(FlowDirection.In)] LightTexturePNameEXT pname);

        [NativeApi(EntryPoint = "glTextureMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glTextureMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glTextureMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glTextureMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void TextureMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter mode);

        public ExtLightTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

