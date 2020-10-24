// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_transform_feedback")]
    public unsafe partial class ExtDrawTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_transform_feedback";
        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        public ExtDrawTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

