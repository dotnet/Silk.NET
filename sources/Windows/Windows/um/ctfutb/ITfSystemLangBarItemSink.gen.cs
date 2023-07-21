// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfSystemLangBarItemSink.xml' path='doc/member[@name="ITfSystemLangBarItemSink"]/*' />
[Guid("1449D9AB-13CF-4687-AA3E-8D8B18574396")]
[NativeTypeName("struct ITfSystemLangBarItemSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSystemLangBarItemSink : ITfSystemLangBarItemSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSystemLangBarItemSink));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint>)(lpVtbl[1]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint>)(lpVtbl[2]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSystemLangBarItemSink.xml' path='doc/member[@name="ITfSystemLangBarItemSink.InitMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitMenu(ITfMenu* pMenu)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemSink*, ITfMenu*, int>)(lpVtbl[3]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), pMenu);
    }

    /// <include file='ITfSystemLangBarItemSink.xml' path='doc/member[@name="ITfSystemLangBarItemSink.OnMenuSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnMenuSelect(uint wID)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemSink*, uint, int>)(lpVtbl[4]))((ITfSystemLangBarItemSink*)Unsafe.AsPointer(ref this), wID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitMenu(ITfMenu* pMenu);

        [VtblIndex(4)]
        HRESULT OnMenuSelect(uint wID);
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

        [NativeTypeName("HRESULT (ITfMenu *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfMenu*, int> InitMenu;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnMenuSelect;
    }
}
