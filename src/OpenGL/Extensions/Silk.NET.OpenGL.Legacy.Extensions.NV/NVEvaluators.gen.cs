// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_evaluators")]
    public unsafe partial class NVEvaluators : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_evaluators";
        [NativeApi(EntryPoint = "glEvalMapsNV")]
        public partial void EvalMap([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glEvalMapsNV")]
        public partial void EvalMap([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] EvalMapsModeNV mode);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params);

        public NVEvaluators(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

