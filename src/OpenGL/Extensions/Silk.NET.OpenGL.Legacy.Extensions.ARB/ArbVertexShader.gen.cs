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
    [Extension("ARB_vertex_shader")]
    public unsafe partial class ArbVertexShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_shader";
        [NativeApi(EntryPoint = "glBindAttribLocationARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindAttribLocationARB", Convention = CallingConvention.Winapi)]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindAttribLocationARB", Convention = CallingConvention.Winapi)]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glDisableVertexAttribArrayARB", Convention = CallingConvention.Winapi)]
        public partial void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexAttribArrayARB", Convention = CallingConvention.Winapi)]
        public partial void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttribARB", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint maxLength, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] out string name);

        [NativeApi(EntryPoint = "glGetAttribLocationARB", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetAttribLocationARB", Convention = CallingConvention.Winapi)]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetAttribLocationARB", Convention = CallingConvention.Winapi)]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdvARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfvARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribivARB", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointervARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glVertexAttrib1fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib1svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1svARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib1dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib2fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib2svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2svARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib2dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib3fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib3svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3svARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib3dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib4fARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4sARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4dARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4fvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib4svARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4svARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4dvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttrib4ivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ivARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glVertexAttrib4bvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4bvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glVertexAttrib4usvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4usvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in ushort v);

        [NativeApi(EntryPoint = "glVertexAttrib4uivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4uivARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NbvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NsvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glVertexAttrib4NivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NivARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in byte v);

        [NativeApi(EntryPoint = "glVertexAttrib4NubvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string v);

        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NusvARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in ushort v);

        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4NuivARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] ARB* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out ARB type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<byte> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public unsafe void GetActiveAttrib([Flow(FlowDirection.In)] uint programObj, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "maxLength"), Flow(FlowDirection.Out)] Span<string> name)
        {
            // ImplicitCountSpanOverloader
            GetActiveAttrib(programObj, index, (uint) name.Length, out length, out size, out type, out name.GetPinnableReference());
        }

        public ArbVertexShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

