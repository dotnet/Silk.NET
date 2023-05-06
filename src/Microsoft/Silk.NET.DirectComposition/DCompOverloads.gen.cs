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

namespace Silk.NET.DirectComposition
{
    public static class DCompOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(dxgiDevice, ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Silk.NET.DXGI.IDXGIDevice* dxgiDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(dxgiDevice, ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, Guid* iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), iid, dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, Guid* iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice(this DComp thisApi, Span<Silk.NET.DXGI.IDXGIDevice> dxgiDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice(ref dxgiDevice.GetPinnableReference(), ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Silk.NET.Core.Native.IUnknown* renderingDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(renderingDevice, ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Silk.NET.Core.Native.IUnknown* renderingDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(renderingDevice, ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Guid* iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(ref renderingDevice.GetPinnableReference(), iid, dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Guid* iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(ref renderingDevice.GetPinnableReference(), iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(ref renderingDevice.GetPinnableReference(), ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice2(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice2(ref renderingDevice.GetPinnableReference(), ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Silk.NET.Core.Native.IUnknown* renderingDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(renderingDevice, ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Silk.NET.Core.Native.IUnknown* renderingDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(renderingDevice, ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Guid* iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(ref renderingDevice.GetPinnableReference(), iid, dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Guid* iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(ref renderingDevice.GetPinnableReference(), iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Span<Guid> iid, void** dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(ref renderingDevice.GetPinnableReference(), ref iid.GetPinnableReference(), dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public static unsafe int CreateDevice3(this DComp thisApi, Span<Silk.NET.Core.Native.IUnknown> renderingDevice, Span<Guid> iid, ref void* dcompositionDevice)
        {
            // SpanOverloader
            return thisApi.CreateDevice3(ref renderingDevice.GetPinnableReference(), ref iid.GetPinnableReference(), ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        public static unsafe int CreateSurfaceHandle(this DComp thisApi, uint desiredAccess, Span<Silk.NET.Core.Native.SecurityAttributes> securityAttributes, void** surfaceHandle)
        {
            // SpanOverloader
            return thisApi.CreateSurfaceHandle(desiredAccess, ref securityAttributes.GetPinnableReference(), surfaceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        public static unsafe int CreateSurfaceHandle(this DComp thisApi, uint desiredAccess, Span<Silk.NET.Core.Native.SecurityAttributes> securityAttributes, ref void* surfaceHandle)
        {
            // SpanOverloader
            return thisApi.CreateSurfaceHandle(desiredAccess, ref securityAttributes.GetPinnableReference(), ref surfaceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 8 in dcomp.h")]
        public static unsafe int AttachMouseWheelToHwnd(this DComp thisApi, Span<IDCompositionVisual> visual, nint hwnd, Silk.NET.Core.Bool32 enable)
        {
            // SpanOverloader
            return thisApi.AttachMouseWheelToHwnd(ref visual.GetPinnableReference(), hwnd, enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 8 in dcomp.h")]
        public static unsafe int AttachMouseDragToHwnd(this DComp thisApi, Span<IDCompositionVisual> visual, nint hwnd, Silk.NET.Core.Bool32 enable)
        {
            // SpanOverloader
            return thisApi.AttachMouseDragToHwnd(ref visual.GetPinnableReference(), hwnd, enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 8 in dcomp.h")]
        public static unsafe int GetFrameId(this DComp thisApi, CompositionFrameIDType frameIdType, Span<ulong> frameId)
        {
            // SpanOverloader
            return thisApi.GetFrameId(frameIdType, ref frameId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, CompositionTargetId* targetIds, Span<uint> actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, frameStats, targetIdCount, targetIds, ref actualTargetIdCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, Span<CompositionTargetId> targetIds, uint* actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, frameStats, targetIdCount, ref targetIds.GetPinnableReference(), actualTargetIdCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, Span<CompositionTargetId> targetIds, Span<uint> actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, frameStats, targetIdCount, ref targetIds.GetPinnableReference(), ref actualTargetIdCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, Span<CompositionFrameStats> frameStats, uint targetIdCount, CompositionTargetId* targetIds, uint* actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, ref frameStats.GetPinnableReference(), targetIdCount, targetIds, actualTargetIdCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, Span<CompositionFrameStats> frameStats, uint targetIdCount, CompositionTargetId* targetIds, Span<uint> actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, ref frameStats.GetPinnableReference(), targetIdCount, targetIds, ref actualTargetIdCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, Span<CompositionFrameStats> frameStats, uint targetIdCount, Span<CompositionTargetId> targetIds, uint* actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, ref frameStats.GetPinnableReference(), targetIdCount, ref targetIds.GetPinnableReference(), actualTargetIdCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        public static unsafe int GetStatistics(this DComp thisApi, ulong frameId, Span<CompositionFrameStats> frameStats, uint targetIdCount, Span<CompositionTargetId> targetIds, Span<uint> actualTargetIdCount)
        {
            // SpanOverloader
            return thisApi.GetStatistics(frameId, ref frameStats.GetPinnableReference(), targetIdCount, ref targetIds.GetPinnableReference(), ref actualTargetIdCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        public static unsafe int GetTargetStatistics(this DComp thisApi, ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompositionTargetId* targetId, Span<CompositionTargetStats> targetStats)
        {
            // SpanOverloader
            return thisApi.GetTargetStatistics(frameId, targetId, ref targetStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        public static unsafe int GetTargetStatistics(this DComp thisApi, ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompositionTargetId> targetId, CompositionTargetStats* targetStats)
        {
            // SpanOverloader
            return thisApi.GetTargetStatistics(frameId, in targetId.GetPinnableReference(), targetStats);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        public static unsafe int GetTargetStatistics(this DComp thisApi, ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CompositionTargetId> targetId, Span<CompositionTargetStats> targetStats)
        {
            // SpanOverloader
            return thisApi.GetTargetStatistics(frameId, in targetId.GetPinnableReference(), ref targetStats.GetPinnableReference());
        }

    }
}

