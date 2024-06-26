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

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVCommandListOverloads
    {
        public static unsafe void CreateCommandLists(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> lists)
        {
            // SpanOverloader
            thisApi.CreateCommandLists(n, out lists.GetPinnableReference());
        }

        public static unsafe void CreateStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> states)
        {
            // SpanOverloader
            thisApi.CreateStates(n, out states.GetPinnableReference());
        }

        public static unsafe void DeleteCommandLists(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> lists)
        {
            // SpanOverloader
            thisApi.DeleteCommandLists(n, in lists.GetPinnableReference());
        }

        public static unsafe void DeleteStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states)
        {
            // SpanOverloader
            thisApi.DeleteStates(n, in states.GetPinnableReference());
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, indirects, in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, in indirects.GetPinnableReference(), sizes, count);
        }

        public static unsafe void DrawCommands(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommands(primitiveMode, buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, indirects, in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, in indirects.GetPinnableReference(), sizes, count);
        }

        public static unsafe void DrawCommandsAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV primitiveMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsAddress(primitiveMode, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStates(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStates(buffer, in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void DrawCommandsStatesAddress(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> indirects, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.DrawCommandsStatesAddress(in indirects.GetPinnableReference(), in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, sizes, in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), states, in fbos.GetPinnableReference(), count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), fbos, count);
        }

        public static unsafe void ListDrawCommandsStatesClient(this NVCommandList thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint segment, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* indirects, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sizes, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> states, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fbos, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            thisApi.ListDrawCommandsStatesClient(list, segment, in indirects, in sizes.GetPinnableReference(), in states.GetPinnableReference(), in fbos.GetPinnableReference(), count);
        }

    }
}

