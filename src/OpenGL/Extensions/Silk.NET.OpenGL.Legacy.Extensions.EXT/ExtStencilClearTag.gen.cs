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
    [Extension("EXT_stencil_clear_tag")]
    public abstract unsafe partial class ExtStencilClearTag : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_stencil_clear_tag";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stencilTagBits">
        /// To be added.
        /// </param>
        /// <param name="stencilClearTag">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilClearTagEXT")]
        public abstract void StencilClearTag([Flow(FlowDirection.In)] uint stencilTagBits, [Flow(FlowDirection.In)] uint stencilClearTag);

        public ExtStencilClearTag(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

