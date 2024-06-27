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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_point_parameters")]
    public unsafe partial class SgisPointParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_point_parameters";
        [NativeApi(EntryPoint = "glPointParameterfSGIS", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfSGIS", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glPointParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvSGIS", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        public SgisPointParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

