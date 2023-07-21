// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfMenu.xml' path='doc/member[@name="ITfMenu"]/*' />
[Guid("6F8A98E4-AAA0-4F15-8C5B-07E0DF0A3DD8")]
[NativeTypeName("struct ITfMenu : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMenu : ITfMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMenu));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMenu*, Guid*, void**, int>)(lpVtbl[0]))((ITfMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfMenu*, uint>)(lpVtbl[1]))((ITfMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMenu*, uint>)(lpVtbl[2]))((ITfMenu*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMenu.xml' path='doc/member[@name="ITfMenu.AddMenuItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddMenuItem(uint uId, [NativeTypeName("DWORD")] uint dwFlags, HBITMAP hbmp, HBITMAP hbmpMask, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch, ITfMenu** ppMenu)
    {
        return ((delegate* unmanaged<ITfMenu*, uint, uint, HBITMAP, HBITMAP, ushort*, uint, ITfMenu**, int>)(lpVtbl[3]))((ITfMenu*)Unsafe.AsPointer(ref this), uId, dwFlags, hbmp, hbmpMask, pch, cch, ppMenu);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddMenuItem(uint uId, [NativeTypeName("DWORD")] uint dwFlags, HBITMAP hbmp, HBITMAP hbmpMask, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch, ITfMenu** ppMenu);
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

        [NativeTypeName("HRESULT (UINT, DWORD, HBITMAP, HBITMAP, const WCHAR *, ULONG, ITfMenu **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, HBITMAP, HBITMAP, ushort*, uint, ITfMenu**, int> AddMenuItem;
    }
}
