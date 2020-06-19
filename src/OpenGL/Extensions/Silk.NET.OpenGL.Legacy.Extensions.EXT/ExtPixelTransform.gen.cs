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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_pixel_transform")]
    public abstract unsafe partial class ExtPixelTransform : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_pixel_transform";
        [NativeApi(EntryPoint = "glGetPixelTransformParameterivEXT")]
        public abstract unsafe void GetPixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterivEXT")]
        public abstract void GetPixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterfvEXT")]
        public abstract unsafe void GetPixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetPixelTransformParameterfvEXT")]
        public abstract void GetPixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT")]
        public abstract unsafe void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT")]
        public abstract unsafe void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glPixelTransformParameteriEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelTransformParameterfEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT")]
        public abstract unsafe void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterivEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT")]
        public abstract unsafe void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPixelTransformParameterfvEXT")]
        public abstract void PixelTransformParameter([Flow(FlowDirection.In)] PixelTransformTargetEXT target, [Flow(FlowDirection.In)] PixelTransformPNameEXT pname, [Count(Count = 1), Flow(FlowDirection.In)] ref float @params);

        public ExtPixelTransform(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

