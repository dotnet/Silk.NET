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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_evaluators")]
    public abstract unsafe partial class NVEvaluators : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_evaluators";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEvalMapsNV")]
        public abstract void EvalMap([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public abstract unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public abstract void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public abstract unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public abstract void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public abstract unsafe void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public abstract void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public abstract unsafe void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public abstract void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public abstract unsafe void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public abstract void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, uorder, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public abstract unsafe void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, uorder, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public abstract void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged;

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public abstract unsafe void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public abstract void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public abstract unsafe void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public abstract void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEvalMapsNV")]
        public abstract void EvalMap([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] EvalMapsModeNV mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public abstract unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV")]
        public abstract void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public abstract unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV")]
        public abstract void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public abstract unsafe void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapControlPointsNV")]
        public abstract void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public abstract unsafe void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterivNV")]
        public abstract void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public abstract unsafe void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetMapParameterfvNV")]
        public abstract void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, uorder, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public abstract unsafe void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="ustride">
        /// To be added.
        /// </param>
        /// <param name="vstride">
        /// To be added.
        /// </param>
        /// <param name="uorder">
        /// To be added.
        /// </param>
        /// <param name="vorder">
        /// To be added.
        /// </param>
        /// <param name="packed">
        /// To be added.
        /// </param>
        /// <param name="points">
        /// To be added.
        /// This parameter's element count is computed from target, uorder, and vorder.
        /// </param>
        [NativeApi(EntryPoint = "glMapControlPointsNV")]
        public abstract void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged;

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public abstract unsafe void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterivNV")]
        public abstract void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public abstract unsafe void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

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
        /// This parameter's element count is computed from target and pname.
        /// </param>
        [NativeApi(EntryPoint = "glMapParameterfvNV")]
        public abstract void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params);

        public NVEvaluators(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

