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
    [Extension("NV_register_combiners")]
    public unsafe partial class NVRegisterCombiners : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_register_combiners";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="input">
        /// To be added.
        /// </param>
        /// <param name="mapping">
        /// To be added.
        /// </param>
        /// <param name="componentUsage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerInputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerInput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage)
            => ImplCombinerInput(stage, portion, variable, input, mapping, componentUsage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="abOutput">
        /// To be added.
        /// </param>
        /// <param name="cdOutput">
        /// To be added.
        /// </param>
        /// <param name="sumOutput">
        /// To be added.
        /// </param>
        /// <param name="scale">
        /// To be added.
        /// </param>
        /// <param name="bias">
        /// To be added.
        /// </param>
        /// <param name="abDotProduct">
        /// To be added.
        /// </param>
        /// <param name="cdDotProduct">
        /// To be added.
        /// </param>
        /// <param name="muxSum">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerOutput([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV abOutput, [Flow(FlowDirection.In)] NV cdOutput, [Flow(FlowDirection.In)] NV sumOutput, [Flow(FlowDirection.In)] NV scale, [Flow(FlowDirection.In)] NV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum)
            => ImplCombinerOutput(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float param)
            => ImplCombinerParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param)
            => ImplCombinerParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="input">
        /// To be added.
        /// </param>
        /// <param name="mapping">
        /// To be added.
        /// </param>
        /// <param name="componentUsage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinalCombinerInput([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV input, [Flow(FlowDirection.In)] NV mapping, [Flow(FlowDirection.In)] NV componentUsage)
            => ImplFinalCombinerInput(variable, input, mapping, componentUsage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerInputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerOutputParameter([Flow(FlowDirection.In)] NV stage, [Flow(FlowDirection.In)] NV portion, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] NV variable, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="input">
        /// To be added.
        /// </param>
        /// <param name="mapping">
        /// To be added.
        /// </param>
        /// <param name="componentUsage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerInputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerInput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage)
            => ImplCombinerInput(stage, portion, variable, input, mapping, componentUsage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="abOutput">
        /// To be added.
        /// </param>
        /// <param name="cdOutput">
        /// To be added.
        /// </param>
        /// <param name="sumOutput">
        /// To be added.
        /// </param>
        /// <param name="scale">
        /// To be added.
        /// </param>
        /// <param name="bias">
        /// To be added.
        /// </param>
        /// <param name="abDotProduct">
        /// To be added.
        /// </param>
        /// <param name="cdDotProduct">
        /// To be added.
        /// </param>
        /// <param name="muxSum">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerOutputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerOutput([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerRegisterNV abOutput, [Flow(FlowDirection.In)] CombinerRegisterNV cdOutput, [Flow(FlowDirection.In)] CombinerRegisterNV sumOutput, [Flow(FlowDirection.In)] CombinerScaleNV scale, [Flow(FlowDirection.In)] CombinerBiasNV bias, [Flow(FlowDirection.In)] bool abDotProduct, [Flow(FlowDirection.In)] bool cdDotProduct, [Flow(FlowDirection.In)] bool muxSum)
            => ImplCombinerOutput(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterfNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Flow(FlowDirection.In)] float param)
            => ImplCombinerParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplCombinerParameter(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCombinerParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CombinerParameter([Flow(FlowDirection.In)] CombinerParameterNV pname, [Flow(FlowDirection.In)] int param)
            => ImplCombinerParameter(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="input">
        /// To be added.
        /// </param>
        /// <param name="mapping">
        /// To be added.
        /// </param>
        /// <param name="componentUsage">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFinalCombinerInputNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FinalCombinerInput([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerRegisterNV input, [Flow(FlowDirection.In)] CombinerMappingNV mapping, [Flow(FlowDirection.In)] CombinerComponentUsageNV componentUsage)
            => ImplFinalCombinerInput(variable, input, mapping, componentUsage);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerInputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetCombinerInputParameter(stage, portion, variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stage">
        /// To be added.
        /// </param>
        /// <param name="portion">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetCombinerOutputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCombinerOutputParameter([Flow(FlowDirection.In)] CombinerStageNV stage, [Flow(FlowDirection.In)] CombinerPortionNV portion, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetCombinerOutputParameter(stage, portion, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="variable">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFinalCombinerInputParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFinalCombinerInputParameter([Flow(FlowDirection.In)] CombinerVariableNV variable, [Flow(FlowDirection.In)] CombinerParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFinalCombinerInputParameter(variable, pname, @params);

        public NVRegisterCombiners(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

