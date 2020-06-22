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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_fragment_lighting")]
    public abstract unsafe partial class SgixFragmentLighting : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_fragment_lighting";
        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public abstract void FragmentColorMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public abstract unsafe void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public abstract unsafe void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public abstract unsafe void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public abstract unsafe void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public abstract unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public abstract unsafe void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public abstract unsafe void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public abstract void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public abstract unsafe void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public abstract void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public abstract unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public abstract void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public abstract unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public abstract void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        public abstract void LightEnv([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public abstract void FragmentColorMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public abstract unsafe void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public abstract unsafe void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public abstract void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public abstract unsafe void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public abstract unsafe void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public abstract void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public abstract unsafe void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public abstract unsafe void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public abstract void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public abstract unsafe void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public abstract void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public abstract unsafe void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public abstract void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public abstract unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public abstract void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public abstract unsafe void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public abstract void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        public abstract void LightEnv([Flow(FlowDirection.In)] LightEnvParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        public SgixFragmentLighting(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

