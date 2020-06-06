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
    [Extension("ARB_sampler_objects")]
    public unsafe partial class ArbSamplerObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sampler_objects";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="unit">
        /// To be added.
        /// </param>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler)
            => ImplBindSampler(unit, sampler);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers)
            => ImplDeleteSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers)
            => ImplDeleteSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGenSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers)
            => ImplGenSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glGenSamplers")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers)
            => ImplGenSamplers(count, samplers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsSampler")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsSampler([Flow(FlowDirection.In)] uint sampler)
            => ImplIsSampler(sampler);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetSamplerParameter(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetSamplerParameterI(sampler, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteri")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterf")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param)
            => ImplSamplerParameter(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sampler">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param)
            => ImplSamplerParameterI(sampler, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public ArbSamplerObjects(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

