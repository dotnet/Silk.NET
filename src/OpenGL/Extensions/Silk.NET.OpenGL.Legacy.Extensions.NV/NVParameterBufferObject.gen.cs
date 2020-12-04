// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_parameter_buffer_object")]
    public unsafe partial class NVParameterBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_parameter_buffer_object";
        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public unsafe partial void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public partial void ProgramBufferParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public unsafe partial void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersfvNV")]
        public partial void ProgramBufferParameters([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIivNV")]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public unsafe partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramBufferParametersIuivNV")]
        public partial void ProgramBufferParametersI([Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint @params);

        public NVParameterBufferObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

