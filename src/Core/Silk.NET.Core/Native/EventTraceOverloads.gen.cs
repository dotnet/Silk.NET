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

namespace Silk.NET.Core.Native
{
    public static class EventTraceOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, ulong* TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, ulong* TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, ulong* TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, ulong* TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, char* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this EventTrace thisApi, Span<ulong> TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, ulong* TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, ulong* TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, ulong* TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, ulong* TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, byte* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this EventTrace thisApi, Span<ulong> TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this EventTrace thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this EventTrace thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this EventTrace thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this EventTrace thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this EventTrace thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this EventTrace thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this EventTrace thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this EventTrace thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this EventTrace thisApi, ulong TraceHandle, char* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this EventTrace thisApi, ulong TraceHandle, Span<char> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this EventTrace thisApi, ulong TraceHandle, byte* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this EventTrace thisApi, ulong TraceHandle, Span<byte> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, ref InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this EventTrace thisApi, ulong TraceHandle, string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this EventTrace thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this EventTrace thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this EventTrace thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this EventTrace thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTrace(this EventTrace thisApi, uint Enable, uint EnableFlag, uint EnableLevel, Span<Guid> ControlGuid, ulong TraceHandle)
        {
            // SpanOverloader
            return thisApi.EnableTrace(Enable, EnableFlag, EnableLevel, ref ControlGuid.GetPinnableReference(), TraceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Guid* ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Guid* ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Span<Guid> ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Span<Guid> ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Span<Guid> ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this EventTrace thisApi, Span<Guid> ProviderId, Span<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ref ProviderId.GetPinnableReference(), ref SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this EventTrace thisApi, ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ProviderId, ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this EventTrace thisApi, ulong TraceHandle, Span<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ref ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, EnableParameters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this EventTrace thisApi, ulong TraceHandle, Span<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ref ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this EventTrace thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1943, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceSetInformation<T0>(this EventTrace thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceSetInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation(this EventTrace thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, TraceInformation, InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this EventTrace thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this EventTrace thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId(this EventTrace thisApi, void* RegHandle, Span<EventInstanceInfo> InstInfo)
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(RegHandle, ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId<T0>(this EventTrace thisApi, Span<T0> RegHandle, EventInstanceInfo* InstInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), InstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId<T0>(this EventTrace thisApi, Span<T0> RegHandle, Span<EventInstanceInfo> InstInfo) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1995, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEvent(this EventTrace thisApi, ulong TraceHandle, Span<EventTraceHeader> EventTrace)
        {
            // SpanOverloader
            return thisApi.TraceEvent(TraceHandle, ref EventTrace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this EventTrace thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, char* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<char> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this EventTrace thisApi, PfnWmidprequest RequestAddress, void* RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, byte* MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, Span<byte> MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), ref MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, Span<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, ref MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this EventTrace thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, Span<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, string MofImagePath, string MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ref ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this EventTrace thisApi, TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this EventTrace thisApi, ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(ref GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2101, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe ulong GetTraceLoggerHandle<T0>(this EventTrace thisApi, Span<T0> Buffer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTraceLoggerHandle(ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2140, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceW(this EventTrace thisApi, Span<EventTraceLogfilew> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceW(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, ulong* HandleArray, uint HandleCount, _FILETIME* StartTime, Span<_FILETIME> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, ulong* HandleArray, uint HandleCount, Span<_FILETIME> StartTime, _FILETIME* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, ulong* HandleArray, uint HandleCount, Span<_FILETIME> StartTime, Span<_FILETIME> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, Span<ulong> HandleArray, uint HandleCount, _FILETIME* StartTime, _FILETIME* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, Span<ulong> HandleArray, uint HandleCount, _FILETIME* StartTime, Span<_FILETIME> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, Span<ulong> HandleArray, uint HandleCount, Span<_FILETIME> StartTime, _FILETIME* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this EventTrace thisApi, Span<ulong> HandleArray, uint HandleCount, Span<_FILETIME> StartTime, Span<_FILETIME> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this EventTrace thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2223, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceA(this EventTrace thisApi, Span<EventTraceLogfilea> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceA(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2230, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint SetTraceCallback(this EventTrace thisApi, Span<Guid> pGuid, PfnPeventCallback EventCallback)
        {
            // SpanOverloader
            return thisApi.SetTraceCallback(ref pGuid.GetPinnableReference(), EventCallback);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint RemoveTraceCallback(this EventTrace thisApi, Span<Guid> pGuid)
        {
            // SpanOverloader
            return thisApi.RemoveTraceCallback(ref pGuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2255, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessage(this EventTrace thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber)
        {
            // SpanOverloader
            return thisApi.TraceMessage(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this EventTrace thisApi, ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, MessageGuid, MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this EventTrace thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, byte* MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this EventTrace thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this EventTrace thisApi, ulong LoggerHandle, uint MessageFlags, Span<Guid> MessageGuid, ushort MessageNumber, string MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, ref MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

    }
}

