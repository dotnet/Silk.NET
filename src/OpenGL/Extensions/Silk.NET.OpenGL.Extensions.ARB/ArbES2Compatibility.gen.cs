// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_ES2_compatibility")]
    public unsafe partial class ArbES2Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES2_compatibility";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="d">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearDepth([Flow(FlowDirection.In)] float d)
            => ImplClearDepth(d);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f)
            => ImplDepthRange(n, f);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ARB shadertype, [Flow(FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReleaseShaderCompiler()
            => ImplReleaseShaderCompiler();

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length)
            => ImplShaderBinary(count, shaders, binaryformat, binary, length);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] ARB binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged
            => ImplShaderBinary<T0>(count, shaders, binaryformat, binary, length);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision)
            => ImplGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);

        public ArbES2Compatibility(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

