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
    [Extension("ARB_shader_objects")]
    public abstract unsafe partial class ArbShaderObjects : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAttachObjectARB")]
        public abstract void AttachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint obj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompileShaderARB")]
        public abstract void CompileShader([Flow(FlowDirection.In)] uint shaderObj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgramObjectARB")]
        public abstract uint CreateProgramObject();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        public abstract uint CreateShaderObject([Flow(FlowDirection.In)] ARB shaderType);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteObjectARB")]
        public abstract void DeleteObject([Flow(FlowDirection.In)] uint obj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDetachObjectARB")]
        public abstract void DetachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint attachedObj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        public abstract unsafe void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* obj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        public abstract void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> obj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetHandleARB")]
        public abstract uint GetHandle([Flow(FlowDirection.In)] ARB pname);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public abstract unsafe void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public abstract void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        public abstract unsafe void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        public abstract void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        public abstract unsafe void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        public abstract void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformivARB")]
        public abstract unsafe void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformivARB")]
        public abstract void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public abstract unsafe int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] char* name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] Span<char> name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glLinkProgramARB")]
        public abstract void LinkProgram([Flow(FlowDirection.In)] uint programObj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderSourceARB")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glShaderSourceARB")]
        public abstract unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1fARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1iARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1fvARB")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1fvARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ivARB")]
        public abstract unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform1ivARB")]
        public abstract void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2fARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2iARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2fvARB")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2fvARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ivARB")]
        public abstract unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform2ivARB")]
        public abstract void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3fARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3iARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3fvARB")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3fvARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ivARB")]
        public abstract unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform3ivARB")]
        public abstract void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4fARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4iARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4fvARB")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4fvARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ivARB")]
        public abstract unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniform4ivARB")]
        public abstract void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        public abstract unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        public abstract void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        public abstract unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        public abstract void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        public abstract unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        public abstract void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUseProgramObjectARB")]
        public abstract void UseProgramObject([Flow(FlowDirection.In)] uint programObj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glValidateProgramARB")]
        public abstract void ValidateProgram([Flow(FlowDirection.In)] uint programObj);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        public abstract uint CreateShaderObject([Flow(FlowDirection.In)] ShaderType shaderType);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public abstract unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public abstract void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public abstract unsafe void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public abstract void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public abstract unsafe void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public abstract void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public abstract int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] string name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaderObj">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaderObj">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public ArbShaderObjects(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

