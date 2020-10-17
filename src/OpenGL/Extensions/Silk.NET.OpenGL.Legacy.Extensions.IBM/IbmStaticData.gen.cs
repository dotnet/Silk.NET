// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_static_data")]
    public unsafe partial class IbmStaticData : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_static_data";
        [NativeApi(EntryPoint = "glFlushStaticDataIBM")]
        public partial void FlushStaticData([Flow(FlowDirection.In)] IBM target);

        public IbmStaticData(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

