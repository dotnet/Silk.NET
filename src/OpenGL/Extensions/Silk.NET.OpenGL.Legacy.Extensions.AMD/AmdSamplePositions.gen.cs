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
    [Extension("AMD_sample_positions")]
    public unsafe partial class AmdSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_sample_positions";
        [NativeApi(EntryPoint = "glSetMultisamplefvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* val);

        [NativeApi(EntryPoint = "glSetMultisamplefvAMD", Convention = CallingConvention.Winapi)]
        public partial void SetMultisample([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float val);

        public AmdSamplePositions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

