// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CA724E8A-C3E6-442B-88A4-6FB0DB8035A3")]
[NativeTypeName("struct IPropertySystem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertySystem : IPropertySystem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertySystem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertySystem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertySystem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertySystem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyDescription(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IPropertySystem, PROPERTYKEY*, Guid*, void**, int>)((*lpVtbl)[3])
        )(this, propkey, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyDescriptionByName(
        [NativeTypeName("LPCWSTR")] ushort* pszCanonicalName,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return ((delegate* unmanaged<IPropertySystem, ushort*, Guid*, void**, int>)((*lpVtbl)[4]))(
            this,
            pszCanonicalName,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyDescriptionListFromString(
        [NativeTypeName("LPCWSTR")] ushort* pszPropList,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return ((delegate* unmanaged<IPropertySystem, ushort*, Guid*, void**, int>)((*lpVtbl)[5]))(
            this,
            pszPropList,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumeratePropertyDescriptions(
        PROPDESC_ENUMFILTER filterOn,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IPropertySystem, PROPDESC_ENUMFILTER, Guid*, void**, int>)(
                (*lpVtbl)[6]
            )
        )(this, filterOn, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FormatForDisplay(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        PROPDESC_FORMAT_FLAGS pdff,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        [NativeTypeName("DWORD")] uint cchText
    )
    {
        return (
            (delegate* unmanaged<
                IPropertySystem,
                PROPERTYKEY*,
                PROPVARIANT*,
                PROPDESC_FORMAT_FLAGS,
                ushort*,
                uint,
                int>)((*lpVtbl)[7])
        )(this, key, propvar, pdff, pszText, cchText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FormatForDisplayAlloc(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        PROPDESC_FORMAT_FLAGS pdff,
        [NativeTypeName("LPWSTR *")] ushort** ppszDisplay
    )
    {
        return (
            (delegate* unmanaged<
                IPropertySystem,
                PROPERTYKEY*,
                PROPVARIANT*,
                PROPDESC_FORMAT_FLAGS,
                ushort**,
                int>)((*lpVtbl)[8])
        )(this, key, propvar, pdff, ppszDisplay);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IPropertySystem, ushort*, int>)((*lpVtbl)[9]))(this, pszPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT UnregisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IPropertySystem, ushort*, int>)((*lpVtbl)[10]))(this, pszPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RefreshPropertySchema()
    {
        return ((delegate* unmanaged<IPropertySystem, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyDescription(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(4)]
        HRESULT GetPropertyDescriptionByName(
            [NativeTypeName("LPCWSTR")] ushort* pszCanonicalName,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(5)]
        HRESULT GetPropertyDescriptionListFromString(
            [NativeTypeName("LPCWSTR")] ushort* pszPropList,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(6)]
        HRESULT EnumeratePropertyDescriptions(
            PROPDESC_ENUMFILTER filterOn,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(7)]
        HRESULT FormatForDisplay(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
            PROPDESC_FORMAT_FLAGS pdff,
            [NativeTypeName("LPWSTR")] ushort* pszText,
            [NativeTypeName("DWORD")] uint cchText
        );

        [VtblIndex(8)]
        HRESULT FormatForDisplayAlloc(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
            PROPDESC_FORMAT_FLAGS pdff,
            [NativeTypeName("LPWSTR *")] ushort** ppszDisplay
        );

        [VtblIndex(9)]
        HRESULT RegisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [VtblIndex(10)]
        HRESULT UnregisterPropertySchema([NativeTypeName("LPCWSTR")] ushort* pszPath);

        [VtblIndex(11)]
        HRESULT RefreshPropertySchema();
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

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, Guid*, void**, int> GetPropertyDescription;

        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            Guid*,
            void**,
            int> GetPropertyDescriptionByName;

        [NativeTypeName("HRESULT (LPCWSTR, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            Guid*,
            void**,
            int> GetPropertyDescriptionListFromString;

        [NativeTypeName(
            "HRESULT (PROPDESC_ENUMFILTER, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPDESC_ENUMFILTER,
            Guid*,
            void**,
            int> EnumeratePropertyDescriptions;

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPERTYKEY*,
            PROPVARIANT*,
            PROPDESC_FORMAT_FLAGS,
            ushort*,
            uint,
            int> FormatForDisplay;

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const PROPVARIANT &, PROPDESC_FORMAT_FLAGS, LPWSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPERTYKEY*,
            PROPVARIANT*,
            PROPDESC_FORMAT_FLAGS,
            ushort**,
            int> FormatForDisplayAlloc;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RegisterPropertySchema;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> UnregisterPropertySchema;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RefreshPropertySchema;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertySystem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertySystem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertySystem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertySystem(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertySystem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertySystem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertySystem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertySystem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
