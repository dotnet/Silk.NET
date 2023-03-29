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
        public static unsafe void LogMessagesToStderr<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToStderr(in errstr.GetPinnableReference(), private_infoSpp, cb, user_dataSpp);
        }

        public static unsafe void LogMessagesToStderr<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToStderr(errstr, private_infoSpp, cb, user_dataSpp);
        }

        public static unsafe void LogMessagesToStdout<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToStdout(in errstr.GetPinnableReference(), private_infoSpp, cb, user_dataSpp);
        }

        public static unsafe void LogMessagesToStdout<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToStdout(errstr, private_infoSpp, cb, user_dataSpp);
        }

        public static unsafe void LogMessagesToSystemLog<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToSystemLog(in errstr.GetPinnableReference(), private_infoSpp, cb, user_dataSpp);
        }

        public static unsafe void LogMessagesToSystemLog<T0, T1>(this AppleContextLoggingFunctions thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string errstr, [Flow(FlowDirection.In)] Span<T0> private_info, [Flow(FlowDirection.In)] nuint cb, [Flow(FlowDirection.Out)] Span<T1> user_data) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* private_infoSpp = private_info)
            fixed (void* user_dataSpp = user_data)
                thisApi.LogMessagesToSystemLog(errstr, private_infoSpp, cb, user_dataSpp);
        }

    }
}

