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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_texture_view")]
    public abstract unsafe partial class ArbTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_view";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="origtexture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="minlevel">
        /// To be added.
        /// </param>
        /// <param name="numlevels">
        /// To be added.
        /// </param>
        /// <param name="minlayer">
        /// To be added.
        /// </param>
        /// <param name="numlayers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="origtexture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="minlevel">
        /// To be added.
        /// </param>
        /// <param name="numlevels">
        /// To be added.
        /// </param>
        /// <param name="minlayer">
        /// To be added.
        /// </param>
        /// <param name="numlayers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureView")]
        public abstract void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        public ArbTextureView(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

