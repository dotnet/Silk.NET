// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfSystemLangBarItemText.xml' path='doc/member[@name="ITfSystemLangBarItemText"]/*'/>
[Guid("5C4CE0E5-BA49-4B52-AC6B-3B397B4F701F")]
[NativeTypeName("struct ITfSystemLangBarItemText : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSystemLangBarItemText : ITfSystemLangBarItemText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSystemLangBarItemText));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemText*, Guid*, void**, int> )(lpVtbl[0]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemText*, uint> )(lpVtbl[1]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemText*, uint> )(lpVtbl[2]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSystemLangBarItemText.xml' path='doc/member[@name="ITfSystemLangBarItemText.SetItemText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetItemText([NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemText*, ushort*, uint, int> )(lpVtbl[3]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), pch, cch);
    }

    /// <include file='ITfSystemLangBarItemText.xml' path='doc/member[@name="ITfSystemLangBarItemText.GetItemText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemText([NativeTypeName("BSTR *")] ushort** pbstrText)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItemText*, ushort**, int> )(lpVtbl[4]))((ITfSystemLangBarItemText*)Unsafe.AsPointer(ref this), pbstrText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetItemText([NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch);
        [VtblIndex(4)]
        HRESULT GetItemText([NativeTypeName("BSTR *")] ushort** pbstrText);
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
        [NativeTypeName("HRESULT (const WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetItemText;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetItemText;
    }
}