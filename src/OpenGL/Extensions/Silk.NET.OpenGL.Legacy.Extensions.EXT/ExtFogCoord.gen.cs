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
    [Extension("EXT_fog_coord")]
    public unsafe partial class ExtFogCoord : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fog_coord";
        [NativeApi(EntryPoint = "glFogCoordfEXT", Convention = CallingConvention.Winapi)]
        public partial void FogCoord([Flow(FlowDirection.In)] float coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] float* coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT", Convention = CallingConvention.Winapi)]
        public partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] in float coord);

        [NativeApi(EntryPoint = "glFogCoorddEXT", Convention = CallingConvention.Winapi)]
        public partial void FogCoord([Flow(FlowDirection.In)] double coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] double* coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT", Convention = CallingConvention.Winapi)]
        public partial void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] in double coord);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void FogCoordPointer([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        public ExtFogCoord(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

