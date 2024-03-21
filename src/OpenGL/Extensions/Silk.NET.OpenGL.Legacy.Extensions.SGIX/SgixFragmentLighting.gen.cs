// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentColorMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentColorMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentColorMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX mode);

        [NativeApi(EntryPoint = "glFragmentColorMaterialSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentColorMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter mode);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModeliSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentLightModelivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentLightModel([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightModelParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialiSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void FragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentLightivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialfvSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFragmentMaterialivSGIX", Convention = CallingConvention.Winapi)]
        public partial void GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glLightEnviSGIX", Convention = CallingConvention.Winapi)]
        public partial void LightEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightEnviSGIX", Convention = CallingConvention.Winapi)]
        public partial void LightEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightEnvModeSGIX param);

        [NativeApi(EntryPoint = "glLightEnviSGIX", Convention = CallingConvention.Winapi)]
        public partial void LightEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightEnvParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glLightEnviSGIX", Convention = CallingConvention.Winapi)]
        public partial void LightEnv([Flow(Silk.NET.Core.Native.FlowDirection.In)] LightEnvParameterSGIX pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LightEnvModeSGIX param);

        public unsafe float GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentLight(light, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentLight(light, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentLight(light, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentLight([Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightNameSGIX light, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentLightParameterSGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentLight(light, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentMaterial(face, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentMaterial(face, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentMaterial(face, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFragmentMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialParameter pname)
        {
            // NonKhrReturnTypeOverloader
            GetFragmentMaterial(face, pname, out float silkRet);
            return silkRet;
        }

        public SgixFragmentLighting(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

