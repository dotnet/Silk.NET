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

namespace Silk.NET.Core.Win32Extras
{
    public static class WindowsOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, char* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1612, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, byte* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1627, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1654, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1669, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1695, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1730, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1739, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1767, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1784, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1803, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1819, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1837, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1846, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1865, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTrace(this Windows thisApi, uint Enable, uint EnableFlag, uint EnableLevel, Span<Guid> ControlGuid, ulong TraceHandle)
        {
            // SpanOverloader
            return thisApi.EnableTrace(Enable, EnableFlag, EnableLevel, ref ControlGuid.GetPinnableReference(), TraceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Guid* ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Guid* ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Span<Guid> ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Span<Guid> ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Span<Guid> ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1887, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, Span<Guid> ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ProviderId, ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, Span<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ref ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, EnableParameters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1934, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, Span<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ref ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2298, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2350, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceSetInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceSetInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, TraceInformation, InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2362, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId(this Windows thisApi, void* RegHandle, Span<EventInstanceInfo> InstInfo)
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(RegHandle, ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId<T0>(this Windows thisApi, Span<T0> RegHandle, EventInstanceInfo* InstInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), InstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2384, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId<T0>(this Windows thisApi, Span<T0> RegHandle, Span<EventInstanceInfo> InstInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2402, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEvent(this Windows thisApi, ulong TraceHandle, Span<EventTraceHeader> EventTrace)
        {
            // SpanOverloader
            return thisApi.TraceEvent(TraceHandle, ref EventTrace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2416, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2450, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2470, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2485, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(ref GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2508, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe ulong GetTraceLoggerHandle<T0>(this Windows thisApi, Span<T0> Buffer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTraceLoggerHandle(ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2547, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceW(this Windows thisApi, Span<EventTraceLogfilew> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceW(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2555, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2600, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceA(this Windows thisApi, Span<EventTraceLogfilea> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceA(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2637, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint SetTraceCallback(this Windows thisApi, Span<Guid> pGuid, PfnPeventCallback EventCallback)
        {
            // SpanOverloader
            return thisApi.SetTraceCallback(ref pGuid.GetPinnableReference(), EventCallback);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2645, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint RemoveTraceCallback(this Windows thisApi, Span<Guid> pGuid)
        {
            // SpanOverloader
            return thisApi.RemoveTraceCallback(ref pGuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2662, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessage(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber)
        {
            // SpanOverloader
            return thisApi.TraceMessage(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, MessageGuid, MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, byte* MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 1 in D:/Windows Kits/10/Include/10.0.22000.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

    }
}

