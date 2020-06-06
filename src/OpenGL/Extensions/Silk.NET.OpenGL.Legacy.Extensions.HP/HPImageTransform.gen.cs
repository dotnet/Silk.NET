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

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    [Extension("HP_image_transform")]
    public unsafe partial class HPImageTransform : NativeExtension<GL>
    {
        public const string ExtensionName = "HP_image_transform";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameteriHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] int param)
            => ImplImageTransformParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] float param)
            => ImplImageTransformParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameteriHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] int param)
            => ImplImageTransformParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] float param)
            => ImplImageTransformParameter(target, pname, param);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplImageTransformParameter(target, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplImageTransformParameter(target, pname, @params);

        public HPImageTransform(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

