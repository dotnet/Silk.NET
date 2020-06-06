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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_evaluators")]
    public unsafe partial class NVEvaluators : NativeExtension<GL>
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalMap([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV mode)
            => ImplEvalMap(target, mode);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points)
            => ImplGetMapControlPoints(target, index, type, ustride, vstride, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged
            => ImplGetMapControlPoints<T0>(target, index, type, ustride, vstride, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points)
            => ImplMapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged
            => ImplMapControlPoints<T0>(target, index, type, ustride, vstride, uorder, vorder, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EvalMap([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] EvalMapsModeNV mode)
            => ImplEvalMap(target, mode);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMapAttribParameter(target, index, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points)
            => ImplGetMapControlPoints(target, index, type, ustride, vstride, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged
            => ImplGetMapControlPoints<T0>(target, index, type, ustride, vstride, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points)
            => ImplMapControlPoints(target, index, type, ustride, vstride, uorder, vorder, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] ref T0 points) where T0 : unmanaged
            => ImplMapControlPoints<T0>(target, index, type, ustride, vstride, uorder, vorder, packed, points);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params)
            => ImplMapParameter(target, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplMapParameter(target, pname, @params);

        public NVEvaluators(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

