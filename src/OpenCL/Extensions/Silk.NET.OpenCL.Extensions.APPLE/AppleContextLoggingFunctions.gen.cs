// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_ContextLoggingFunctions")]
    public unsafe partial class AppleContextLoggingFunctions : NativeExtension<CL>
    {
        public const string ExtensionName = "APPLE_ContextLoggingFunctions";
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToStderr(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToStderr<T0, T1>(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToStdout(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToStdout<T0, T1>(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToSystemLog(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToSystemLog<T0, T1>(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToStderr(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToStderr<T0, T1>(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToStdout(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToStdout<T0, T1>(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data)
            => ImplLogMessagesToSystemLog(errstr, private_info, cb, user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
            => ImplLogMessagesToSystemLog<T0, T1>(errstr, private_info, cb, user_data);

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public AppleContextLoggingFunctions(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

