// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IThumbnailCachePrimer.xml' path='doc/member[@name="IThumbnailCachePrimer"]/*' />
[Guid("0F03F8FE-2B26-46F0-965A-212AA8D66B76")]
[NativeTypeName("struct IThumbnailCachePrimer : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IThumbnailCachePrimer : IThumbnailCachePrimer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailCachePrimer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailCachePrimer*, Guid*, void**, int>)(lpVtbl[0]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IThumbnailCachePrimer*, uint>)(lpVtbl[1]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailCachePrimer*, uint>)(lpVtbl[2]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IThumbnailCachePrimer.xml' path='doc/member[@name="IThumbnailCachePrimer.PageInThumbnail"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PageInThumbnail(IShellItem* psi, WTS_FLAGS wtsFlags, uint cxyRequestedThumbSize)
    {
        return ((delegate* unmanaged<IThumbnailCachePrimer*, IShellItem*, WTS_FLAGS, uint, int>)(lpVtbl[3]))((IThumbnailCachePrimer*)Unsafe.AsPointer(ref this), psi, wtsFlags, cxyRequestedThumbSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PageInThumbnail(IShellItem* psi, WTS_FLAGS wtsFlags, uint cxyRequestedThumbSize);
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

        [NativeTypeName("HRESULT (IShellItem *, WTS_FLAGS, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, WTS_FLAGS, uint, int> PageInThumbnail;
    }
}
