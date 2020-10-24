// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_separate_shader_objects")]
    public unsafe partial class ExtSeparateShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_separate_shader_objects";
        [NativeApi(EntryPoint = "glActiveProgramEXT")]
        public partial void ActiveProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] string @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] in byte @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] string @string);

        [NativeApi(EntryPoint = "glUseShaderProgramEXT")]
        public partial void UseShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint program);

        public ExtSeparateShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

