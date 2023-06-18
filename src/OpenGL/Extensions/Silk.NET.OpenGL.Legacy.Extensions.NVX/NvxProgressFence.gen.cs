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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_progress_fence")]
    public unsafe partial class NvxProgressFence : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_progress_fence";
        [NativeApi(EntryPoint = "glClientWaitSemaphoreui64NVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void ClientWaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* fenceValueArray);

        [NativeApi(EntryPoint = "glCreateProgressFenceNVX", Convention = CallingConvention.Winapi)]
        public partial uint CreateProgressFence();

        [NativeApi(EntryPoint = "glSignalSemaphoreui64NVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint signalGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* fenceValueArray);

        [NativeApi(EntryPoint = "glWaitSemaphoreui64NVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint waitGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fenceObjectCount, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* semaphoreArray, [Count(Parameter = "fenceObjectCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* fenceValueArray);

        public NvxProgressFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

