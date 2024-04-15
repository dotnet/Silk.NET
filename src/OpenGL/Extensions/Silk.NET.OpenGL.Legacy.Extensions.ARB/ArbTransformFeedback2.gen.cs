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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transform_feedback2")]
    public unsafe partial class ArbTransformFeedback2 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback2";
        [NativeApi(EntryPoint = "glBindTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void BindTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void BindTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] TransformFeedback* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void DeleteTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in TransformFeedback ids);

        [NativeApi(EntryPoint = "glDrawTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void DrawTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] TransformFeedback* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks", Convention = CallingConvention.Winapi)]
        public partial void GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out TransformFeedback ids);

        [NativeApi(EntryPoint = "glIsTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial bool IsTransformFeedback([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glPauseTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedback", Convention = CallingConvention.Winapi)]
        public partial void ResumeTransformFeedback();

        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        public unsafe void DeleteTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // ImplicitCountSpanOverloader
            DeleteTransformFeedbacks((uint) ids.Length, in ids.GetPinnableReference());
        }

        public unsafe void DeleteTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TransformFeedback> ids)
        {
            // ImplicitCountSpanOverloader
            DeleteTransformFeedbacks((uint) ids.Length, in ids.GetPinnableReference());
        }

        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe void GenTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // ImplicitCountSpanOverloader
            GenTransformFeedbacks((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe void GenTransformFeedbacks([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<TransformFeedback> ids)
        {
            // ImplicitCountSpanOverloader
            GenTransformFeedbacks((uint) ids.Length, out ids.GetPinnableReference());
        }

        public unsafe uint GenTransformFeedbacks([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenTransformFeedbacks(n, out uint silkRet);
            return silkRet;
        }

        public ArbTransformFeedback2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

