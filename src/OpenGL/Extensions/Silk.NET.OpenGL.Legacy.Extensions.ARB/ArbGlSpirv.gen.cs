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
    [Extension("ARB_gl_spirv")]
    public unsafe partial class ArbGlSpirv : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_gl_spirv";
        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShaderARB", Convention = CallingConvention.Winapi)]
        public partial void SpecializeShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numSpecializationConstants, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pConstantValue);

        public ArbGlSpirv(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

