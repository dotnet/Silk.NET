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

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    [Extension("HP_image_transform")]
    public abstract unsafe partial class HPImageTransform : NativeExtension<GL>
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
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

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
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] int param);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] float param);

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
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

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
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

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
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

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
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

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
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] int param);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] float param);

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
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

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
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

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
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        public HPImageTransform(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

