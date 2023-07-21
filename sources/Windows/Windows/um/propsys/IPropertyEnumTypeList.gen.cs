// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPropertyEnumTypeList.xml' path='doc/member[@name="IPropertyEnumTypeList"]/*' />
[Guid("A99400F4-3D84-4557-94BA-1242FB2CC9A6")]
[NativeTypeName("struct IPropertyEnumTypeList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyEnumTypeList : IPropertyEnumTypeList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyEnumTypeList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, uint>)(lpVtbl[1]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, uint>)(lpVtbl[2]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyEnumTypeList.xml' path='doc/member[@name="IPropertyEnumTypeList.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* pctypes)
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, uint*, int>)(lpVtbl[3]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), pctypes);
    }

    /// <include file='IPropertyEnumTypeList.xml' path='doc/member[@name="IPropertyEnumTypeList.GetAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint itype, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), itype, riid, ppv);
    }

    /// <include file='IPropertyEnumTypeList.xml' path='doc/member[@name="IPropertyEnumTypeList.GetConditionAt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetConditionAt(uint nIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, uint, Guid*, void**, int>)(lpVtbl[5]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), nIndex, riid, ppv);
    }

    /// <include file='IPropertyEnumTypeList.xml' path='doc/member[@name="IPropertyEnumTypeList.FindMatchingIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindMatchingIndex([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarCmp, uint* pnIndex)
    {
        return ((delegate* unmanaged<IPropertyEnumTypeList*, PROPVARIANT*, uint*, int>)(lpVtbl[6]))((IPropertyEnumTypeList*)Unsafe.AsPointer(ref this), propvarCmp, pnIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* pctypes);

        [VtblIndex(4)]
        HRESULT GetAt(uint itype, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(5)]
        HRESULT GetConditionAt(uint nIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(6)]
        HRESULT FindMatchingIndex([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarCmp, uint* pnIndex);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetAt;

        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetConditionAt;

        [NativeTypeName("HRESULT (const PROPVARIANT &, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, uint*, int> FindMatchingIndex;
    }
}
