// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWindowForBindingUI.xml' path='doc/member[@name="IWindowForBindingUI"]/*' />
[Guid("79EAC9D5-BAFA-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IWindowForBindingUI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWindowForBindingUI : IWindowForBindingUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowForBindingUI));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWindowForBindingUI*, Guid*, void**, int>)(lpVtbl[0]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWindowForBindingUI*, uint>)(lpVtbl[1]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWindowForBindingUI*, uint>)(lpVtbl[2]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWindowForBindingUI.xml' path='doc/member[@name="IWindowForBindingUI.GetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
    {
        return ((delegate* unmanaged<IWindowForBindingUI*, Guid*, HWND*, int>)(lpVtbl[3]))((IWindowForBindingUI*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd);
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

        [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, HWND*, int> GetWindow;
    }
}
