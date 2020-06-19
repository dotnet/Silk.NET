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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get2")]
    public abstract unsafe partial class QComExtendedGet2 : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get2";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from maxPrograms.
        /// </param>
        /// <param name="maxPrograms">
        /// To be added.
        /// </param>
        /// <param name="numPrograms">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramsQCOM")]
        public abstract unsafe void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] uint* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programs">
        /// To be added.
        /// This parameter's element count is taken from maxPrograms.
        /// </param>
        /// <param name="maxPrograms">
        /// To be added.
        /// </param>
        /// <param name="numPrograms">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramsQCOM")]
        public abstract void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public abstract unsafe void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] char* source, [Flow(FlowDirection.Out)] int* length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public abstract void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] Span<char> source, [Flow(FlowDirection.Out)] Span<int> length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from maxShaders.
        /// </param>
        /// <param name="maxShaders">
        /// To be added.
        /// </param>
        /// <param name="numShaders">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetShadersQCOM")]
        public abstract unsafe void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] uint* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from maxShaders.
        /// </param>
        /// <param name="maxShaders">
        /// To be added.
        /// </param>
        /// <param name="numShaders">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetShadersQCOM")]
        public abstract void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glExtIsProgramBinaryQCOM")]
        public abstract bool ExtIsProgramBinary([Flow(FlowDirection.In)] uint program);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public abstract unsafe void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] int* length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public abstract void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] Span<int> length);

        public QComExtendedGet2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

