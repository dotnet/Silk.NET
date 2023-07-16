// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFCameraOcclusionStateMonitor.xml' path='doc/member[@name="IMFCameraOcclusionStateMonitor"]/*'/>
[Guid("CC692F46-C697-47E2-A72D-7B064617749B")]
[NativeTypeName("struct IMFCameraOcclusionStateMonitor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraOcclusionStateMonitor : IMFCameraOcclusionStateMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraOcclusionStateMonitor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, Guid*, void**, int> )(lpVtbl[0]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, uint> )(lpVtbl[1]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, uint> )(lpVtbl[2]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraOcclusionStateMonitor.xml' path='doc/member[@name="IMFCameraOcclusionStateMonitor.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, int> )(lpVtbl[3]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraOcclusionStateMonitor.xml' path='doc/member[@name="IMFCameraOcclusionStateMonitor.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, int> )(lpVtbl[4]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraOcclusionStateMonitor.xml' path='doc/member[@name="IMFCameraOcclusionStateMonitor.GetSupportedStates"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("DWORD")]
    public uint GetSupportedStates()
    {
        return ((delegate* unmanaged<IMFCameraOcclusionStateMonitor*, uint> )(lpVtbl[5]))((IMFCameraOcclusionStateMonitor*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Start();
        [VtblIndex(4)]
        HRESULT Stop();
        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        uint GetSupportedStates();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSupportedStates;
    }
}