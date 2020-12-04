// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_fragment_lighting")]
    public unsafe partial class SgixFragmentLighting : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_fragment_lighting";
        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public partial void FragmentColorMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public partial void FragmentColorMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public partial void FragmentColorMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX")]
        public partial void FragmentColorMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public unsafe partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX")]
        public partial void FragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public unsafe partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public unsafe partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public unsafe partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public unsafe partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX")]
        public partial void FragmentLightModel([Flow(FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public unsafe partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX")]
        public partial void FragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] SGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public unsafe partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX")]
        public partial void GetFragmentLight([Flow(FlowDirection.In)] FragmentLightNameSGIX light, [Flow(FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] SGIX face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public unsafe partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX")]
        public partial void GetFragmentMaterial([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        public partial void LightEnv([Flow(FlowDirection.In)] SGIX pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightEnviSGIX")]
        public partial void LightEnv([Flow(FlowDirection.In)] LightEnvParameterSGIX pname, [Flow(FlowDirection.In)] int param);

        public SgixFragmentLighting(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

