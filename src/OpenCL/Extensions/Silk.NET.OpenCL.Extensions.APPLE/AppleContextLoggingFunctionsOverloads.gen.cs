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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.APPLE
{
    public static class AppleContextLoggingFunctionsOverloads
    {
        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStderr<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStderr(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(in errstr.GetPinnableReference(), private_info, cb, user_data);
        }

        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(in errstr.GetPinnableReference(), private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStderr<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStderr<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStderr<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStderr(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStdout<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(in errstr.GetPinnableReference(), private_info, cb, user_data);
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(in errstr.GetPinnableReference(), private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStdout<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToStdout<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToStdout<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToStdout(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToSystemLog<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data)
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(in errstr.GetPinnableReference(), private_info, cb, user_data);
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(in errstr.GetPinnableReference(), private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToSystemLog<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(in errstr.GetPinnableReference(), in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, private_info, cb, out user_data.GetPinnableReference());
        }

        public static unsafe void LogMessagesToSystemLog<T0>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* user_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, in private_info.GetPinnableReference(), cb, user_data);
        }

        public static unsafe void LogMessagesToSystemLog<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> private_info, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint cb, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T1> user_data) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.LogMessagesToSystemLog(errstr, in private_info.GetPinnableReference(), cb, out user_data.GetPinnableReference());
        }

    }
}

