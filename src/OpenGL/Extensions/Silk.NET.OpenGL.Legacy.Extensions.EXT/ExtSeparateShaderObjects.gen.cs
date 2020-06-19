// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_separate_shader_objects")]
    public abstract unsafe partial class ExtSeparateShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_separate_shader_objects";
        [NativeApi(EntryPoint = "glActiveProgramEXT")]
        public abstract void ActiveProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public abstract unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] char* @string);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public abstract uint CreateShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] Span<char> @string);

        [NativeApi(EntryPoint = "glUseShaderProgramEXT")]
        public abstract void UseShaderProgram([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glCreateShaderProgramEXT")]
        public abstract uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] string @string);

        public ExtSeparateShaderObjects(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

