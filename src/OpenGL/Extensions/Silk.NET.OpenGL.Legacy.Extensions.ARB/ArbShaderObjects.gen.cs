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

        [NativeApi(EntryPoint = "glCreateShaderObjectARB", Convention = CallingConvention.Winapi)]
        public partial uint CreateShaderObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShaderType shaderType);

        [NativeApi(EntryPoint = "glDeleteObjectARB", Convention = CallingConvention.Winapi)]
        public partial void DeleteObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj);

        [NativeApi(EntryPoint = "glDetachObjectARB", Convention = CallingConvention.Winapi)]
        public partial void DetachObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint attachedObj);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniformARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* obj);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint obj);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* obj);

        [NativeApi(EntryPoint = "glGetAttachedObjectsARB", Convention = CallingConvention.Winapi)]
        public partial void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint obj);

        [NativeApi(EntryPoint = "glGetHandleARB", Convention = CallingConvention.Winapi)]
        public partial uint GetHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname);

        [NativeApi(EntryPoint = "glGetHandleARB", Convention = CallingConvention.Winapi)]
        public partial uint GetHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] ContainerType pname);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetInfoLogARB", Convention = CallingConvention.Winapi)]
        public partial void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string infoLog);

        [NativeApi(EntryPoint = "glGetObjectParameterfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivARB", Convention = CallingConvention.Winapi)]
        public partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetShaderSourceARB", Convention = CallingConvention.Winapi)]
        public partial void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string source);

        [NativeApi(EntryPoint = "glGetUniformfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetUniformivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformivARB", Convention = CallingConvention.Winapi)]
        public partial void GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "programObj, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformLocationARB", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformLocationARB", Convention = CallingConvention.Winapi)]
        public partial int GetUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        [NativeApi(EntryPoint = "glGetUniformLocationARB", Convention = CallingConvention.Winapi)]
        public partial int GetUniformLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glLinkProgramARB", Convention = CallingConvention.Winapi)]
        public partial void LinkProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int length);

        [NativeApi(EntryPoint = "glShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSourceARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int length);

        [NativeApi(EntryPoint = "glUniform1fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1fvARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniform1ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform1ivARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glUniform2fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2fvARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniform2ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2ivARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glUniform3fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3fvARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniform3ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3ivARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glUniform4fARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4iARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4fvARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniform4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4ivARB", Convention = CallingConvention.Winapi)]
        public partial void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int value);

        [NativeApi(EntryPoint = "glUniformMatrix2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fvARB", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fvARB", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fvARB", Convention = CallingConvention.Winapi)]
        public partial void UniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float value);

        [NativeApi(EntryPoint = "glUseProgramObjectARB", Convention = CallingConvention.Winapi)]
        public partial void UseProgramObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        [NativeApi(EntryPoint = "glValidateProgramARB", Convention = CallingConvention.Winapi)]
        public partial void ValidateProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj);

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveUniform(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> obj)
        {
            // ImplicitCountSpanOverloader
            GetAttachedObjects(containerObj, (uint) obj.Length, count, out obj.GetPinnableReference());
        }

        public unsafe void GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> obj)
        {
            // ImplicitCountSpanOverloader
            GetAttachedObjects(containerObj, (uint) obj.Length, out count, out obj.GetPinnableReference());
        }

        public unsafe void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetInfoLog(obj, (uint) infoLog.Length, length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetInfoLog(obj, (uint) infoLog.Length, length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetInfoLog(obj, (uint) infoLog.Length, out length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> infoLog)
        {
            // ImplicitCountSpanOverloader
            GetInfoLog(obj, (uint) infoLog.Length, out length, out infoLog.GetPinnableReference());
        }

        public unsafe void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> source)
        {
            // ImplicitCountSpanOverloader
            GetShaderSource(obj, (uint) source.Length, length, out source.GetPinnableReference());
        }

        public unsafe void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> source)
        {
            // ImplicitCountSpanOverloader
            GetShaderSource(obj, (uint) source.Length, length, out source.GetPinnableReference());
        }

        public unsafe void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<byte> source)
        {
            // ImplicitCountSpanOverloader
            GetShaderSource(obj, (uint) source.Length, out length, out source.GetPinnableReference());
        }

        public unsafe void GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Parameter = "maxLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<string> source)
        {
            // ImplicitCountSpanOverloader
            GetShaderSource(obj, (uint) source.Length, out length, out source.GetPinnableReference());
        }

        public unsafe void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.StringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((nint) @string, @stringSa);
            SilkMarshal.Free((nint) @string);
        }

        public unsafe void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.StringArrayToPtr(@stringSa);
            ShaderSource(shaderObj, count, @string, in length);
            SilkMarshal.CopyPtrToStringArray((nint) @string, @stringSa);
            SilkMarshal.Free((nint) @string);
        }

        public unsafe void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // ImplicitCountSpanOverloader
            ShaderSource(shaderObj, (uint) length.Length, @string, in length.GetPinnableReference());
        }

        public unsafe void ShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shaderObj, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* @string, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> length)
        {
            // ImplicitCountSpanOverloader
            ShaderSource(shaderObj, (uint) length.Length, in @string, in length.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length/1, in value.GetPinnableReference());
        }

        public unsafe void Uniform1([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            Uniform1(location, (uint) value.Length/1, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void Uniform2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            Uniform2(location, (uint) value.Length/2, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void Uniform3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            Uniform3(location, (uint) value.Length/3, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void Uniform4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> value)
        {
            // ImplicitCountSpanOverloader
            Uniform4(location, (uint) value.Length/4, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix2([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix2(location, (uint) value.Length/4, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*9"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix3(location, (uint) value.Length/9, transpose, in value.GetPinnableReference());
        }

        public unsafe void UniformMatrix4([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool transpose, [Count(Parameter = "count", Expression = "*16"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // ImplicitCountSpanOverloader
            UniformMatrix4(location, (uint) value.Length/16, transpose, in value.GetPinnableReference());
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ARB* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ARB type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] UniformType* type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, out size, type, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetActiveUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int size, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out UniformType type)
        {
            // NonKhrReturnTypeOverloader
            GetActiveUniform(programObj, index, maxLength, out length, out size, out type, out byte silkRet);
            return silkRet;
        }

        public unsafe uint GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count)
        {
            // NonKhrReturnTypeOverloader
            GetAttachedObjects(containerObj, maxCount, count, out uint silkRet);
            return silkRet;
        }

        public unsafe uint GetAttachedObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint containerObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint count)
        {
            // NonKhrReturnTypeOverloader
            GetAttachedObjects(containerObj, maxCount, out count, out uint silkRet);
            return silkRet;
        }

        public unsafe byte GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetInfoLog(obj, maxLength, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetInfoLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetInfoLog(obj, maxLength, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe float GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetObjectParameter(obj, pname, out float silkRet);
            return silkRet;
        }

        public unsafe byte GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length)
        {
            // NonKhrReturnTypeOverloader
            GetShaderSource(obj, maxLength, length, out byte silkRet);
            return silkRet;
        }

        public unsafe byte GetShaderSource([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint obj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint length)
        {
            // NonKhrReturnTypeOverloader
            GetShaderSource(obj, maxLength, out length, out byte silkRet);
            return silkRet;
        }

        public unsafe float GetUniform([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint programObj, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location)
        {
            // NonKhrReturnTypeOverloader
            GetUniform(programObj, location, out float silkRet);
            return silkRet;
        }

        public ArbShaderObjects(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

