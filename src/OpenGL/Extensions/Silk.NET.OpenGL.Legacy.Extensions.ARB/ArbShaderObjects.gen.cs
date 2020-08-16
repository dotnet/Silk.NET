// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shader_objects")]
    public unsafe partial class ArbShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_objects";
        [NativeApi(EntryPoint = "glAttachObjectARB")]
        public partial void AttachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint obj);

        [NativeApi(EntryPoint = "glCompileShaderARB")]
        public partial void CompileShader([Flow(FlowDirection.In)] uint shaderObj);

        [NativeApi(EntryPoint = "glCreateProgramObjectARB")]
        public partial uint CreateProgramObject();

        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        public partial uint CreateShaderObject([Flow(FlowDirection.In)] ARB shaderType);

        [NativeApi(EntryPoint = "glDeleteObjectARB")]
        public partial void DeleteObject([Flow(FlowDirection.In)] uint obj);

        [NativeApi(EntryPoint = "glDetachObjectARB")]
        public partial void DetachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint attachedObj);

        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        public unsafe partial void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* obj);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        public partial void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> obj);

        [NativeApi(EntryPoint = "glGetHandleARB")]
        public partial uint GetHandle([Flow(FlowDirection.In)] ARB pname);

        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public unsafe partial void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public partial void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> infoLog);

        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        public unsafe partial void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        public partial void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        public unsafe partial void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        public partial void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> source);

        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetUniformivARB")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformivARB")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public unsafe partial int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] char* name);

        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] Span<char> name);

        [NativeApi(EntryPoint = "glLinkProgramARB")]
        public partial void LinkProgram([Flow(FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glShaderSourceARB")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSourceARB")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        [NativeApi(EntryPoint = "glUniform1fARB")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1iARB")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1fvARB")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1fvARB")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform1ivARB")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform1ivARB")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform2fARB")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2iARB")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2fvARB")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2fvARB")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform2ivARB")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2ivARB")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform3fARB")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3iARB")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3fvARB")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3fvARB")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform3ivARB")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3ivARB")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform4fARB")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4iARB")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4fvARB")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4fvARB")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform4ivARB")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4ivARB")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUseProgramObjectARB")]
        public partial void UseProgramObject([Flow(FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glValidateProgramARB")]
        public partial void ValidateProgram([Flow(FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        public partial uint CreateShaderObject([Flow(FlowDirection.In)] ShaderType shaderType);

        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public unsafe partial void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        public partial void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] string name);

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (char**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public ArbShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

