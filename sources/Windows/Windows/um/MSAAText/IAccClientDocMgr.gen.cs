// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAccClientDocMgr.xml' path='doc/member[@name="IAccClientDocMgr"]/*' />
[Guid("4C896039-7B6D-49E6-A8C1-45116A98292B")]
[NativeTypeName("struct IAccClientDocMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccClientDocMgr : IAccClientDocMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccClientDocMgr));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, Guid*, void**, int>)(lpVtbl[0]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, uint>)(lpVtbl[1]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, uint>)(lpVtbl[2]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAccClientDocMgr.xml' path='doc/member[@name="IAccClientDocMgr.GetDocuments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDocuments(IEnumUnknown** enumUnknown)
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, IEnumUnknown**, int>)(lpVtbl[3]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), enumUnknown);
    }

    /// <include file='IAccClientDocMgr.xml' path='doc/member[@name="IAccClientDocMgr.LookupByHWND"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LookupByHWND(HWND hWnd, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, HWND, Guid*, IUnknown**, int>)(lpVtbl[4]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), hWnd, riid, ppunk);
    }

    /// <include file='IAccClientDocMgr.xml' path='doc/member[@name="IAccClientDocMgr.LookupByPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, POINT, Guid*, IUnknown**, int>)(lpVtbl[5]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), pt, riid, ppunk);
    }

    /// <include file='IAccClientDocMgr.xml' path='doc/member[@name="IAccClientDocMgr.GetFocused"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IAccClientDocMgr*, Guid*, IUnknown**, int>)(lpVtbl[6]))((IAccClientDocMgr*)Unsafe.AsPointer(ref this), riid, ppunk);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDocuments(IEnumUnknown** enumUnknown);

        [VtblIndex(4)]
        HRESULT LookupByHWND(HWND hWnd, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(5)]
        HRESULT LookupByPoint(POINT pt, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(6)]
        HRESULT GetFocused([NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);
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

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown**, int> GetDocuments;

        [NativeTypeName("HRESULT (HWND, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, IUnknown**, int> LookupByHWND;

        [NativeTypeName("HRESULT (POINT, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, Guid*, IUnknown**, int> LookupByPoint;

        [NativeTypeName("HRESULT (const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown**, int> GetFocused;
    }
}
