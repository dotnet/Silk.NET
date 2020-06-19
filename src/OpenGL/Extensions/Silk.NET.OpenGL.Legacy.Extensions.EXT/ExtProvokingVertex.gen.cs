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
    [Extension("EXT_provoking_vertex")]
    public abstract unsafe partial class ExtProvokingVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_provoking_vertex";
        [NativeApi(EntryPoint = "glProvokingVertexEXT")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glProvokingVertexEXT")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode);

        public ExtProvokingVertex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

