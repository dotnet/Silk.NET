// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAutoCompleteDropDown.xml' path='doc/member[@name="IAutoCompleteDropDown"]/*' />
[Guid("3CD141F4-3C6A-11D2-BCAA-00C04FD929DB")]
[NativeTypeName("struct IAutoCompleteDropDown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAutoCompleteDropDown : IAutoCompleteDropDown.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAutoCompleteDropDown));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAutoCompleteDropDown*, Guid*, void**, int>)(lpVtbl[0]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAutoCompleteDropDown*, uint>)(lpVtbl[1]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAutoCompleteDropDown*, uint>)(lpVtbl[2]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAutoCompleteDropDown.xml' path='doc/member[@name="IAutoCompleteDropDown.GetDropDownStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDropDownStatus([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszString)
    {
        return ((delegate* unmanaged<IAutoCompleteDropDown*, uint*, ushort**, int>)(lpVtbl[3]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this), pdwFlags, ppwszString);
    }

    /// <include file='IAutoCompleteDropDown.xml' path='doc/member[@name="IAutoCompleteDropDown.ResetEnumerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ResetEnumerator()
    {
        return ((delegate* unmanaged<IAutoCompleteDropDown*, int>)(lpVtbl[4]))((IAutoCompleteDropDown*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDropDownStatus([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPWSTR *")] ushort** ppwszString);

        [VtblIndex(4)]
        HRESULT ResetEnumerator();
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

        [NativeTypeName("HRESULT (DWORD *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetDropDownStatus;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetEnumerator;
    }
}
