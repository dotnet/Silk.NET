// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shader_objects")]
    public unsafe partial class ArbShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_objects";
        [NativeApi(EntryPoint = "glAttachObjectARB", Convention = CallingConvention.Winapi)]
        public partial void AttachObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj);

        [NativeApi(EntryPoint = "glCompileShaderARB", Convention = CallingConvention.Winapi)]
        public partial void CompileShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj);

        [NativeApi(EntryPoint = "glCreateProgramObjectARB", Convention = CallingConvention.Winapi)]
        public partial uint CreateProgramObject();

        [NativeApi(EntryPoint = "glCreateShaderObjectARB", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB shaderType);

        [NativeApi(EntryPoint = "glDeleteObjectARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj);

        [NativeApi(EntryPoint = "glDetachObjectARB", Convention = CallingConvention.Winapi)]
        public partial void DetachObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attachedObj);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* obj);

        [NativeApi(EntryPoint = "glGetHandleARB", Convention = CallingConvention.Winapi)]
        public partial uint GetHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetObjectParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformLocationARB", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glLinkProgramARB", Convention = CallingConvention.Winapi)]
        public partial void LinkProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glUniform1fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUseProgramObjectARB", Convention = CallingConvention.Winapi)]
        public partial void UseProgramObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glValidateProgramARB", Convention = CallingConvention.Winapi)]
        public partial void ValidateProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        public ArbShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

