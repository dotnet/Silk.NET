// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("57D2EDED-5062-400E-B107-5DAE79FE57A6")]
[NativeTypeName("struct IPropertyDescription2 : IPropertyDescription")]
[NativeInheritance("IPropertyDescription")]
public unsafe partial struct IPropertyDescription2 : IPropertyDescription2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyDescription2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyDescription2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPropertyDescription2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyDescription2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyDescription2, PROPERTYKEY*, int>)((*lpVtbl)[3]))(
            this,
            pkey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCanonicalName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescription2, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyType([NativeTypeName("VARTYPE *")] ushort* pvartype)
    {
        return ((delegate* unmanaged<IPropertyDescription2, ushort*, int>)((*lpVtbl)[5]))(
            this,
            pvartype
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** ppszName)
    {
        return ((delegate* unmanaged<IPropertyDescription2, ushort**, int>)((*lpVtbl)[6]))(
            this,
            ppszName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEditInvitation([NativeTypeName("LPWSTR *")] ushort** ppszInvite)
    {
        return ((delegate* unmanaged<IPropertyDescription2, ushort**, int>)((*lpVtbl)[7]))(
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
                IPropertyDescription2,
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
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_VIEW_FLAGS*, int>)((*lpVtbl)[9])
        )(this, ppdvFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDefaultColumnWidth(uint* pcxChars)
    {
        return ((delegate* unmanaged<IPropertyDescription2, uint*, int>)((*lpVtbl)[10]))(
            this,
            pcxChars
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayType(PROPDESC_DISPLAYTYPE* pdisplaytype)
    {
        return (
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_DISPLAYTYPE*, int>)((*lpVtbl)[11])
        )(this, pdisplaytype);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetColumnState([NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
    {
        return ((delegate* unmanaged<IPropertyDescription2, uint*, int>)((*lpVtbl)[12]))(
            this,
            pcsFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetGroupingRange(PROPDESC_GROUPING_RANGE* pgr)
    {
        return (
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_GROUPING_RANGE*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pgr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetRelativeDescriptionType(PROPDESC_RELATIVEDESCRIPTION_TYPE* prdt)
    {
        return (
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_RELATIVEDESCRIPTION_TYPE*, int>)(
                (*lpVtbl)[14]
            )
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
                IPropertyDescription2,
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
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_SORTDESCRIPTION*, int>)(
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
        return ((delegate* unmanaged<IPropertyDescription2, BOOL, ushort**, int>)((*lpVtbl)[17]))(
            this,
            fDescending,
            ppszDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetAggregationType(PROPDESC_AGGREGATION_TYPE* paggtype)
    {
        return (
            (delegate* unmanaged<IPropertyDescription2, PROPDESC_AGGREGATION_TYPE*, int>)(
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
                IPropertyDescription2,
                PROPDESC_CONDITION_TYPE*,
                CONDITION_OPERATION*,
                int>)((*lpVtbl)[19])
        )(this, pcontype, popDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEnumTypeList([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IPropertyDescription2, Guid*, void**, int>)((*lpVtbl)[20]))(
            this,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CoerceToCanonicalValue(PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<IPropertyDescription2, PROPVARIANT*, int>)((*lpVtbl)[21]))(
            this,
            ppropvar
        );
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
                IPropertyDescription2,
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
        return ((delegate* unmanaged<IPropertyDescription2, PROPVARIANT*, int>)((*lpVtbl)[23]))(
            this,
            propvar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetImageReferenceForValue(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("LPWSTR *")] ushort** ppszImageRes
    )
    {
        return (
            (delegate* unmanaged<IPropertyDescription2, PROPVARIANT*, ushort**, int>)((*lpVtbl)[24])
        )(this, propvar, ppszImageRes);
    }

    public interface Interface : IPropertyDescription.Interface
    {
        [VtblIndex(24)]
        HRESULT GetImageReferenceForValue(
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
            [NativeTypeName("LPWSTR *")] ushort** ppszImageRes
        );
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

        [NativeTypeName("HRESULT (const PROPVARIANT &, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, ushort**, int> GetImageReferenceForValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyDescription2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyDescription2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPropertyDescription"/> to <see cref = "IPropertyDescription2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPropertyDescription"/> instance to be converted </param>
    public static explicit operator IPropertyDescription2(
        Silk.NET.Windows.IPropertyDescription value
    )
    {
        return new IPropertyDescription2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyDescription2"/> to <see cref = "Silk.NET.Windows.IPropertyDescription"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyDescription2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPropertyDescription(
        IPropertyDescription2 value
    )
    {
        return new Silk.NET.Windows.IPropertyDescription(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyDescription2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyDescription2(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyDescription2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyDescription2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyDescription2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyDescription2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
