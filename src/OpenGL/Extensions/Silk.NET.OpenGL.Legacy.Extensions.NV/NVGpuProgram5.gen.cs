// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_gpu_program5")]
    public unsafe partial class NVGpuProgram5 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_program5";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] uint* param)
            => ImplGetProgramSubroutineParameter(target, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out uint param)
            => ImplGetProgramSubroutineParameter(target, index, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params)
            => ImplProgramSubroutineParameters(target, count, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params)
            => ImplProgramSubroutineParameters(target, count, @params);

        public NVGpuProgram5(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

