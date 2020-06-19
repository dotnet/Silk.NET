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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_conditional_render")]
    public abstract unsafe partial class NVConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conditional_render";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV mode);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glEndConditionalRenderNV")]
        public abstract void EndConditionalRender();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        public abstract void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        public NVConditionalRender(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

