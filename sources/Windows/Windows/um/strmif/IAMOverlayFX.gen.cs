// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMOverlayFX.xml' path='doc/member[@name="IAMOverlayFX"]/*' />
[Guid("62FAE250-7E65-4460-BFC9-6398B322073C")]
[NativeTypeName("struct IAMOverlayFX : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMOverlayFX : IAMOverlayFX.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMOverlayFX));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMOverlayFX*, Guid*, void**, int>)(lpVtbl[0]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMOverlayFX*, uint>)(lpVtbl[1]))((IAMOverlayFX*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMOverlayFX*, uint>)(lpVtbl[2]))((IAMOverlayFX*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMOverlayFX.xml' path='doc/member[@name="IAMOverlayFX.QueryOverlayFXCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryOverlayFXCaps([NativeTypeName("DWORD *")] uint* lpdwOverlayFXCaps)
    {
        return ((delegate* unmanaged<IAMOverlayFX*, uint*, int>)(lpVtbl[3]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), lpdwOverlayFXCaps);
    }

    /// <include file='IAMOverlayFX.xml' path='doc/member[@name="IAMOverlayFX.SetOverlayFX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOverlayFX([NativeTypeName("DWORD")] uint dwOverlayFX)
    {
        return ((delegate* unmanaged<IAMOverlayFX*, uint, int>)(lpVtbl[4]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), dwOverlayFX);
    }

    /// <include file='IAMOverlayFX.xml' path='doc/member[@name="IAMOverlayFX.GetOverlayFX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOverlayFX([NativeTypeName("DWORD *")] uint* lpdwOverlayFX)
    {
        return ((delegate* unmanaged<IAMOverlayFX*, uint*, int>)(lpVtbl[5]))((IAMOverlayFX*)Unsafe.AsPointer(ref this), lpdwOverlayFX);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryOverlayFXCaps([NativeTypeName("DWORD *")] uint* lpdwOverlayFXCaps);

        [VtblIndex(4)]
        HRESULT SetOverlayFX([NativeTypeName("DWORD")] uint dwOverlayFX);

        [VtblIndex(5)]
        HRESULT GetOverlayFX([NativeTypeName("DWORD *")] uint* lpdwOverlayFX);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> QueryOverlayFXCaps;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOverlayFX;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOverlayFX;
    }
}
