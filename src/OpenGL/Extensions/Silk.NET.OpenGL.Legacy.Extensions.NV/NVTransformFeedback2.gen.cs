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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback2")]
    public abstract unsafe partial class NVTransformFeedback2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback2";
        [NativeApi(EntryPoint = "glBindTransformFeedbackNV")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacksNV")]
        public abstract unsafe void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacksNV")]
        public abstract void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackNV")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGenTransformFeedbacksNV")]
        public abstract unsafe void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacksNV")]
        public abstract void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glIsTransformFeedbackNV")]
        public abstract bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glPauseTransformFeedbackNV")]
        public abstract void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedbackNV")]
        public abstract void ResumeTransformFeedback();

        [NativeApi(EntryPoint = "glBindTransformFeedbackNV")]
        public abstract void BindTransformFeedback([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackNV")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public NVTransformFeedback2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

