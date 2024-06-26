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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [Extension("OES_single_precision")]
    public unsafe partial class OesSinglePrecision : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_single_precision";
        [NativeApi(EntryPoint = "glClearDepthfOES", Convention = CallingConvention.Winapi)]
        public partial void ClearDepth([Flow(Silk.NET.Core.Native.FlowDirection.In)] float depth);

        [NativeApi(EntryPoint = "glClipPlanefOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float equation);

        [NativeApi(EntryPoint = "glClipPlanefOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* equation);

        [NativeApi(EntryPoint = "glClipPlanefOES", Convention = CallingConvention.Winapi)]
        public partial void ClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float equation);

        [NativeApi(EntryPoint = "glDepthRangefOES", Convention = CallingConvention.Winapi)]
        public partial void DepthRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glFrustumfOES", Convention = CallingConvention.Winapi)]
        public partial void Frustum([Flow(Silk.NET.Core.Native.FlowDirection.In)] float l, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetClipPlanefOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* equation);

        [NativeApi(EntryPoint = "glGetClipPlanefOES", Convention = CallingConvention.Winapi)]
        public partial void GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float equation);

        [NativeApi(EntryPoint = "glOrthofOES", Convention = CallingConvention.Winapi)]
        public partial void Ortho([Flow(Silk.NET.Core.Native.FlowDirection.In)] float l, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        public unsafe float GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES plane)
        {
            // NonKhrReturnTypeOverloader
            GetClipPlane(plane, out float silkRet);
            return silkRet;
        }

        public unsafe float GetClipPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] ClipPlaneName plane)
        {
            // NonKhrReturnTypeOverloader
            GetClipPlane(plane, out float silkRet);
            return silkRet;
        }

        public OesSinglePrecision(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

