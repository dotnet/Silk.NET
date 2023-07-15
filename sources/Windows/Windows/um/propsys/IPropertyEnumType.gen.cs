// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType"]/*'/>
[Guid("11E1FBF9-2D56-4A6B-8DB3-7CD193A471F2")]
[NativeTypeName("struct IPropertyEnumType : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyEnumType : IPropertyEnumType.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyEnumType));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyEnumType*, uint> )(lpVtbl[1]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyEnumType*, uint> )(lpVtbl[2]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType.GetEnumType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnumType(PROPENUMTYPE* penumtype)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, PROPENUMTYPE*, int> )(lpVtbl[3]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), penumtype);
    }

    /// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType.GetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetValue(PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, PROPVARIANT*, int> )(lpVtbl[4]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvar);
    }

    /// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType.GetRangeMinValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRangeMinValue(PROPVARIANT* ppropvarMin)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, PROPVARIANT*, int> )(lpVtbl[5]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarMin);
    }

    /// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType.GetRangeSetValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRangeSetValue(PROPVARIANT* ppropvarSet)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, PROPVARIANT*, int> )(lpVtbl[6]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarSet);
    }

    /// <include file='IPropertyEnumType.xml' path='doc/member[@name="IPropertyEnumType.GetDisplayText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
    {
        return ((delegate* unmanaged<IPropertyEnumType*, ushort**, int> )(lpVtbl[7]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppszDisplay);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEnumType(PROPENUMTYPE* penumtype);
        [VtblIndex(4)]
        HRESULT GetValue(PROPVARIANT* ppropvar);
        [VtblIndex(5)]
        HRESULT GetRangeMinValue(PROPVARIANT* ppropvarMin);
        [VtblIndex(6)]
        HRESULT GetRangeSetValue(PROPVARIANT* ppropvarSet);
        [VtblIndex(7)]
        HRESULT GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay);
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
    }
}