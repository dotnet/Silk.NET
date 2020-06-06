// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_geometry_shader")]
    public unsafe partial class ExtGeometryShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_geometry_shader";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture(target, attachment, texture, level);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="attachment">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="level">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferTextureEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level)
            => ImplFramebufferTexture(target, attachment, texture, level);

        public ExtGeometryShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

