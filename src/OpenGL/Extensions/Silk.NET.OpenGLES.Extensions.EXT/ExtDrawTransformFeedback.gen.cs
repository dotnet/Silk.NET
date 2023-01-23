// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_transform_feedback")]
    public unsafe partial class ExtDrawTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_transform_feedback";
        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        public ExtDrawTransformFeedback(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

