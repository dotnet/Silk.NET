// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IItemNameLimits.xml' path='doc/member[@name="IItemNameLimits"]/*' />
[Guid("1DF0D7F1-B267-4D28-8B10-12E23202A5C4")]
[NativeTypeName("struct IItemNameLimits : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IItemNameLimits : IItemNameLimits.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IItemNameLimits));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IItemNameLimits*, Guid*, void**, int>)(lpVtbl[0]))((IItemNameLimits*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IItemNameLimits*, uint>)(lpVtbl[1]))((IItemNameLimits*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IItemNameLimits*, uint>)(lpVtbl[2]))((IItemNameLimits*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IItemNameLimits.xml' path='doc/member[@name="IItemNameLimits.GetValidCharacters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetValidCharacters([NativeTypeName("LPWSTR *")] ushort** ppwszValidChars, [NativeTypeName("LPWSTR *")] ushort** ppwszInvalidChars)
    {
        return ((delegate* unmanaged<IItemNameLimits*, ushort**, ushort**, int>)(lpVtbl[3]))((IItemNameLimits*)Unsafe.AsPointer(ref this), ppwszValidChars, ppwszInvalidChars);
    }

    /// <include file='IItemNameLimits.xml' path='doc/member[@name="IItemNameLimits.GetMaxLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMaxLength([NativeTypeName("LPCWSTR")] ushort* pszName, int* piMaxNameLen)
    {
        return ((delegate* unmanaged<IItemNameLimits*, ushort*, int*, int>)(lpVtbl[4]))((IItemNameLimits*)Unsafe.AsPointer(ref this), pszName, piMaxNameLen);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetValidCharacters([NativeTypeName("LPWSTR *")] ushort** ppwszValidChars, [NativeTypeName("LPWSTR *")] ushort** ppwszInvalidChars);

        [VtblIndex(4)]
        HRESULT GetMaxLength([NativeTypeName("LPCWSTR")] ushort* pszName, int* piMaxNameLen);
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

        [NativeTypeName("HRESULT (LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, int> GetValidCharacters;

        [NativeTypeName("HRESULT (LPCWSTR, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> GetMaxLength;
    }
}
