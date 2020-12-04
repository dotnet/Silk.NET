// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_tiled_rendering")]
    public unsafe partial class QComTiledRendering : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_tiled_rendering";
        [NativeApi(EntryPoint = "glEndTilingQCOM")]
        public partial void EndTiling([Flow(FlowDirection.In)] uint preserveMask);

        [NativeApi(EntryPoint = "glStartTilingQCOM")]
        public partial void StartTiling([Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint preserveMask);

        public QComTiledRendering(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

