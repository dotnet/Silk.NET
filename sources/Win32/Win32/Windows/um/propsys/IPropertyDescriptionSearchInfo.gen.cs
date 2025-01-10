// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("078F91BD-29A2-440F-924E-46A291524520")]
[NativeTypeName("struct IPropertyDescriptionSearchInfo : IPropertyDescription")]
[NativeInheritance("IPropertyDescription")]
public unsafe partial struct IPropertyDescriptionSearchInfo
    : IPropertyDescriptionSearchInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyDescriptionSearchInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPERTYKEY*, int>)((*lpVtbl)[3])
        )(this, pkey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pvartype
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, ushort**, int>)((*lpVtbl)[6]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, ushort**, int>)((*lpVtbl)[7]))(
            this,
            ppszInvite
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTypeFlags(PROPDESC_TYPE_FLAGS mask, PROPDESC_TYPE_FLAGS* ppdtFlags)
    {
        return (
            (delegate* unmanaged<
                IPropertyDescriptionSearchInfo,
                PROPDESC_TYPE_FLAGS,
                PROPDESC_TYPE_FLAGS*,
                int>)((*lpVtbl)[8])
        )(this, mask, ppdtFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetViewFlags(PROPDESC_VIEW_FLAGS* ppdvFlags)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_VIEW_FLAGS*, int>)(
                (*lpVtbl)[9]
            )
        )(this, ppdvFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDefaultColumnWidth(uint* pcxChars)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, uint*, int>)((*lpVtbl)[10]))(
            this,
            pcxChars
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_DISPLAYTYPE*, int>)(
                (*lpVtbl)[11]
            )
        )(this, pdisplaytype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, uint*, int>)((*lpVtbl)[12]))(
            this,
            pcsFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_GROUPING_RANGE*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pgr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
    {
        return (
            (delegate* unmanaged<
                IPropertyDescriptionSearchInfo,
                PROPDESC_RELATIVEDESCRIPTION_TYPE*,
                int>)((*lpVtbl)[14])
        )(this, prdt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetRelativeDescription(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2,
        [NativeTypeName("LPWSTR *")] ushort** ppszDesc1,
        [NativeTypeName("LPWSTR *")] ushort** ppszDesc2
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyDescriptionSearchInfo,
                PROPVARIANT*,
                PROPVARIANT*,
                ushort**,
                ushort**,
                int>)((*lpVtbl)[15])
        )(this, propvar1, propvar2, ppszDesc1, ppszDesc2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSortDescription(PROPDESC_SORTDESCRIPTION* psd)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_SORTDESCRIPTION*, int>)(
                (*lpVtbl)[16]
            )
        )(this, psd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetSortDescriptionLabel(
        BOOL fDescending,
        [NativeTypeName("LPWSTR *")] ushort** ppszDescription
    )
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, BOOL, ushort**, int>)(
                (*lpVtbl)[17]
            )
        )(this, fDescending, ppszDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_AGGREGATION_TYPE*, int>)(
                (*lpVtbl)[18]
            )
        )(this, paggtype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetConditionType(
        PROPDESC_CONDITION_TYPE* pcontype,
        CONDITION_OPERATION* popDefault
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyDescriptionSearchInfo,
                PROPDESC_CONDITION_TYPE*,
                CONDITION_OPERATION*,
                int>)((*lpVtbl)[19])
        )(this, pcontype, popDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, Guid*, void**, int>)((*lpVtbl)[20])
        )(this, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CoerceToCanonicalValue(PROPVARIANT* ppropvar)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPVARIANT*, int>)((*lpVtbl)[21])
        )(this, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT FormatForDisplay(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        PROPDESC_FORMAT_FLAGS pdfFlags,
        [NativeTypeName("LPWSTR *")] ushort** ppszDisplay
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyDescriptionSearchInfo,
                PROPVARIANT*,
                PROPDESC_FORMAT_FLAGS,
                ushort**,
                int>)((*lpVtbl)[22])
        )(this, propvar, pdfFlags, ppszDisplay);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT IsValueCanonical([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPVARIANT*, int>)((*lpVtbl)[23])
        )(this, propvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetSearchInfoFlags(PROPDESC_SEARCHINFO_FLAGS* ppdsiFlags)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_SEARCHINFO_FLAGS*, int>)(
                (*lpVtbl)[24]
            )
        )(this, ppdsiFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetColumnIndexType(PROPDESC_COLUMNINDEX_TYPE* ppdciType)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, PROPDESC_COLUMNINDEX_TYPE*, int>)(
                (*lpVtbl)[25]
            )
        )(this, ppdciType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetProjectionString([NativeTypeName("LPWSTR *")] ushort** ppszProjection)
    {
        return (
            (delegate* unmanaged<IPropertyDescriptionSearchInfo, ushort**, int>)((*lpVtbl)[26])
        )(this, ppszProjection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetMaxSize(uint* pcbMaxSize)
    {
        return ((delegate* unmanaged<IPropertyDescriptionSearchInfo, uint*, int>)((*lpVtbl)[27]))(
            this,
            pcbMaxSize
        );
    }

    public interface Interface : IPropertyDescription.Interface
    {
        [VtblIndex(24)]
        HRESULT GetSearchInfoFlags(PROPDESC_SEARCHINFO_FLAGS* ppdsiFlags);

        [VtblIndex(25)]
        HRESULT GetColumnIndexType(PROPDESC_COLUMNINDEX_TYPE* ppdciType);

        [VtblIndex(26)]
        HRESULT GetProjectionString([NativeTypeName("LPWSTR *")] ushort** ppszProjection);

        [VtblIndex(27)]
        HRESULT GetMaxSize(uint* pcbMaxSize);
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

        [NativeTypeName(
            "HRESULT (PROPDESC_TYPE_FLAGS, PROPDESC_TYPE_FLAGS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPDESC_TYPE_FLAGS,
            PROPDESC_TYPE_FLAGS*,
            int> GetTypeFlags;

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
        public delegate* unmanaged<
            TSelf*,
            PROPDESC_RELATIVEDESCRIPTION_TYPE*,
            int> GetRelativeDescriptionType;

        [NativeTypeName(
            "HRESULT (const PROPVARIANT &, const PROPVARIANT &, LPWSTR *, LPWSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPVARIANT*,
            PROPVARIANT*,
            ushort**,
            ushort**,
            int> GetRelativeDescription;

        [NativeTypeName("HRESULT (PROPDESC_SORTDESCRIPTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_SORTDESCRIPTION*, int> GetSortDescription;

        [NativeTypeName("HRESULT (BOOL, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, ushort**, int> GetSortDescriptionLabel;

        [NativeTypeName("HRESULT (PROPDESC_AGGREGATION_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_AGGREGATION_TYPE*, int> GetAggregationType;

        [NativeTypeName(
            "HRESULT (PROPDESC_CONDITION_TYPE *, CONDITION_OPERATION *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPDESC_CONDITION_TYPE*,
            CONDITION_OPERATION*,
            int> GetConditionType;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetEnumTypeList;

        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> CoerceToCanonicalValue;

        [NativeTypeName(
            "HRESULT (const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPVARIANT*,
            PROPDESC_FORMAT_FLAGS,
            ushort**,
            int> FormatForDisplay;

        [NativeTypeName("HRESULT (const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> IsValueCanonical;

        [NativeTypeName("HRESULT (PROPDESC_SEARCHINFO_FLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_SEARCHINFO_FLAGS*, int> GetSearchInfoFlags;

        [NativeTypeName("HRESULT (PROPDESC_COLUMNINDEX_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPDESC_COLUMNINDEX_TYPE*, int> GetColumnIndexType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetProjectionString;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyDescriptionSearchInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyDescriptionSearchInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPropertyDescription"/> to <see cref = "IPropertyDescriptionSearchInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPropertyDescription"/> instance to be converted </param>
    public static explicit operator IPropertyDescriptionSearchInfo(
        Silk.NET.Windows.IPropertyDescription value
    )
    {
        return new IPropertyDescriptionSearchInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyDescriptionSearchInfo"/> to <see cref = "Silk.NET.Windows.IPropertyDescription"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyDescriptionSearchInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPropertyDescription(
        IPropertyDescriptionSearchInfo value
    )
    {
        return new Silk.NET.Windows.IPropertyDescription(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyDescriptionSearchInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyDescriptionSearchInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyDescriptionSearchInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyDescriptionSearchInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyDescriptionSearchInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyDescriptionSearchInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
