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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_multimode_draw_arrays")]
    public unsafe partial class IbmMultimodeDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_multimode_draw_arrays";
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM", Convention = CallingConvention.Winapi)]
        public partial void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride);

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, (uint) first.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, first, in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, in first.GetPinnableReference(), count, (uint) first.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, first, in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, in first.GetPinnableReference(), count, (uint) first.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, first, in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, in first.GetPinnableReference(), count, (uint) first.Length, modestride);
        }

        public unsafe void MultiModeDrawArrays([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawArrays(in mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in IBM mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType* mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, indices, (uint) count.Length, modestride);
        }

        public unsafe void MultiModeDrawElements([Count(Computed = "primcount, modestride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int modestride)
        {
            // ImplicitCountSpanOverloader
            MultiModeDrawElements(in mode, in count.GetPinnableReference(), type, in indices, (uint) count.Length, modestride);
        }

        public IbmMultimodeDrawArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

