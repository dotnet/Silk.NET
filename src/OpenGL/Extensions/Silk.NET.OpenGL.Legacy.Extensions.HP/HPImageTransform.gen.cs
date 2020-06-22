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
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP")]
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        public abstract unsafe void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP")]
        public abstract void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        public abstract unsafe void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP")]
        public abstract void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        public HPImageTransform(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

