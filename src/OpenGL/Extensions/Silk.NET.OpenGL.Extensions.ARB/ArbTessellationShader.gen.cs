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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_tessellation_shader")]
    public unsafe partial class ArbTessellationShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_tessellation_shader";
        [NativeApi(EntryPoint = "glPatchParameteri", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameteri", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PatchParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float values);

        [NativeApi(EntryPoint = "glPatchParameterfv", Convention = CallingConvention.Winapi)]
        public unsafe partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv", Convention = CallingConvention.Winapi)]
        public partial void PatchParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float values);

        public ArbTessellationShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

