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
    [Extension("NV_query_resource")]
    public abstract unsafe partial class NVQueryResource : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource";
        [NativeApi(EntryPoint = "glQueryResourceNV")]
        public abstract unsafe int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glQueryResourceNV")]
        public abstract int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> buffer);

        public NVQueryResource(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

