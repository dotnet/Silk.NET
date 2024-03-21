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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    [Extension("APPLE_ContextLoggingFunctions")]
    public unsafe partial class AppleContextLoggingFunctions : NativeExtension<CL>
    {
        public const string ExtensionName = "APPLE_ContextLoggingFunctions";
        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStderrAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToStdoutAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data);

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clLogMessagesToSystemLogAPPLE", Convention = CallingConvention.Winapi)]
        public partial void LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T1 user_data) where T0 : unmanaged where T1 : unmanaged;

        public unsafe T0 LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(in errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(in errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToStderr<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStderr<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStderr(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(in errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(in errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToStdout<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToStdout<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToStdout(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(in errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(in errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public unsafe T0 LogMessagesToSystemLog<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(errstr, private_info, cb, out T0 silkRet);
            return silkRet;
        }

        public unsafe T1 LogMessagesToSystemLog<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb) where T0 : unmanaged where T1 : unmanaged
        {
            // NonKhrReturnTypeOverloader
            LogMessagesToSystemLog(errstr, in private_info, cb, out T1 silkRet);
            return silkRet;
        }

        public AppleContextLoggingFunctions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

