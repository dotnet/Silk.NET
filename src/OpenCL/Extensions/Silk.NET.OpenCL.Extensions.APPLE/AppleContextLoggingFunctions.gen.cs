// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_ContextLoggingFunctions")]
    public abstract unsafe partial class AppleContextLoggingFunctions : NativeExtension<CL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        public abstract unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        public abstract void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        public abstract unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        public abstract void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        public abstract unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        public abstract void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        public abstract unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE")]
        public abstract void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        public abstract unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE")]
        public abstract void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        public abstract unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] void* user_data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE")]
        public abstract void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] UIntPtr cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged;

        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] char* errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] Span<char> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStderr([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStderr<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStderr(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStdout([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToStdout<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToStdout(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToSystemLog([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] void* private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] void* user_data)
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public unsafe void LogMessagesToSystemLog<T0, T1>([Flow(FlowDirection.In)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] uint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // IntPtrOverloader
            LogMessagesToSystemLog(errstr, private_info, new UIntPtr(cb), user_data);
        }

        public AppleContextLoggingFunctions(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

