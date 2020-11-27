// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transform_feedback2")]
    public unsafe partial class ArbTransformFeedback2 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transform_feedback2";
        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public unsafe partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public unsafe partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public partial bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
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

        public ArbTransformFeedback2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

