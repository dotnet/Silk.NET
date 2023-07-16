// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPropertyDescriptionRelatedPropertyInfo.xml' path='doc/member[@name="IPropertyDescriptionRelatedPropertyInfo"]/*'/>
[Guid("507393F4-2A3D-4A60-B59E-D9C75716C2DD")]
[NativeTypeName("struct IPropertyDescriptionRelatedPropertyInfo : IPropertyDescription")]
[NativeInheritance("IPropertyDescription")]
public unsafe partial struct IPropertyDescriptionRelatedPropertyInfo : IPropertyDescriptionRelatedPropertyInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyDescriptionRelatedPropertyInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, Guid*, void**, int> )(lpVtbl[0]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, uint> )(lpVtbl[1]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, uint> )(lpVtbl[2]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPropertyDescription.GetPropertyKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPERTYKEY*, int> )(lpVtbl[3]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pkey);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetCanonicalName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int> )(lpVtbl[4]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszName);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetPropertyType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, ushort*, int> )(lpVtbl[5]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pvartype);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int> )(lpVtbl[6]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszName);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetEditInvitation"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, ushort**, int> )(lpVtbl[7]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppszInvite);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetTypeFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int> )(lpVtbl[8]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), mask, ppdtFlags);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetViewFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_VIEW_FLAGS*, int> )(lpVtbl[9]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppdvFlags);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetDefaultColumnWidth"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDefaultColumnWidth(uint* pcxChars)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, uint*, int> )(lpVtbl[10]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcxChars);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetDisplayType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_DISPLAYTYPE*, int> )(lpVtbl[11]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pdisplaytype);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetColumnState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, uint*, int> )(lpVtbl[12]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcsFlags);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetGroupingRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_GROUPING_RANGE*, int> )(lpVtbl[13]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pgr);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetRelativeDescriptionType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int> )(lpVtbl[14]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), prdt);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetRelativeDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRelativeDescription([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2, [NativeTypeName("LPWSTR *")] ushort** ppszDesc1, [NativeTypeName("LPWSTR *")] ushort** ppszDesc2)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int> )(lpVtbl[15]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar1, propvar2, ppszDesc1, ppszDesc2);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetSortDescription"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSortDescription(PROPDESC_SORTDESCRIPTION* psd)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_SORTDESCRIPTION*, int> )(lpVtbl[16]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), psd);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetSortDescriptionLabel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSortDescriptionLabel(BOOL fDescending, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, BOOL, ushort**, int> )(lpVtbl[17]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), fDescending, ppszDescription);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetAggregationType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_AGGREGATION_TYPE*, int> )(lpVtbl[18]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), paggtype);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetConditionType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetConditionType(PROPDESC_CONDITION_TYPE* pcontype, CONDITION_OPERATION* popDefault)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int> )(lpVtbl[19]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pcontype, popDefault);
    }

    /// <inheritdoc cref = "IPropertyDescription.GetEnumTypeList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, Guid*, void**, int> )(lpVtbl[20]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <inheritdoc cref = "IPropertyDescription.CoerceToCanonicalValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CoerceToCanonicalValue(PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, int> )(lpVtbl[21]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), ppropvar);
    }

    /// <inheritdoc cref = "IPropertyDescription.FormatForDisplay"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FormatForDisplay([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int> )(lpVtbl[22]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar, pdfFlags, ppszDisplay);
    }

    /// <inheritdoc cref = "IPropertyDescription.IsValueCanonical"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, PROPVARIANT*, int> )(lpVtbl[23]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), propvar);
    }

    /// <include file='IPropertyDescriptionRelatedPropertyInfo.xml' path='doc/member[@name="IPropertyDescriptionRelatedPropertyInfo.GetRelatedProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetRelatedProperty([NativeTypeName("LPCWSTR")] ushort* pszRelationshipName, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyDescriptionRelatedPropertyInfo*, ushort*, Guid*, void**, int> )(lpVtbl[24]))((IPropertyDescriptionRelatedPropertyInfo*)Unsafe.AsPointer(ref this), pszRelationshipName, riid, ppv);
    }

    public interface Interface : IPropertyDescription.Interface
    {
        [VtblIndex(24)]
        HRESULT GetRelatedProperty([NativeTypeName("LPCWSTR")] ushort* pszRelationshipName, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> GetPropertyKey;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCanonicalName;
        [NativeTypeName("HRESULT (VARTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetPropertyType;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEditInvitation;
        [NativeTypeName("HRESULT (PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS*, int> GetTypeFlags;
        [NativeTypeName("HRESULT (PROPDESC_VIEW_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_VIEW_FLAGS*, int> GetViewFlags;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDefaultColumnWidth;
        [NativeTypeName("HRESULT (PROPDESC_DISPLAYTYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_DISPLAYTYPE*, int> GetDisplayType;
        [NativeTypeName("HRESULT (SHCOLSTATEF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetColumnState;
        [NativeTypeName("HRESULT (PROPDESC_GROUPING_RANGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_GROUPING_RANGE*, int> GetGroupingRange;
        [NativeTypeName("HRESULT (PROPDESC_RELATIVEDESCRIPTION_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int> GetRelativeDescriptionType;
        [NativeTypeName("HRESULT (const PROPVARIANT &, const PROPVARIANT &, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, PROPVARIANT*, ushort**, ushort**, int> GetRelativeDescription;
        [NativeTypeName("HRESULT (PROPDESC_SORTDESCRIPTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_SORTDESCRIPTION*, int> GetSortDescription;
        [NativeTypeName("HRESULT (BOOL, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, ushort**, int> GetSortDescriptionLabel;
        [NativeTypeName("HRESULT (PROPDESC_AGGREGATION_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_AGGREGATION_TYPE*, int> GetAggregationType;
        [NativeTypeName("HRESULT (PROPDESC_CONDITION_TYPE *, CONDITION_OPERATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_CONDITION_TYPE*, CONDITION_OPERATION*, int> GetConditionType;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetEnumTypeList;
        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> CoerceToCanonicalValue;
        [NativeTypeName("HRESULT (const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, PROPDESC_FORMAT_FLAGS, ushort**, int> FormatForDisplay;
        [NativeTypeName("HRESULT (const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> IsValueCanonical;
        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, void**, int> GetRelatedProperty;
    }
}