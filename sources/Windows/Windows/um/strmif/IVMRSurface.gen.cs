// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVMRSurface.xml' path='doc/member[@name="IVMRSurface"]/*' />
[Guid("A9849BBE-9EC8-4263-B764-62730F0D15D0")]
[NativeTypeName("struct IVMRSurface : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRSurface : IVMRSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRSurface));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRSurface*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRSurface*, uint>)(lpVtbl[1]))((IVMRSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRSurface*, uint>)(lpVtbl[2]))((IVMRSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurface.xml' path='doc/member[@name="IVMRSurface.IsSurfaceLocked"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsSurfaceLocked()
    {
        return ((delegate* unmanaged<IVMRSurface*, int>)(lpVtbl[3]))((IVMRSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurface.xml' path='doc/member[@name="IVMRSurface.LockSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockSurface(byte** lpSurface)
    {
        return ((delegate* unmanaged<IVMRSurface*, byte**, int>)(lpVtbl[4]))((IVMRSurface*)Unsafe.AsPointer(ref this), lpSurface);
    }

    /// <include file='IVMRSurface.xml' path='doc/member[@name="IVMRSurface.UnlockSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UnlockSurface()
    {
        return ((delegate* unmanaged<IVMRSurface*, int>)(lpVtbl[5]))((IVMRSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurface.xml' path='doc/member[@name="IVMRSurface.GetSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface)
    {
        return ((delegate* unmanaged<IVMRSurface*, IDirectDrawSurface7**, int>)(lpVtbl[6]))((IVMRSurface*)Unsafe.AsPointer(ref this), lplpSurface);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsSurfaceLocked();

        [VtblIndex(4)]
        HRESULT LockSurface(byte** lpSurface);

        [VtblIndex(5)]
        HRESULT UnlockSurface();

        [VtblIndex(6)]
        HRESULT GetSurface([NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lplpSurface);
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
        public delegate* unmanaged<TSelf*, int> IsSurfaceLocked;

        [NativeTypeName("HRESULT (BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> LockSurface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockSurface;

        [NativeTypeName("HRESULT (LPDIRECTDRAWSURFACE7 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDrawSurface7**, int> GetSurface;
    }
}
