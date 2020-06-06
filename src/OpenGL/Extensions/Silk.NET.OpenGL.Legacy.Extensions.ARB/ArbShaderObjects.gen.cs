// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shader_objects")]
    public unsafe partial class ArbShaderObjects : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_objects";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="containerObj">
        /// To be added.
        /// </param>
        /// <param name="obj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAttachObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void AttachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint obj)
            => ImplAttachObject(containerObj, obj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaderObj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCompileShaderARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CompileShader([Flow(FlowDirection.In)] uint shaderObj)
            => ImplCompileShader(shaderObj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateProgramObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateProgramObject()
            => ImplCreateProgramObject();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaderType">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateShaderObject([Flow(FlowDirection.In)] ARB shaderType)
            => ImplCreateShaderObject(shaderType);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteObject([Flow(FlowDirection.In)] uint obj)
            => ImplDeleteObject(obj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="containerObj">
        /// To be added.
        /// </param>
        /// <param name="attachedObj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDetachObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DetachObject([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint attachedObj)
            => ImplDetachObject(containerObj, attachedObj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* name)
            => ImplGetActiveUniform(programObj, index, maxLength, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> name)
            => ImplGetActiveUniform(programObj, index, maxLength, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="containerObj">
        /// To be added.
        /// </param>
        /// <param name="maxCount">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="obj">
        /// To be added.
        /// This parameter's element count is taken from maxCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* obj)
            => ImplGetAttachedObjects(containerObj, maxCount, count, obj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="containerObj">
        /// To be added.
        /// </param>
        /// <param name="maxCount">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="obj">
        /// To be added.
        /// This parameter's element count is taken from maxCount.
        /// </param>
        [NativeApi(EntryPoint = "glGetAttachedObjectsARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetAttachedObjects([Flow(FlowDirection.In)] uint containerObj, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> obj)
            => ImplGetAttachedObjects(containerObj, maxCount, count, obj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetHandleARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetHandle([Flow(FlowDirection.In)] ARB pname)
            => ImplGetHandle(pname);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* infoLog)
            => ImplGetInfoLog(obj, maxLength, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> infoLog)
            => ImplGetInfoLog(obj, maxLength, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetObjectParameter(obj, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetObjectParameter(obj, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetObjectParameter(obj, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectParameterivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetObjectParameter([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetObjectParameter(obj, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] char* source)
            => ImplGetShaderSource(obj, maxLength, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// This parameter's element count is taken from maxLength.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<char> source)
            => ImplGetShaderSource(obj, maxLength, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from programObj and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetUniform(programObj, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from programObj and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformfvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetUniform(programObj, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from programObj and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetUniform(programObj, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from programObj and location.
        /// </param>
        [NativeApi(EntryPoint = "glGetUniformivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetUniform(programObj, location, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] char* name)
            => ImplGetUniformLocation(programObj, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetUniformLocation(programObj, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glLinkProgramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LinkProgram([Flow(FlowDirection.In)] uint programObj)
            => ImplLinkProgram(programObj);

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
        [NativeApi(EntryPoint = "glShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
            => ImplShaderSource(shaderObj, count, @string, length);

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
        [NativeApi(EntryPoint = "glShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shaderObj, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
            => ImplShaderSource(shaderObj, count, @string, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0)
            => ImplUniform1(location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0)
            => ImplUniform1(location, v0);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform1ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform1(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1)
            => ImplUniform2(location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1)
            => ImplUniform2(location, v0, v1);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform2ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform2(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2)
            => ImplUniform3(location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2)
            => ImplUniform3(location, v0, v1, v2);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform3ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform3(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4fARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3)
            => ImplUniform4(location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="v0">
        /// To be added.
        /// </param>
        /// <param name="v1">
        /// To be added.
        /// </param>
        /// <param name="v2">
        /// To be added.
        /// </param>
        /// <param name="v3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4iARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3)
            => ImplUniform4(location, v0, v1, v2, v3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniform4ivARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value)
            => ImplUniform4(location, count, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix2fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix2(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix3fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix3(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value)
            => ImplUniformMatrix4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="location">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="transpose">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glUniformMatrix4fvARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value)
            => ImplUniformMatrix4(location, count, transpose, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glUseProgramObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void UseProgramObject([Flow(FlowDirection.In)] uint programObj)
            => ImplUseProgramObject(programObj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glValidateProgramARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ValidateProgram([Flow(FlowDirection.In)] uint programObj)
            => ImplValidateProgram(programObj);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shaderType">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glCreateShaderObjectARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint CreateShaderObject([Flow(FlowDirection.In)] ShaderType shaderType)
            => ImplCreateShaderObject(shaderType);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveUniform(programObj, index, maxLength, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetActiveUniformARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetActiveUniform([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -4)] out string name)
            => ImplGetActiveUniform(programObj, index, maxLength, length, size, type, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetInfoLog(obj, maxLength, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="infoLog">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetInfoLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetInfoLog([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string infoLog)
            => ImplGetInfoLog(obj, maxLength, length, infoLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source)
            => ImplGetShaderSource(obj, maxLength, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="obj">
        /// To be added.
        /// </param>
        /// <param name="maxLength">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="source">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetShaderSourceARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShaderSource([Flow(FlowDirection.In)] uint obj, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string source)
            => ImplGetShaderSource(obj, maxLength, length, source);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="programObj">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetUniformLocationARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetUniformLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] string name)
            => ImplGetUniformLocation(programObj, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
            InitializeNative();
        }
    }
}

