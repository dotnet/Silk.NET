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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_ES2_compatibility")]
    public abstract unsafe partial class ArbES2Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES2_compatibility";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="d">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthf")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] float d);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="f">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthRangef")]
        public abstract void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public abstract void ReleaseShaderCompiler();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="binaryformat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="shaders">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="binaryformat">
        /// To be added.
        /// </param>
        /// <param name="binary">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderBinary")]
        public abstract void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shadertype">
        /// To be added.
        /// </param>
        /// <param name="precisiontype">
        /// To be added.
        /// </param>
        /// <param name="range">
        /// To be added.
        /// This parameter contains 2 elements.
        /// </param>
        /// <param name="precision">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public abstract void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        public ArbES2Compatibility(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

