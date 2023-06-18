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
        [NativeName("Src", "Line 84, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice2", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice2(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 102, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateDevice3", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateDevice3(Silk.NET.Core.Native.IUnknown* renderingDevice, Guid* iid, void** dcompositionDevice);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionCreateSurfaceHandle", Convention = CallingConvention.StdCall)]
        public unsafe partial int CreateSurfaceHandle(uint desiredAccess, Silk.NET.Core.Native.SecurityAttributes* securityAttributes, void** surfaceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseWheelToHwnd", Convention = CallingConvention.StdCall)]
        public unsafe partial int AttachMouseWheelToHwnd(IDCompositionVisual* visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 157, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionAttachMouseDragToHwnd", Convention = CallingConvention.StdCall)]
        public unsafe partial int AttachMouseDragToHwnd(IDCompositionVisual* visual, nint hwnd, Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 175, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetFrameId", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetFrameId(CompositionFrameIDType frameIdType, ulong* frameId);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 189, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetStatistics(ulong frameId, CompositionFrameStats* frameStats, uint targetIdCount, CompositionTargetId* targetIds, uint* actualTargetIdCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionGetTargetStatistics", Convention = CallingConvention.StdCall)]
        public unsafe partial int GetTargetStatistics(ulong frameId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompositionTargetId* targetId, CompositionTargetStats* targetStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 8 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionBoostCompositorClock", Convention = CallingConvention.StdCall)]
        public partial int BoostCompositorClock(Silk.NET.Core.Bool32 enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 16 in dcomp.h")]
        [NativeApi(EntryPoint = "DCompositionWaitForCompositorClock", Convention = CallingConvention.StdCall)]
        public unsafe partial uint WaitForCompositorClock(uint count, void** handles, uint timeoutInMs);


        public DComp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

