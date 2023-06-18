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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback2")]
    public unsafe partial class NVTransformFeedback2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback2";
        [NativeApi(EntryPoint = "glBindTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void BindTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacksNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGenTransformFeedbacksNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glIsTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial bool IsTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glPauseTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedbackNV", Convention = CallingConvention.Winapi)]
        public partial void ResumeTransformFeedback();

        public NVTransformFeedback2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

