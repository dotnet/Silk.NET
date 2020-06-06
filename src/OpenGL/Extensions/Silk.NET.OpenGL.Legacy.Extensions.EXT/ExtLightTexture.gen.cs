// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_light_texture")]
    public unsafe partial class ExtLightTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_light_texture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glApplyTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ApplyTexture([Flow(FlowDirection.In)] EXT mode)
            => ImplApplyTexture(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureLightEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureLight([Flow(FlowDirection.In)] EXT pname)
            => ImplTextureLight(pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureMaterialEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT mode)
            => ImplTextureMaterial(face, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glApplyTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ApplyTexture([Flow(FlowDirection.In)] LightTextureModeEXT mode)
            => ImplApplyTexture(mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureLightEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureLight([Flow(FlowDirection.In)] LightTexturePNameEXT pname)
            => ImplTextureLight(pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureMaterialEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] MaterialParameter mode)
            => ImplTextureMaterial(face, mode);

        public ExtLightTexture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

