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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_sync")]
    public unsafe partial class ArbSync : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sync";
        [NativeApi(EntryPoint = "glClientWaitSync", Convention = CallingConvention.Winapi)]
        public partial ARB ClientWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSync", Convention = CallingConvention.Winapi)]
        public partial void DeleteSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glIsSync", Convention = CallingConvention.Winapi)]
        public partial bool IsSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glWaitSync", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        public ArbSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

