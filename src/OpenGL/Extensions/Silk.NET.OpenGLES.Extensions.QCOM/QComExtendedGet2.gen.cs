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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get2")]
    public unsafe partial class QComExtendedGet2 : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get2";
        [NativeApi(EntryPoint = "glExtGetProgramsQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* programs, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetProgramBinarySource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] QCOM shadertype, [Count(Parameter = "length"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM", Convention = CallingConvention.Winapi)]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* shaders, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtIsProgramBinaryQCOM", Convention = CallingConvention.Winapi)]
        public partial bool ExtIsProgramBinary([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program);

        public QComExtendedGet2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

