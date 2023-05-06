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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_static_data")]
    public unsafe partial class IbmStaticData : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_static_data";
        [NativeApi(EntryPoint = "glFlushStaticDataIBM", Convention = CallingConvention.Winapi)]
        public partial void FlushStaticData([Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM target);

        public IbmStaticData(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

