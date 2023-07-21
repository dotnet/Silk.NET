// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVMRSurfaceAllocator.xml' path='doc/member[@name="IVMRSurfaceAllocator"]/*' />
[Guid("31CE832E-4484-458B-8CCA-F4D7E3DB0B52")]
[NativeTypeName("struct IVMRSurfaceAllocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRSurfaceAllocator : IVMRSurfaceAllocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRSurfaceAllocator));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, uint>)(lpVtbl[1]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, uint>)(lpVtbl[2]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurfaceAllocator.xml' path='doc/member[@name="IVMRSurfaceAllocator.AllocateSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AllocateSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, VMRALLOCATIONINFO* lpAllocInfo, [NativeTypeName("DWORD *")] uint* lpdwActualBuffers, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, nuint, VMRALLOCATIONINFO*, uint*, IDirectDrawSurface7**, int>)(lpVtbl[3]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwUserID, lpAllocInfo, lpdwActualBuffers, lplpSurface);
    }

    /// <include file='IVMRSurfaceAllocator.xml' path='doc/member[@name="IVMRSurfaceAllocator.FreeSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FreeSurface([NativeTypeName("DWORD_PTR")] nuint dwID)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, nuint, int>)(lpVtbl[4]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwID);
    }

    /// <include file='IVMRSurfaceAllocator.xml' path='doc/member[@name="IVMRSurfaceAllocator.PrepareSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PrepareSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpSurface, [NativeTypeName("DWORD")] uint dwSurfaceFlags)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, nuint, IDirectDrawSurface7*, uint, int>)(lpVtbl[5]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), dwUserID, lpSurface, dwSurfaceFlags);
    }

    /// <include file='IVMRSurfaceAllocator.xml' path='doc/member[@name="IVMRSurfaceAllocator.AdviseNotify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AdviseNotify(IVMRSurfaceAllocatorNotify* lpIVMRSurfAllocNotify)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocator*, IVMRSurfaceAllocatorNotify*, int>)(lpVtbl[6]))((IVMRSurfaceAllocator*)Unsafe.AsPointer(ref this), lpIVMRSurfAllocNotify);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AllocateSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, VMRALLOCATIONINFO* lpAllocInfo, [NativeTypeName("DWORD *")] uint* lpdwActualBuffers, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface);

        [VtblIndex(4)]
        HRESULT FreeSurface([NativeTypeName("DWORD_PTR")] nuint dwID);

        [VtblIndex(5)]
        HRESULT PrepareSurface([NativeTypeName("DWORD_PTR")] nuint dwUserID, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpSurface, [NativeTypeName("DWORD")] uint dwSurfaceFlags);

        [VtblIndex(6)]
        HRESULT AdviseNotify(IVMRSurfaceAllocatorNotify* lpIVMRSurfAllocNotify);
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

        [NativeTypeName("HRESULT (DWORD_PTR, VMRALLOCATIONINFO *, DWORD *, LPDIRECTDRAWSURFACE7 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, VMRALLOCATIONINFO*, uint*, IDirectDrawSurface7**, int> AllocateSurface;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> FreeSurface;

        [NativeTypeName("HRESULT (DWORD_PTR, LPDIRECTDRAWSURFACE7, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, IDirectDrawSurface7*, uint, int> PrepareSurface;

        [NativeTypeName("HRESULT (IVMRSurfaceAllocatorNotify *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVMRSurfaceAllocatorNotify*, int> AdviseNotify;
    }
}
