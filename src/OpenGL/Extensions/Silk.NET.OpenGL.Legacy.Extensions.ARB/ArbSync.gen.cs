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
    [Extension("ARB_sync")]
    public unsafe partial class ArbSync : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sync";
        [NativeApi(EntryPoint = "glClientWaitSync", Convention = CallingConvention.Winapi)]
        public partial ARB ClientWaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glClientWaitSync", Convention = CallingConvention.Winapi)]
        public partial ARB ClientWaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncObjectMask flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSync", Convention = CallingConvention.Winapi)]
        public partial void DeleteSync([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] ARB condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] ARB condition, [Flow(FlowDirection.In)] SyncBehaviorFlags flags);

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSync", Convention = CallingConvention.Winapi)]
        public partial nint FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] SyncBehaviorFlags flags);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public partial void GetInteger64([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v", Convention = CallingConvention.Winapi)]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv", Convention = CallingConvention.Winapi)]
        public partial void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glIsSync", Convention = CallingConvention.Winapi)]
        public partial bool IsSync([Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "glWaitSync", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glWaitSync", Convention = CallingConvention.Winapi)]
        public partial void WaitSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncBehaviorFlags flags, [Flow(FlowDirection.In)] ulong timeout);

        public unsafe long GetInteger64([Flow(FlowDirection.In)] ARB pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, out length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, length, out values.GetPinnableReference());
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // ImplicitCountSpanOverloader
            GetSync(sync, pname, (uint) values.Length, out length, out values.GetPinnableReference());
        }

        public ArbSync(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

