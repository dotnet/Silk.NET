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

namespace Silk.NET.OpenGL.Legacy.Extensions.HP
{
    [Extension("HP_image_transform")]
    public unsafe partial class HPImageTransform : NativeExtension<GL>
    {
        public const string ExtensionName = "HP_image_transform";
        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void GetImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameteriHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterfHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterivHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] HP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] HP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public unsafe partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glImageTransformParameterfvHP", Convention = CallingConvention.Winapi)]
        public partial void ImageTransformParameter([Flow(FlowDirection.In)] ImageTransformTargetHP target, [Flow(FlowDirection.In)] ImageTransformPNameHP pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        public HPImageTransform(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

