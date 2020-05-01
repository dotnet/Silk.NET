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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_gl_spirv")]
    public abstract unsafe partial class ArbGlSpirv : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_gl_spirv";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pEntryPoint">
        /// To be added.
        /// </param>
        /// <param name="numSpecializationConstants">
        /// To be added.
        /// </param>
        /// <param name="pConstantIndex">
        /// To be added.
        /// </param>
        /// <param name="pConstantValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] char* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pEntryPoint">
        /// To be added.
        /// </param>
        /// <param name="numSpecializationConstants">
        /// To be added.
        /// </param>
        /// <param name="pConstantIndex">
        /// To be added.
        /// </param>
        /// <param name="pConstantValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] Span<char> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pEntryPoint">
        /// To be added.
        /// </param>
        /// <param name="numSpecializationConstants">
        /// To be added.
        /// </param>
        /// <param name="pConstantIndex">
        /// To be added.
        /// </param>
        /// <param name="pConstantValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="pEntryPoint">
        /// To be added.
        /// </param>
        /// <param name="numSpecializationConstants">
        /// To be added.
        /// </param>
        /// <param name="pConstantIndex">
        /// To be added.
        /// </param>
        /// <param name="pConstantValue">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        public ArbGlSpirv(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

