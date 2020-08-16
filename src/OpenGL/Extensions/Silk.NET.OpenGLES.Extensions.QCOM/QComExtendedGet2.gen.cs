// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_extended_get2")]
    public unsafe partial class QComExtendedGet2 : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_extended_get2";
        [NativeApi(EntryPoint = "glExtGetProgramsQCOM")]
        public unsafe partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] uint* programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] int* numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramsQCOM")]
        public partial void ExtGetProgram([Count(Parameter = "maxPrograms"), Flow(FlowDirection.Out)] Span<uint> programs, [Flow(FlowDirection.In)] int maxPrograms, [Count(Count = 1), Flow(FlowDirection.Out)] out int numPrograms);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] byte* source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] QCOM shadertype, [Flow(FlowDirection.Out)] Span<byte> source, [Flow(FlowDirection.Out)] Span<int> length);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM")]
        public unsafe partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] uint* shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] int* numShaders);

        [NativeApi(EntryPoint = "glExtGetShadersQCOM")]
        public partial void ExtGetShaders([Count(Parameter = "maxShaders"), Flow(FlowDirection.Out)] Span<uint> shaders, [Flow(FlowDirection.In)] int maxShaders, [Count(Count = 1), Flow(FlowDirection.Out)] out int numShaders);

        [NativeApi(EntryPoint = "glExtIsProgramBinaryQCOM")]
        public partial bool ExtIsProgramBinary([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public unsafe partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] int* length);

        [NativeApi(EntryPoint = "glExtGetProgramBinarySourceQCOM")]
        public partial void ExtGetProgramBinarySource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.Out)] string source, [Flow(FlowDirection.Out)] Span<int> length);

        public QComExtendedGet2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

