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
        public partial void EvalMap([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode);

        [NativeApi(EntryPoint = "glGetMapAttribParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapAttribParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapAttribParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapControlPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* points);

        [NativeApi(EntryPoint = "glGetMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMapParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glMapControlPointsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapControlPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint ustride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint vstride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int uorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vorder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool packed, [Count(Computed = "target, uorder, vorder"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* points);

        [NativeApi(EntryPoint = "glMapParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glMapParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "target, pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        public NVEvaluators(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

