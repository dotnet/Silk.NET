// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPropertyEnumType2.xml' path='doc/member[@name="IPropertyEnumType2"]/*' />
[Guid("9B6E051C-5DDD-4321-9070-FE2ACB55E794")]
[NativeTypeName("struct IPropertyEnumType2 : IPropertyEnumType")]
[NativeInheritance("IPropertyEnumType")]
public unsafe partial struct IPropertyEnumType2 : IPropertyEnumType2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyEnumType2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, uint>)(lpVtbl[1]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, uint>)(lpVtbl[2]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPropertyEnumType.GetEnumType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnumType(PROPENUMTYPE* penumtype)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, PROPENUMTYPE*, int>)(lpVtbl[3]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), penumtype);
    }

    /// <inheritdoc cref="IPropertyEnumType.GetValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetValue(PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[4]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvar);
    }

    /// <inheritdoc cref="IPropertyEnumType.GetRangeMinValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRangeMinValue(PROPVARIANT* ppropvarMin)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvarMin);
    }

    /// <inheritdoc cref="IPropertyEnumType.GetRangeSetValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRangeSetValue(PROPVARIANT* ppropvarSet)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvarSet);
    }

    /// <inheritdoc cref="IPropertyEnumType.GetDisplayText" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, ushort**, int>)(lpVtbl[7]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppszDisplay);
    }

    /// <include file='IPropertyEnumType2.xml' path='doc/member[@name="IPropertyEnumType2.GetImageReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetImageReference([NativeTypeName("LPWSTR *")] ushort** ppszImageRes)
    {
        return ((delegate* unmanaged<IPropertyEnumType2*, ushort**, int>)(lpVtbl[8]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppszImageRes);
    }

    public interface Interface : IPropertyEnumType.Interface
    {
        [VtblIndex(8)]
        HRESULT GetImageReference([NativeTypeName("LPWSTR *")] ushort** ppszImageRes);
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

        [NativeTypeName("HRESULT (PROPENUMTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPENUMTYPE*, int> GetEnumType;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetRangeMinValue;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetRangeSetValue;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayText;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetImageReference;
    }
}
