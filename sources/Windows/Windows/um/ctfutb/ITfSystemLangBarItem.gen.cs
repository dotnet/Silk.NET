// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfSystemLangBarItem.xml' path='doc/member[@name="ITfSystemLangBarItem"]/*'/>
[Guid("1E13E9EC-6B33-4D4A-B5EB-8A92F029F356")]
[NativeTypeName("struct ITfSystemLangBarItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSystemLangBarItem : ITfSystemLangBarItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSystemLangBarItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem*, Guid*, void**, int> )(lpVtbl[0]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem*, uint> )(lpVtbl[1]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem*, uint> )(lpVtbl[2]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSystemLangBarItem.xml' path='doc/member[@name="ITfSystemLangBarItem.SetIcon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIcon(HICON hIcon)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem*, HICON, int> )(lpVtbl[3]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), hIcon);
    }

    /// <include file='ITfSystemLangBarItem.xml' path='doc/member[@name="ITfSystemLangBarItem.SetTooltipString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTooltipString([NativeTypeName("WCHAR *")] ushort* pchToolTip, [NativeTypeName("ULONG")] uint cch)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem*, ushort*, uint, int> )(lpVtbl[4]))((ITfSystemLangBarItem*)Unsafe.AsPointer(ref this), pchToolTip, cch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIcon(HICON hIcon);
        [VtblIndex(4)]
        HRESULT SetTooltipString([NativeTypeName("WCHAR *")] ushort* pchToolTip, [NativeTypeName("ULONG")] uint cch);
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
        [NativeTypeName("HRESULT (HICON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, int> SetIcon;
        [NativeTypeName("HRESULT (WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetTooltipString;
    }
}