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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_sync")]
    public unsafe partial class AppleSync : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_sync";
        [NativeApi(EntryPoint = "glClientWaitSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial APPLE ClientWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DeleteSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE condition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glIsSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glWaitSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong timeout);

        public AppleSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

