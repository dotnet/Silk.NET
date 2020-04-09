// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_gpu_shader_int64")]
    public abstract unsafe partial class ArbGpuShaderInt64 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformi64vARB")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformi64vARB")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformui64vARB")]
        public abstract unsafe void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetnUniformui64vARB")]
        public abstract void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformi64vARB")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformi64vARB")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformui64vARB")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformui64vARB")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1i64ARB")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1i64vARB")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1i64vARB")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ui64ARB")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB")]
        public abstract unsafe void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform1ui64vARB")]
        public abstract void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2i64ARB")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2i64vARB")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2i64vARB")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ui64ARB")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB")]
        public abstract unsafe void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform2ui64vARB")]
        public abstract void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3i64ARB")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3i64vARB")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3i64vARB")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ui64ARB")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB")]
        public abstract unsafe void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform3ui64vARB")]
        public abstract void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4i64ARB")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4i64vARB")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4i64vARB")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ui64ARB")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB")]
        public abstract unsafe void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glProgramUniform4ui64vARB")]
        public abstract void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1i64ARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1i64vARB")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1i64vARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ui64ARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ui64vARB")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ui64vARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2i64ARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2i64vARB")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2i64vARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ui64ARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ui64vARB")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ui64vARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3i64ARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3i64vARB")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3i64vARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ui64ARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ui64vARB")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ui64vARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4i64ARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4i64vARB")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] long* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4i64vARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<long> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ui64ARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ui64vARB")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ui64vARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        public ArbGpuShaderInt64(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

