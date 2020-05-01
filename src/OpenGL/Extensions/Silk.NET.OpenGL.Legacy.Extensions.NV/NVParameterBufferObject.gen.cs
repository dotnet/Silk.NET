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
    [Extension("NV_parameter_buffer_object")]
    public abstract unsafe partial class NVParameterBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_parameter_buffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public abstract unsafe void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public abstract void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public abstract unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public abstract void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public abstract unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public abstract void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public abstract unsafe void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public abstract void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public abstract unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public abstract void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public abstract unsafe void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="bindingIndex">
        /// To be added.
        /// </param>
        /// <param name="wordIndex">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public abstract void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        public NVParameterBufferObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

