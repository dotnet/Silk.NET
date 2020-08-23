// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_gl_spirv")]
    public unsafe partial class ArbGlSpirv : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_gl_spirv";
        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] in byte pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] in byte pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] in byte pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] in byte pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB")]
        public partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] in uint pConstantIndex, [Flow(FlowDirection.In)] in uint pConstantValue);

        public ArbGlSpirv(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

