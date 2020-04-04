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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_shader_buffer_load")]
    public abstract unsafe partial class NVShaderBufferLoad : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerui64vNV")]
        public abstract unsafe void GetInteger([Flow(FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerui64vNV")]
        public abstract void GetInteger([Flow(FlowDirection.In)] NV value, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformui64vNV")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformui64vNV")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsBufferResidentNV")]
        public abstract bool IsBufferResident([Flow(FlowDirection.In)] NV target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsNamedBufferResidentNV")]
        public abstract bool IsNamedBufferResident([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeBufferNonResidentNV")]
        public abstract void MakeBufferNonResident([Flow(FlowDirection.In)] NV target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeBufferResidentNV")]
        public abstract void MakeBufferResident([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeNamedBufferNonResidentNV")]
        public abstract void MakeNamedBufferNonResident([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMakeNamedBufferResidentNV")]
        public abstract void MakeNamedBufferResident([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] NV access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformui64NV")]
        public abstract void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformui64vNV")]
        public abstract unsafe void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniformui64vNV")]
        public abstract void ProgramUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformui64NV")]
        public abstract void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformui64vNV")]
        public abstract unsafe void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformui64vNV")]
        public abstract void Uniform([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public abstract unsafe void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetBufferParameterui64vNV")]
        public abstract void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameterui64vNV")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="result">
        /// To be added.
        /// This parameter's element count is computed from value.
        /// </param>
        public unsafe ulong GetInteger([Flow(FlowDirection.In)] NV value)
        {
            // ReturnTypeOverloader
            ulong ret = default;
            GetInteger(value, &ret);
            return ret;
        }

        public NVShaderBufferLoad(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

