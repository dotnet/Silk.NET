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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_timeline_semaphore")]
    public unsafe partial class NVTimelineSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_timeline_semaphore";
        [NativeApi(EntryPoint = "glCreateSemaphoresNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glCreateSemaphoresNV", Convention = CallingConvention.Winapi)]
        public partial void CreateSemaphores([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void GetSemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void SemaphoreParameter([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] SemaphoreParameterName pname, [Flow(FlowDirection.In)] in int @params);

        public unsafe uint CreateSemaphore()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSemaphores(n, &ret);
            return ret;
        }

        public unsafe void CreateSemaphores([Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> semaphores)
        {
            // ImplicitCountSpanOverloader
            CreateSemaphores((uint) semaphores.Length, out semaphores.GetPinnableReference());
        }

        public NVTimelineSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

