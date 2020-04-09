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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_register_combiners2")]
    public abstract unsafe partial class NVRegisterCombiners2 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        public abstract unsafe void CombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        public abstract void CombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        public abstract unsafe void GetCombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        public abstract void GetCombinerStageParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        public abstract unsafe void CombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCombinerStageParameterfvNV")]
        public abstract void CombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        public abstract unsafe void GetCombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCombinerStageParameterfvNV")]
        public abstract void GetCombinerStageParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        public NVRegisterCombiners2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

