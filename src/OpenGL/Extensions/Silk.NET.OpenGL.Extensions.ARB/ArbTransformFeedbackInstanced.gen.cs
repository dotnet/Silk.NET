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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_transform_feedback_instanced")]
    public unsafe partial class ArbTransformFeedbackInstanced : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback_instanced";
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount);

        public ArbTransformFeedbackInstanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

