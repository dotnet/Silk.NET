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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_fragment_coverage_to_color")]
    public unsafe partial class NVFragmentCoverageToColor : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_fragment_coverage_to_color";
        [NativeApi(EntryPoint = "glFragmentCoverageColorNV", Convention = CallingConvention.Winapi)]
        public partial void FragmentCoverageColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color);

        public NVFragmentCoverageToColor(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

