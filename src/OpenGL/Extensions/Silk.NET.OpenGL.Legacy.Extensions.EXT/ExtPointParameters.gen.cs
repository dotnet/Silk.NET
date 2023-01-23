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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_point_parameters")]
    public unsafe partial class ExtPointParameters : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_point_parameters";
        [NativeApi(EntryPoint = "glPointParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfEXT", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glPointParameterfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfvEXT", Convention = CallingConvention.Winapi)]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        public ExtPointParameters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

