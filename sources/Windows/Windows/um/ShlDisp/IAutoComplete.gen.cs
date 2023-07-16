// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAutoComplete.xml' path='doc/member[@name="IAutoComplete"]/*'/>
[Guid("00BB2762-6A77-11D0-A535-00C04FD7D062")]
[NativeTypeName("struct IAutoComplete : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAutoComplete : IAutoComplete.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAutoComplete));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAutoComplete*, Guid*, void**, int> )(lpVtbl[0]))((IAutoComplete*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAutoComplete*, uint> )(lpVtbl[1]))((IAutoComplete*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAutoComplete*, uint> )(lpVtbl[2]))((IAutoComplete*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAutoComplete.xml' path='doc/member[@name="IAutoComplete.Init"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(HWND hwndEdit, IUnknown* punkACL, [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath, [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete)
    {
        return ((delegate* unmanaged<IAutoComplete*, HWND, IUnknown*, ushort*, ushort*, int> )(lpVtbl[3]))((IAutoComplete*)Unsafe.AsPointer(ref this), hwndEdit, punkACL, pwszRegKeyPath, pwszQuickComplete);
    }

    /// <include file='IAutoComplete.xml' path='doc/member[@name="IAutoComplete.Enable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IAutoComplete*, BOOL, int> )(lpVtbl[4]))((IAutoComplete*)Unsafe.AsPointer(ref this), fEnable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(HWND hwndEdit, IUnknown* punkACL, [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath, [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete);
        [VtblIndex(4)]
        HRESULT Enable(BOOL fEnable);
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
        [NativeTypeName("HRESULT (HWND, IUnknown *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown*, ushort*, ushort*, int> Init;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;
    }
}