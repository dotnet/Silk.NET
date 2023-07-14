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
    [Extension("EXT_index_material")]
    public unsafe partial class ExtIndexMaterial : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_index_material";
        [NativeApi(EntryPoint = "glIndexMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glIndexMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexMaterialParameterEXT mode);

        [NativeApi(EntryPoint = "glIndexMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glIndexMaterialEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexMaterial([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexMaterialParameterEXT mode);

        public ExtIndexMaterial(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

