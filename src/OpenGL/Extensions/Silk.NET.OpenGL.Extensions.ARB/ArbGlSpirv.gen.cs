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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_gl_spirv")]
    public abstract unsafe partial class ArbGlSpirv : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] char* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] Span<char> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract unsafe void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public abstract void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        public ArbGlSpirv(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

