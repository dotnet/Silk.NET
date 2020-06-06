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
    [Extension("NV_register_combiners2")]
    public unsafe partial class NVRegisterCombiners2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_register_combiners2";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerStageParameter(stage, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerStageParameter(stage, pname, @params);

        public NVRegisterCombiners2(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

