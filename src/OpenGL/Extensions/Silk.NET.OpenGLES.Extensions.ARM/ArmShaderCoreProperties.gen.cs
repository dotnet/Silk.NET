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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.ARM
{
    [Extension("ARM_shader_core_properties")]
    public unsafe partial class ArmShaderCoreProperties : NativeExtension<GL>
    {
        public const string ExtensionName = "ARM_shader_core_properties";
        [NativeApi(EntryPoint = "glMaxActiveShaderCoresARM", Convention = CallingConvention.Winapi)]
        public partial void MaxActiveShaderCores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        public ArmShaderCoreProperties(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

