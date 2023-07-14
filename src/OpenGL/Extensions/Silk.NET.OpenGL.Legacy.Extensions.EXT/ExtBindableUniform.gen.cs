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
    [Extension("EXT_bindable_uniform")]
    public unsafe partial class ExtBindableUniform : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_bindable_uniform";
        [NativeApi(EntryPoint = "glGetUniformBufferSizeEXT", Convention = CallingConvention.Winapi)]
        public partial int GetUniformBufferSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location);

        [NativeApi(EntryPoint = "glGetUniformOffsetEXT", Convention = CallingConvention.Winapi)]
        public partial nint GetUniformOffset([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location);

        [NativeApi(EntryPoint = "glUniformBufferEXT", Convention = CallingConvention.Winapi)]
        public partial void UniformBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer);

        public ExtBindableUniform(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

