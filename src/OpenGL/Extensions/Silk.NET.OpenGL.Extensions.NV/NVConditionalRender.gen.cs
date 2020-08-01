// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_conditional_render")]
    public unsafe partial class NVConditionalRender : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conditional_render";
        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glEndConditionalRenderNV")]
        public partial void EndConditionalRender();

        [NativeApi(EntryPoint = "glBeginConditionalRenderNV")]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        public NVConditionalRender(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

