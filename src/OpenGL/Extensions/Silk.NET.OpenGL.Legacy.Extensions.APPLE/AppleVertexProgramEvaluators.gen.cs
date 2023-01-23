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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_vertex_program_evaluators")]
    public unsafe partial class AppleVertexProgramEvaluators : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_vertex_program_evaluators";
        [NativeApi(EntryPoint = "glDisableVertexAttribAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

        [NativeApi(EntryPoint = "glEnableVertexAttribAPPLE", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

        [NativeApi(EntryPoint = "glIsVertexAttribEnabledAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsVertexAttribEnabled([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] APPLE pname);

        [NativeApi(EntryPoint = "glMapVertexAttrib1dAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glMapVertexAttrib1dAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] in double points);

        [NativeApi(EntryPoint = "glMapVertexAttrib1fAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glMapVertexAttrib1fAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MapVertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int stride, [Flow(FlowDirection.In)] int order, [Count(Computed = "size, stride, order"), Flow(FlowDirection.In)] in float points);

        [NativeApi(EntryPoint = "glMapVertexAttrib2dAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] double* points);

        [NativeApi(EntryPoint = "glMapVertexAttrib2dAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] double u1, [Flow(FlowDirection.In)] double u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] in double points);

        [NativeApi(EntryPoint = "glMapVertexAttrib2fAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] float* points);

        [NativeApi(EntryPoint = "glMapVertexAttrib2fAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MapVertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] float u1, [Flow(FlowDirection.In)] float u2, [Flow(FlowDirection.In)] int ustride, [Flow(FlowDirection.In)] int uorder, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] int vstride, [Flow(FlowDirection.In)] int vorder, [Count(Computed = "size, ustride, uorder, vstride, vorder"), Flow(FlowDirection.In)] in float points);

        public AppleVertexProgramEvaluators(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

