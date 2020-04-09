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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_gpu_shader_fp64")]
    public abstract unsafe partial class ArbGpuShaderFp64 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformdv")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1d")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1dv")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2d")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2dv")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3d")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3dv")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4d")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4dv")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract unsafe void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public abstract void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract unsafe void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public abstract void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract unsafe void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public abstract void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract unsafe void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public abstract void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract unsafe void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public abstract void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract unsafe void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public abstract void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        public ArbGpuShaderFp64(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

