// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/comcat.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0002E012-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICatRegister : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICatRegister : ICatRegister.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICatRegister));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICatRegister, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICatRegister, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICatRegister, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterCategories(
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATEGORYINFO[]")] CATEGORYINFO* rgCategoryInfo
    )
    {
        return ((delegate* unmanaged<ICatRegister, uint, CATEGORYINFO*, int>)((*lpVtbl)[3]))(
            this,
            cCategories,
            rgCategoryInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnRegisterCategories(
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATID[]")] Guid* rgcatid
    )
    {
        return ((delegate* unmanaged<ICatRegister, uint, Guid*, int>)((*lpVtbl)[4]))(
            this,
            cCategories,
            rgcatid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterClassImplCategories(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATID[]")] Guid* rgcatid
    )
    {
        return ((delegate* unmanaged<ICatRegister, Guid*, uint, Guid*, int>)((*lpVtbl)[5]))(
            this,
            rclsid,
            cCategories,
            rgcatid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnRegisterClassImplCategories(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATID[]")] Guid* rgcatid
    )
    {
        return ((delegate* unmanaged<ICatRegister, Guid*, uint, Guid*, int>)((*lpVtbl)[6]))(
            this,
            rclsid,
            cCategories,
            rgcatid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RegisterClassReqCategories(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATID[]")] Guid* rgcatid
    )
    {
        return ((delegate* unmanaged<ICatRegister, Guid*, uint, Guid*, int>)((*lpVtbl)[7]))(
            this,
            rclsid,
            cCategories,
            rgcatid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnRegisterClassReqCategories(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("ULONG")] uint cCategories,
        [NativeTypeName("CATID[]")] Guid* rgcatid
    )
    {
        return ((delegate* unmanaged<ICatRegister, Guid*, uint, Guid*, int>)((*lpVtbl)[8]))(
            this,
            rclsid,
            cCategories,
            rgcatid
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterCategories(
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATEGORYINFO[]")] CATEGORYINFO* rgCategoryInfo
        );

        [VtblIndex(4)]
        HRESULT UnRegisterCategories(
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATID[]")] Guid* rgcatid
        );

        [VtblIndex(5)]
        HRESULT RegisterClassImplCategories(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATID[]")] Guid* rgcatid
        );

        [VtblIndex(6)]
        HRESULT UnRegisterClassImplCategories(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATID[]")] Guid* rgcatid
        );

        [VtblIndex(7)]
        HRESULT RegisterClassReqCategories(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATID[]")] Guid* rgcatid
        );

        [VtblIndex(8)]
        HRESULT UnRegisterClassReqCategories(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("ULONG")] uint cCategories,
            [NativeTypeName("CATID[]")] Guid* rgcatid
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

        [NativeTypeName("HRESULT (ULONG, CATEGORYINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CATEGORYINFO*, int> RegisterCategories;

        [NativeTypeName("HRESULT (ULONG, CATID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> UnRegisterCategories;

        [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, int> RegisterClassImplCategories;

        [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, int> UnRegisterClassImplCategories;

        [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, int> RegisterClassReqCategories;

        [NativeTypeName("HRESULT (const IID &, ULONG, CATID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, Guid*, int> UnRegisterClassReqCategories;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICatRegister"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICatRegister(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICatRegister"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICatRegister(Silk.NET.Windows.IUnknown value)
    {
        return new ICatRegister(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICatRegister"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICatRegister"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICatRegister value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
