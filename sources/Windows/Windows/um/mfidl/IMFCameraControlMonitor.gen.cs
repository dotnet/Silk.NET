// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor"]/*'/>
[Guid("4D46F2C9-28BA-4970-8C7B-1F0C9D80AF69")]
[NativeTypeName("struct IMFCameraControlMonitor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCameraControlMonitor : IMFCameraControlMonitor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCameraControlMonitor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, Guid*, void**, int> )(lpVtbl[0]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, uint> )(lpVtbl[1]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, uint> )(lpVtbl[2]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, int> )(lpVtbl[3]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, int> )(lpVtbl[4]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor.AddControlSubscription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddControlSubscription(Guid controlSet, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, Guid, uint, int> )(lpVtbl[5]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this), controlSet, id);
    }

    /// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor.RemoveControlSubscription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveControlSubscription(Guid controlSet, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IMFCameraControlMonitor*, Guid, uint, int> )(lpVtbl[6]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this), controlSet, id);
    }

    /// <include file='IMFCameraControlMonitor.xml' path='doc/member[@name="IMFCameraControlMonitor.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Shutdown()
    {
        ((delegate* unmanaged<IMFCameraControlMonitor*, void> )(lpVtbl[7]))((IMFCameraControlMonitor*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Start();
        [VtblIndex(4)]
        HRESULT Stop();
        [VtblIndex(5)]
        HRESULT AddControlSubscription(Guid controlSet, [NativeTypeName("UINT32")] uint id);
        [VtblIndex(6)]
        HRESULT RemoveControlSubscription(Guid controlSet, [NativeTypeName("UINT32")] uint id);
        [VtblIndex(7)]
        void Shutdown();
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
        [NativeTypeName("HRESULT (GUID, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint, int> AddControlSubscription;
        [NativeTypeName("HRESULT (GUID, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint, int> RemoveControlSubscription;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Shutdown;
    }
}