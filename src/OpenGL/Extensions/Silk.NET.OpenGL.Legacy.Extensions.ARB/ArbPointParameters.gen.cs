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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_point_parameters")]
    public unsafe partial class ArbPointParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_point_parameters";
        [NativeApi(EntryPoint = "glPointParameterfARB", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfARB", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvARB", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        public ArbPointParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

