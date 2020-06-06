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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_occlusion_query_event")]
    public unsafe partial class AmdOcclusionQueryEvent : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_occlusion_query_event";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueryObjectParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param)
            => ImplQueryObjectParameter(target, id, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueryObjectParameter([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param)
            => ImplQueryObjectParameter(target, id, pname, param);

        public AmdOcclusionQueryEvent(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

