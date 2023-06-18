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
    [Extension("SGIS_texture_filter4")]
    public unsafe partial class SgisTextureFilter4 : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_filter4";
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetTexFilterFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexFilterFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weights);

        public SgisTextureFilter4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

