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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_evaluators")]
    public unsafe partial class NVEvaluators : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_evaluators";
        [NativeApi(EntryPoint = "glEvalMapsNV", Convention = CallingConvention.Winapi)]
        public partial void EvalMap([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glEvalMapsNV", Convention = CallingConvention.Winapi)]
        public partial void EvalMap([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] EvalMapsModeNV mode);

        [NativeApi(EntryPoint = "glEvalMapsNV", Convention = CallingConvention.Winapi)]
        public partial void EvalMap([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glEvalMapsNV", Convention = CallingConvention.Winapi)]
        public partial void EvalMap([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] EvalMapsModeNV mode);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapAttribParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapAttribParameterNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target"), Flow(FlowDirection.Out)] out T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetMapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public partial void MapControlPoints<T0>([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] MapTypeNV type, [Flow(FlowDirection.In)] uint ustride, [Flow(FlowDirection.In)] uint vstride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] int vorder, [Flow(FlowDirection.In)] Boolean packed, [Count(Computed = "target, uorder, vorder"), Flow(FlowDirection.In)] in T0 points) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void MapParameter([Flow(FlowDirection.In)] EvalTargetNV target, [Flow(FlowDirection.In)] MapParameterNV pname, [Count(Computed = "target, pname"), Flow(FlowDirection.In)] in float @params);

        public NVEvaluators(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

