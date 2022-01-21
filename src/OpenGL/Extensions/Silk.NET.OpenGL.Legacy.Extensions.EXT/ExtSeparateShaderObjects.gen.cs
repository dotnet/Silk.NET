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
    [Extension("EXT_separate_shader_objects")]
    public unsafe partial class ExtSeparateShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_separate_shader_objects";
        [NativeApi(EntryPoint = "glActiveProgramEXT", Convention = CallingConvention.Winapi)]
        public partial void ActiveProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string);

        [NativeApi(EntryPoint = "glUseShaderProgramEXT", Convention = CallingConvention.Winapi)]
        public partial void UseShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint program);

        public ExtSeparateShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

