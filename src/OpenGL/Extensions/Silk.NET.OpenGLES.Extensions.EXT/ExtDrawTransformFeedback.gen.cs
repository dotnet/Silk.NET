// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_transform_feedback")]
    public abstract unsafe partial class ExtDrawTransformFeedback : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_transform_feedback";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackEXT")]
        public abstract void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="instancecount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstancedEXT")]
        public abstract void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        public ExtDrawTransformFeedback(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

