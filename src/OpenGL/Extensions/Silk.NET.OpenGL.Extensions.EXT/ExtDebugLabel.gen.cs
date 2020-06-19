// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_debug_label")]
    public abstract unsafe partial class ExtDebugLabel : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_label";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public abstract unsafe void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public abstract void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] Span<char> label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabelEXT")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="@object">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLabelObjectEXT")]
        public abstract void LabelObject([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint @object, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        public ExtDebugLabel(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

