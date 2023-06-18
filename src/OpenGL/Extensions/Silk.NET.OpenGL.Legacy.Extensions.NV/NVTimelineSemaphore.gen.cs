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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_timeline_semaphore")]
    public unsafe partial class NVTimelineSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_timeline_semaphore";
        [NativeApi(EntryPoint = "glCreateSemaphoresNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glSemaphoreParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        public NVTimelineSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

