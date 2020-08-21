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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_transform_feedback2")]
    public unsafe partial class NVTransformFeedback2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_transform_feedback2";
        [NativeApi(EntryPoint = "glBindTransformFeedbackNV")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedbackNV")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacksNV")]
        public unsafe partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacksNV")]
        public partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackNV")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackNV")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGenTransformFeedbacksNV")]
        public unsafe partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacksNV")]
        public partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glIsTransformFeedbackNV")]
        public partial bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glPauseTransformFeedbackNV")]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedbackNV")]
        public partial void ResumeTransformFeedback();

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

        public NVTransformFeedback2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

