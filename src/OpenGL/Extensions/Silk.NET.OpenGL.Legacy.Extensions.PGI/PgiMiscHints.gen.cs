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

namespace Silk.NET.OpenGL.Legacy.Extensions.PGI
{
    [Extension("PGI_misc_hints")]
    public unsafe partial class PgiMiscHints : NativeExtension<GL>
    {
        public const string ExtensionName = "PGI_misc_hints";
        [NativeApi(EntryPoint = "glHintPGI", Convention = CallingConvention.Winapi)]
        public partial void Hint([Flow(Silk.NET.Core.Native.FlowDirection.In)] PGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int mode);

        [NativeApi(EntryPoint = "glHintPGI", Convention = CallingConvention.Winapi)]
        public partial void Hint([Flow(Silk.NET.Core.Native.FlowDirection.In)] PGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexHintsMaskPGI mode);

        [NativeApi(EntryPoint = "glHintPGI", Convention = CallingConvention.Winapi)]
        public partial void Hint([Flow(Silk.NET.Core.Native.FlowDirection.In)] HintTargetPGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int mode);

        [NativeApi(EntryPoint = "glHintPGI", Convention = CallingConvention.Winapi)]
        public partial void Hint([Flow(Silk.NET.Core.Native.FlowDirection.In)] HintTargetPGI target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexHintsMaskPGI mode);

        public PgiMiscHints(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

