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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_conditional_render")]
    public abstract unsafe partial class NvxConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_conditional_render";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNVX")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndConditionalRenderNVX")]
        public abstract void EndConditionalRender();

        public NvxConditionalRender(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

