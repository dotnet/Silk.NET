// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B79BB0B0-33C1-11D1-ABE1-00A0C905F375")]
[NativeTypeName("struct IFilterMapper2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFilterMapper2 : IFilterMapper2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterMapper2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterMapper2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFilterMapper2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterMapper2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateCategory(
        [NativeTypeName("const IID &")] Guid* clsidCategory,
        [NativeTypeName("DWORD")] uint dwCategoryMerit,
        [NativeTypeName("LPCWSTR")] ushort* Description
    )
    {
        return ((delegate* unmanaged<IFilterMapper2, Guid*, uint, ushort*, int>)((*lpVtbl)[3]))(
            this,
            clsidCategory,
            dwCategoryMerit,
            Description
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterFilter(
        [NativeTypeName("const CLSID *")] Guid* pclsidCategory,
        [NativeTypeName("LPCOLESTR")] ushort* szInstance,
        [NativeTypeName("const IID &")] Guid* Filter
    )
    {
        return ((delegate* unmanaged<IFilterMapper2, Guid*, ushort*, Guid*, int>)((*lpVtbl)[4]))(
            this,
            pclsidCategory,
            szInstance,
            Filter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterFilter(
        [NativeTypeName("const IID &")] Guid* clsidFilter,
        [NativeTypeName("LPCWSTR")] ushort* Name,
        IMoniker* ppMoniker,
        [NativeTypeName("const CLSID *")] Guid* pclsidCategory,
        [NativeTypeName("LPCOLESTR")] ushort* szInstance,
        [NativeTypeName("const REGFILTER2 *")] REGFILTER2* prf2
    )
    {
        return (
            (delegate* unmanaged<
                IFilterMapper2,
                Guid*,
                ushort*,
                IMoniker*,
                Guid*,
                ushort*,
                REGFILTER2*,
                int>)((*lpVtbl)[5])
        )(this, clsidFilter, Name, ppMoniker, pclsidCategory, szInstance, prf2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumMatchingFilters(
        IEnumMoniker* ppEnum,
        [NativeTypeName("DWORD")] uint dwFlags,
        BOOL bExactMatch,
        [NativeTypeName("DWORD")] uint dwMerit,
        BOOL bInputNeeded,
        [NativeTypeName("DWORD")] uint cInputTypes,
        [NativeTypeName("const GUID *")] Guid* pInputTypes,
        [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedIn,
        [NativeTypeName("const CLSID *")] Guid* pPinCategoryIn,
        BOOL bRender,
        BOOL bOutputNeeded,
        [NativeTypeName("DWORD")] uint cOutputTypes,
        [NativeTypeName("const GUID *")] Guid* pOutputTypes,
        [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedOut,
        [NativeTypeName("const CLSID *")] Guid* pPinCategoryOut
    )
    {
        return (
            (delegate* unmanaged<
                IFilterMapper2,
                IEnumMoniker*,
                uint,
                BOOL,
                uint,
                BOOL,
                uint,
                Guid*,
                REGPINMEDIUM*,
                Guid*,
                BOOL,
                BOOL,
                uint,
                Guid*,
                REGPINMEDIUM*,
                Guid*,
                int>)((*lpVtbl)[6])
        )(
            this,
            ppEnum,
            dwFlags,
            bExactMatch,
            dwMerit,
            bInputNeeded,
            cInputTypes,
            pInputTypes,
            pMedIn,
            pPinCategoryIn,
            bRender,
            bOutputNeeded,
            cOutputTypes,
            pOutputTypes,
            pMedOut,
            pPinCategoryOut
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateCategory(
            [NativeTypeName("const IID &")] Guid* clsidCategory,
            [NativeTypeName("DWORD")] uint dwCategoryMerit,
            [NativeTypeName("LPCWSTR")] ushort* Description
        );

        [VtblIndex(4)]
        HRESULT UnregisterFilter(
            [NativeTypeName("const CLSID *")] Guid* pclsidCategory,
            [NativeTypeName("LPCOLESTR")] ushort* szInstance,
            [NativeTypeName("const IID &")] Guid* Filter
        );

        [VtblIndex(5)]
        HRESULT RegisterFilter(
            [NativeTypeName("const IID &")] Guid* clsidFilter,
            [NativeTypeName("LPCWSTR")] ushort* Name,
            IMoniker* ppMoniker,
            [NativeTypeName("const CLSID *")] Guid* pclsidCategory,
            [NativeTypeName("LPCOLESTR")] ushort* szInstance,
            [NativeTypeName("const REGFILTER2 *")] REGFILTER2* prf2
        );

        [VtblIndex(6)]
        HRESULT EnumMatchingFilters(
            IEnumMoniker* ppEnum,
            [NativeTypeName("DWORD")] uint dwFlags,
            BOOL bExactMatch,
            [NativeTypeName("DWORD")] uint dwMerit,
            BOOL bInputNeeded,
            [NativeTypeName("DWORD")] uint cInputTypes,
            [NativeTypeName("const GUID *")] Guid* pInputTypes,
            [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedIn,
            [NativeTypeName("const CLSID *")] Guid* pPinCategoryIn,
            BOOL bRender,
            BOOL bOutputNeeded,
            [NativeTypeName("DWORD")] uint cOutputTypes,
            [NativeTypeName("const GUID *")] Guid* pOutputTypes,
            [NativeTypeName("const REGPINMEDIUM *")] REGPINMEDIUM* pMedOut,
            [NativeTypeName("const CLSID *")] Guid* pPinCategoryOut
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

        [NativeTypeName("HRESULT (const IID &, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, ushort*, int> CreateCategory;

        [NativeTypeName("HRESULT (const CLSID *, LPCOLESTR, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> UnregisterFilter;

        [NativeTypeName(
            "HRESULT (const IID &, LPCWSTR, IMoniker **, const CLSID *, LPCOLESTR, const REGFILTER2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            IMoniker*,
            Guid*,
            ushort*,
            REGFILTER2*,
            int> RegisterFilter;

        [NativeTypeName(
            "HRESULT (IEnumMoniker **, DWORD, BOOL, DWORD, BOOL, DWORD, const GUID *, const REGPINMEDIUM *, const CLSID *, BOOL, BOOL, DWORD, const GUID *, const REGPINMEDIUM *, const CLSID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEnumMoniker*,
            uint,
            BOOL,
            uint,
            BOOL,
            uint,
            Guid*,
            REGPINMEDIUM*,
            Guid*,
            BOOL,
            BOOL,
            uint,
            Guid*,
            REGPINMEDIUM*,
            Guid*,
            int> EnumMatchingFilters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFilterMapper2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFilterMapper2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFilterMapper2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFilterMapper2(Silk.NET.Windows.IUnknown value)
    {
        return new IFilterMapper2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterMapper2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterMapper2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFilterMapper2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
