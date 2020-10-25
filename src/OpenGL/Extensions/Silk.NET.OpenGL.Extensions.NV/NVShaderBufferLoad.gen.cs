// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_shader_buffer_load")]
    public unsafe partial class NVShaderBufferLoad : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shader_buffer_load";
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetIntegerui64vNV")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result);

        [NativeApi(EntryPoint = "glGetIntegerui64vNV")]
        public partial void GetInteger([Flow(FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetUniformui64vNV")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetUniformui64vNV")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glIsBufferResidentNV")]
        public partial bool IsBufferResident([Flow(FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glIsNamedBufferResidentNV")]
        public partial bool IsNamedBufferResident([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMakeBufferNonResidentNV")]
        public partial void MakeBufferNonResident([Flow(FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glMakeBufferResidentNV")]
        public partial void MakeBufferResident([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glMakeNamedBufferNonResidentNV")]
        public partial void MakeNamedBufferNonResident([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glMakeNamedBufferResidentNV")]
        public partial void MakeNamedBufferResident([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "glProgramUniformui64NV")]
        public partial void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformui64vNV")]
        public unsafe partial void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glProgramUniformui64vNV")]
        public partial void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glUniformui64NV")]
        public partial void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformui64vNV")]
        public unsafe partial void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformui64vNV")]
        public partial void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        public unsafe ulong GetInteger([Flow(FlowDirection.In)] NV value)
        {
            // ReturnTypeOverloader
            ulong ret = default;
            GetInteger(value, &ret);
            return ret;
        }

        public NVShaderBufferLoad(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

