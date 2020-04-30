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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_sprite")]
    public abstract unsafe partial class SgixSprite : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public abstract unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public abstract unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public abstract unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public abstract unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        public abstract void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public SgixSprite(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

