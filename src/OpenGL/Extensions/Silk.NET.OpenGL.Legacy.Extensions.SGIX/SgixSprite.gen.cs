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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_sprite")]
    public unsafe partial class SgixSprite : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_sprite";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplSpriteParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplSpriteParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplSpriteParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameteriSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplSpriteParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplSpriteParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSpriteParameterivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SpriteParameter([Flow(FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplSpriteParameter(pname, @params);

        public SgixSprite(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

