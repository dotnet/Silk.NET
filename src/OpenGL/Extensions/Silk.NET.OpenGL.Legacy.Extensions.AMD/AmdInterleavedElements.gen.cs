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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_interleaved_elements")]
    public unsafe partial class AmdInterleavedElements : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_interleaved_elements";
        [NativeApi(EntryPoint = "glVertexAttribParameteriAMD", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int param);

        public AmdInterleavedElements(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

