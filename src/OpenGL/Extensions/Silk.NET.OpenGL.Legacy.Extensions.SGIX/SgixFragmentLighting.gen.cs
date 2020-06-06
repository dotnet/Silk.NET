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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_fragment_lighting")]
    public unsafe partial class SgixFragmentLighting : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_fragment_lighting";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentColorMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX mode)
            => ImplFragmentColorMaterial(face, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentLight(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentLight(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentLightModel(pname, param);

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
        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentLightModel(pname, @params);

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
        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentLightModel(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentLightModel(pname, param);

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
        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentLightModel(pname, @params);

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
        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentLightModel(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentMaterial(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentMaterial(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightEnv([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplLightEnv(pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentColorMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter mode)
            => ImplFragmentColorMaterial(face, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentLight(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentLight(light, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentLightModel(pname, param);

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
        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentLightModel(pname, @params);

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
        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentLightModel(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentLightModel(pname, param);

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
        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentLightModel(pname, @params);

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
        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentLightModel(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] float param)
            => ImplFragmentMaterial(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param)
            => ImplFragmentMaterial(face, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="light">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFragmentLight(light, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetFragmentMaterial(face, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LightEnv([Flow(FlowDirection.In)] LightEnvParameterSGIX pname, [Flow(FlowDirection.In)] int param)
            => ImplLightEnv(pname, param);

        public SgixFragmentLighting(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

