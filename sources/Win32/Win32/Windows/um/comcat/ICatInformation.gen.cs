// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/comcat.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0002E013-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICatInformation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICatInformation : ICatInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICatInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICatInformation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICatInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICatInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumCategories(
        [NativeTypeName("LCID")] uint lcid,
        IEnumCATEGORYINFO* ppenumCategoryInfo
    )
    {
        return (
            (delegate* unmanaged<ICatInformation, uint, IEnumCATEGORYINFO*, int>)((*lpVtbl)[3])
        )(this, lcid, ppenumCategoryInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCategoryDesc(
        [NativeTypeName("REFCATID")] Guid* rcatid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LPWSTR *")] ushort** pszDesc
    )
    {
        return ((delegate* unmanaged<ICatInformation, Guid*, uint, ushort**, int>)((*lpVtbl)[4]))(
            this,
            rcatid,
            lcid,
            pszDesc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumClassesOfCategories(
        [NativeTypeName("ULONG")] uint cImplemented,
        [NativeTypeName("const CATID[]")] Guid* rgcatidImpl,
        [NativeTypeName("ULONG")] uint cRequired,
        [NativeTypeName("const CATID[]")] Guid* rgcatidReq,
        IEnumGUID* ppenumClsid
    )
    {
        return (
            (delegate* unmanaged<ICatInformation, uint, Guid*, uint, Guid*, IEnumGUID*, int>)(
                (*lpVtbl)[5]
            )
        )(this, cImplemented, rgcatidImpl, cRequired, rgcatidReq, ppenumClsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsClassOfCategories(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("ULONG")] uint cImplemented,
        [NativeTypeName("const CATID[]")] Guid* rgcatidImpl,
        [NativeTypeName("ULONG")] uint cRequired,
        [NativeTypeName("const CATID[]")] Guid* rgcatidReq
    )
    {
        return (
            (delegate* unmanaged<ICatInformation, Guid*, uint, Guid*, uint, Guid*, int>)(
                (*lpVtbl)[6]
            )
        )(this, rclsid, cImplemented, rgcatidImpl, cRequired, rgcatidReq);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumImplCategoriesOfClass(
        [NativeTypeName("const IID &")] Guid* rclsid,
        IEnumGUID* ppenumCatid
    )
    {
        return ((delegate* unmanaged<ICatInformation, Guid*, IEnumGUID*, int>)((*lpVtbl)[7]))(
            this,
            rclsid,
            ppenumCatid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumReqCategoriesOfClass(
        [NativeTypeName("const IID &")] Guid* rclsid,
        IEnumGUID* ppenumCatid
    )
    {
        return ((delegate* unmanaged<ICatInformation, Guid*, IEnumGUID*, int>)((*lpVtbl)[8]))(
            this,
            rclsid,
            ppenumCatid
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumCategories(
            [NativeTypeName("LCID")] uint lcid,
            IEnumCATEGORYINFO* ppenumCategoryInfo
        );

        [VtblIndex(4)]
        HRESULT GetCategoryDesc(
            [NativeTypeName("REFCATID")] Guid* rcatid,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("LPWSTR *")] ushort** pszDesc
        );

        [VtblIndex(5)]
        HRESULT EnumClassesOfCategories(
            [NativeTypeName("ULONG")] uint cImplemented,
            [NativeTypeName("const CATID[]")] Guid* rgcatidImpl,
            [NativeTypeName("ULONG")] uint cRequired,
            [NativeTypeName("const CATID[]")] Guid* rgcatidReq,
            IEnumGUID* ppenumClsid
        );

        [VtblIndex(6)]
        HRESULT IsClassOfCategories(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("ULONG")] uint cImplemented,
            [NativeTypeName("const CATID[]")] Guid* rgcatidImpl,
            [NativeTypeName("ULONG")] uint cRequired,
            [NativeTypeName("const CATID[]")] Guid* rgcatidReq
        );

        [VtblIndex(7)]
        HRESULT EnumImplCategoriesOfClass(
            [NativeTypeName("const IID &")] Guid* rclsid,
            IEnumGUID* ppenumCatid
        );

        [VtblIndex(8)]
        HRESULT EnumReqCategoriesOfClass(
            [NativeTypeName("const IID &")] Guid* rclsid,
            IEnumGUID* ppenumCatid
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

        [NativeTypeName("HRESULT (LCID, IEnumCATEGORYINFO **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumCATEGORYINFO*, int> EnumCategories;

        [NativeTypeName("HRESULT (REFCATID, LCID, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, ushort**, int> GetCategoryDesc;

        [NativeTypeName(
            "HRESULT (ULONG, const CATID *, ULONG, const CATID *, IEnumGUID **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            uint,
            Guid*,
            IEnumGUID*,
            int> EnumClassesOfCategories;

        [NativeTypeName(
            "HRESULT (const IID &, ULONG, const CATID *, ULONG, const CATID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            uint,
            Guid*,
            uint,
            Guid*,
            int> IsClassOfCategories;

        [NativeTypeName("HRESULT (const IID &, IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumGUID*, int> EnumImplCategoriesOfClass;

        [NativeTypeName("HRESULT (const IID &, IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumGUID*, int> EnumReqCategoriesOfClass;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICatInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICatInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICatInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICatInformation(Silk.NET.Windows.IUnknown value)
    {
        return new ICatInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICatInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICatInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICatInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
