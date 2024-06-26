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
    public unsafe partial class DComp : NativeAPI
    {
        [NativeName("Type", "long")]
        [NativeName("Name", "COMPOSITIONOBJECT_READ")]
        public const int CompositionobjectRead = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "COMPOSITIONOBJECT_WRITE")]
        public const int CompositionobjectWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DCOMPOSITION_MAX_WAITFORCOMPOSITORCLOCK_OBJECTS")]
        public const int MaxWaitforcompositorclockObjects = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPOSITION_STATS_MAX_TARGETS")]
        public const int CompositionStatsMaxTargets = unchecked((int) 0x100);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(Silk.NET.Core.Native.IUnknown* renderingDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(Silk.NET.Core.Native.IUnknown* renderingDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(ref Silk.NET.Core.Native.IUnknown renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(ref Silk.NET.Core.Native.IUnknown renderingDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(Silk.NET.Core.Native.IUnknown* renderingDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(Silk.NET.Core.Native.IUnknown* renderingDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(ref Silk.NET.Core.Native.IUnknown renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(ref Silk.NET.Core.Native.IUnknown renderingDevice, Guid* iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref Guid iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(ref Silk.NET.Core.Native.IUnknown renderingDevice, ref Guid iid, ref void* dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateSurfaceHandle", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateSurfaceHandle(uint desiredAccess, Silk.NET.Core.Native.SecurityAttributes* securityAttributes, void** surfaceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateSurfaceHandle", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateSurfaceHandle(uint desiredAccess, Silk.NET.Core.Native.SecurityAttributes* securityAttributes, ref void* surfaceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateSurfaceHandle", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateSurfaceHandle(uint desiredAccess, ref Silk.NET.Core.Native.SecurityAttributes securityAttributes, void** surfaceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateSurfaceHandle", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateSurfaceHandle(uint desiredAccess, ref Silk.NET.Core.Native.SecurityAttributes securityAttributes, ref void* surfaceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseWheelToHwnd", Convention = CallingConvention.StdCall)]
        public unsafe partial int AttachMouseWheelToHwnd(IDCompositionVisual* visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseWheelToHwnd", Convention = CallingConvention.StdCall)]
        public partial int AttachMouseWheelToHwnd(ref IDCompositionVisual visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseDragToHwnd", Convention = CallingConvention.StdCall)]
        public unsafe partial int AttachMouseDragToHwnd(IDCompositionVisual* visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseDragToHwnd", Convention = CallingConvention.StdCall)]
        public partial int AttachMouseDragToHwnd(ref IDCompositionVisual visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetFrameId", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFrameId(CompositionFrameIDType frameIdType, ulong* frameId);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetFrameId", Convention = CallingConvention.StdCall)]
        public partial int GetFrameId(CompositionFrameIDType frameIdType, ref ulong frameId);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, CompositionTargetId* targetIds, uint* actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, CompositionTargetId* targetIds, ref uint actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, ref CompositionTargetId targetIds, uint* actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, ref CompositionTargetId targetIds, ref uint actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, ref CompositionFrameStats frameStats, uint targetIdCount, CompositionTargetId* targetIds, uint* actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, ref CompositionFrameStats frameStats, uint targetIdCount, CompositionTargetId* targetIds, ref uint actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, ref CompositionFrameStats frameStats, uint targetIdCount, ref CompositionTargetId targetIds, uint* actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public partial int GetStatistics(ulong frameId, ref CompositionFrameStats frameStats, uint targetIdCount, ref CompositionTargetId targetIds, ref uint actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetTargetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetTargetStatistics(ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompositionTargetId* targetId, CompositionTargetStats* targetStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetTargetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetTargetStatistics(ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompositionTargetId* targetId, ref CompositionTargetStats targetStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetTargetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetTargetStatistics(ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CompositionTargetId targetId, CompositionTargetStats* targetStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetTargetStatistics", Convention = CallingConvention.StdCall)]
        public partial int GetTargetStatistics(ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in CompositionTargetId targetId, ref CompositionTargetStats targetStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionBoostCompositorClock", Convention = CallingConvention.StdCall)]
        public partial int BoostCompositorClock(Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 16 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionWaitForCompositorClock", Convention = CallingConvention.StdCall)]
        public unsafe partial uint WaitForCompositorClock(uint count, void** handles, uint timeoutInMs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 16 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionWaitForCompositorClock", Convention = CallingConvention.StdCall)]
        public unsafe partial uint WaitForCompositorClock(uint count, ref void* handles, uint timeoutInMs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public unsafe int CreateDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice, out ComPtr<TI0> dcompositionDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice(dxgiDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public unsafe int CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice, out ComPtr<TI0> dcompositionDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice(ref dxgiDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe int CreateDevice2<TI0, TI1>(ComPtr<TI0> renderingDevice, out ComPtr<TI1> dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice2((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe int CreateDevice2<TI0>(ComPtr<TI0> renderingDevice, Guid* iid, ref void* dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice2((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe int CreateDevice2<TI0>(ComPtr<TI0> renderingDevice, ref Guid iid, void** dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice2((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref iid, dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe int CreateDevice2<TI0>(ComPtr<TI0> renderingDevice, ref Guid iid, ref void* dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice2((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe int CreateDevice2<TI0>(ref Silk.NET.Core.Native.IUnknown renderingDevice, out ComPtr<TI0> dcompositionDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice2(ref renderingDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe int CreateDevice3<TI0, TI1>(ComPtr<TI0> renderingDevice, out ComPtr<TI1> dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice3((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe int CreateDevice3<TI0>(ComPtr<TI0> renderingDevice, Guid* iid, ref void* dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice3((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe int CreateDevice3<TI0>(ComPtr<TI0> renderingDevice, ref Guid iid, void** dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice3((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref iid, dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe int CreateDevice3<TI0>(ComPtr<TI0> renderingDevice, ref Guid iid, ref void* dcompositionDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return CreateDevice3((Silk.NET.Core.Native.IUnknown*) renderingDevice.Handle, ref iid, ref dcompositionDevice);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe int CreateDevice3<TI0>(ref Silk.NET.Core.Native.IUnknown renderingDevice, out ComPtr<TI0> dcompositionDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // ComPtrOverloader
            dcompositionDevice = default;
            return CreateDevice3(ref renderingDevice, SilkMarshal.GuidPtrOf<TI0>(), (void**) dcompositionDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 8 in dcomp.h")]
        public unsafe int AttachMouseWheelToHwnd<TI0>(ComPtr<TI0> visual, nint hwnd, Silk.NET.Core.Bool32 enable) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return AttachMouseWheelToHwnd((IDCompositionVisual*) visual.Handle, hwnd, enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 8 in dcomp.h")]
        public unsafe int AttachMouseDragToHwnd<TI0>(ComPtr<TI0> visual, nint hwnd, Silk.NET.Core.Bool32 enable) where TI0 : unmanaged, IComVtbl<IDCompositionVisual>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return AttachMouseDragToHwnd((IDCompositionVisual*) visual.Handle, hwnd, enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI0> CreateDevice<TI0>(Silk.NET.DXGI.IDXGIDevice* dxgiDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice(dxgiDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI0> CreateDevice<TI0>(ref Silk.NET.DXGI.IDXGIDevice dxgiDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice(ref dxgiDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI1> CreateDevice2<TI0, TI1>(ComPtr<TI0> renderingDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice2(renderingDevice, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI0> CreateDevice2<TI0>(ref Silk.NET.Core.Native.IUnknown renderingDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice2(ref renderingDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI1> CreateDevice3<TI0, TI1>(ComPtr<TI0> renderingDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice3(renderingDevice, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        public unsafe ComPtr<TI0> CreateDevice3<TI0>(ref Silk.NET.Core.Native.IUnknown renderingDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(CreateDevice3(ref renderingDevice, out ComPtr<TI0> silkRet));
            return silkRet;
        }


        public DComp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

