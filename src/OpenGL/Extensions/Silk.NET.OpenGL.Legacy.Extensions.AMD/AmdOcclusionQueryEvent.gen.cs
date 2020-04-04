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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_occlusion_query_event")]
    public abstract unsafe partial class AmdOcclusionQueryEvent : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD")]
        public abstract void QueryObjectParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glQueryObjectParameteruiAMD")]
        public abstract void QueryObjectParameter([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint param);

        public AmdOcclusionQueryEvent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

