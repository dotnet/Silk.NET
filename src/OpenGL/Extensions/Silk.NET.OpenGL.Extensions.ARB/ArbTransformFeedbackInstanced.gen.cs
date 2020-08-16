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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_transform_feedback_instanced")]
    public unsafe partial class ArbTransformFeedbackInstanced : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback_instanced";
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        public ArbTransformFeedbackInstanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

