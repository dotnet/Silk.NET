// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_light_texture")]
    public abstract unsafe partial class ExtLightTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_light_texture";
        [NativeApi(EntryPoint = "glApplyTextureEXT")]
        public abstract void ApplyTexture([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glTextureLightEXT")]
        public abstract void TextureLight([Flow(FlowDirection.In)] EXT pname);

        [NativeApi(EntryPoint = "glTextureMaterialEXT")]
        public abstract void TextureMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glApplyTextureEXT")]
        public abstract void ApplyTexture([Flow(FlowDirection.In)] LightTextureModeEXT mode);

        [NativeApi(EntryPoint = "glTextureLightEXT")]
        public abstract void TextureLight([Flow(FlowDirection.In)] LightTexturePNameEXT pname);

        [NativeApi(EntryPoint = "glTextureMaterialEXT")]
        public abstract void TextureMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter mode);

        public ExtLightTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

