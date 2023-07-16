// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPrintDialogCallback.xml' path='doc/member[@name="IPrintDialogCallback"]/*'/>
[Guid("5852A2C3-6530-11D1-B6A3-0000F8757BF9")]
[NativeTypeName("struct IPrintDialogCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintDialogCallback : IPrintDialogCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintDialogCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, Guid*, void**, int> )(lpVtbl[0]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, uint> )(lpVtbl[1]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, uint> )(lpVtbl[2]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDialogCallback.xml' path='doc/member[@name="IPrintDialogCallback.InitDone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitDone()
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, int> )(lpVtbl[3]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDialogCallback.xml' path='doc/member[@name="IPrintDialogCallback.SelectionChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SelectionChange()
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, int> )(lpVtbl[4]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPrintDialogCallback.xml' path='doc/member[@name="IPrintDialogCallback.HandleMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HandleMessage(HWND hDlg, uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* pResult)
    {
        return ((delegate* unmanaged<IPrintDialogCallback*, HWND, uint, WPARAM, LPARAM, LRESULT*, int> )(lpVtbl[5]))((IPrintDialogCallback*)Unsafe.AsPointer(ref this), hDlg, uMsg, wParam, lParam, pResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitDone();
        [VtblIndex(4)]
        HRESULT SelectionChange();
        [VtblIndex(5)]
        HRESULT HandleMessage(HWND hDlg, uint uMsg, WPARAM wParam, LPARAM lParam, LRESULT* pResult);
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
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InitDone;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SelectionChange;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, LRESULT*, int> HandleMessage;
    }
}