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
        public partial APPLE ClientWaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glClientWaitSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial APPLE ClientWaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncObjectMask flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DeleteSync([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] APPLE condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] APPLE condition, [Flow(FlowDirection.In)] SyncBehaviorFlags flags);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] SyncBehaviorFlags flags);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GetInteger64([Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInteger64vAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSyncivAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glIsSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial bool IsSync([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glWaitSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glWaitSyncAPPLE", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncBehaviorFlags flags, [Flow(FlowDirection.In)] ulong timeout);

        public unsafe long GetInteger64([Flow(FlowDirection.In)] APPLE pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, out length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, out length, out values.GetPinnableReference());
        }

        public AppleSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

