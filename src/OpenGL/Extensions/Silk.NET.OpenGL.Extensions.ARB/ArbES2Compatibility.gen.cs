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
    [Extension("ARB_ES2_compatibility")]
    public unsafe partial class ArbES2Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES2_compatibility";
        [NativeApi(EntryPoint = "glClearDepthf", Convention = CallingConvention.Winapi)]
        public partial void ClearDepth([Flow(Silk.NET.Core.Native.FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glDepthRangef", Convention = CallingConvention.Winapi)]
        public partial void DepthRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] float n, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderPrecisionFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shadertype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB precisiontype, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* range, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler", Convention = CallingConvention.Winapi)]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glShaderBinary", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB binaryFormat, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* binary, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length);

        public ArbES2Compatibility(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

