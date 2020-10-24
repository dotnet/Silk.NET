// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_query_resource")]
    public unsafe partial class NVQueryResource : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_query_resource";
        [NativeApi(EntryPoint = "glQueryResourceNV")]
        public unsafe partial int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* buffer);

        [NativeApi(EntryPoint = "glQueryResourceNV")]
        public partial int QueryResource([Flow(FlowDirection.In)] NV queryType, [Flow(FlowDirection.In)] int tagId, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int buffer);

        public NVQueryResource(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

