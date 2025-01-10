// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D8EC27BB-3F3B-4042-B10A-4ACFD924D453")]
[NativeTypeName("struct IColumnManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IColumnManager : IColumnManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IColumnManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IColumnManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IColumnManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IColumnManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetColumnInfo(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const CM_COLUMNINFO *")] CM_COLUMNINFO* pcmci
    )
    {
        return (
            (delegate* unmanaged<IColumnManager, PROPERTYKEY*, CM_COLUMNINFO*, int>)((*lpVtbl)[3])
        )(this, propkey, pcmci);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetColumnInfo(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        CM_COLUMNINFO* pcmci
    )
    {
        return (
            (delegate* unmanaged<IColumnManager, PROPERTYKEY*, CM_COLUMNINFO*, int>)((*lpVtbl)[4])
        )(this, propkey, pcmci);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetColumnCount(CM_ENUM_FLAGS dwFlags, uint* puCount)
    {
        return ((delegate* unmanaged<IColumnManager, CM_ENUM_FLAGS, uint*, int>)((*lpVtbl)[5]))(
            this,
            dwFlags,
            puCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetColumns(CM_ENUM_FLAGS dwFlags, PROPERTYKEY* rgkeyOrder, uint cColumns)
    {
        return (
            (delegate* unmanaged<IColumnManager, CM_ENUM_FLAGS, PROPERTYKEY*, uint, int>)(
                (*lpVtbl)[6]
            )
        )(this, dwFlags, rgkeyOrder, cColumns);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetColumns(
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgkeyOrder,
        uint cVisible
    )
    {
        return ((delegate* unmanaged<IColumnManager, PROPERTYKEY*, uint, int>)((*lpVtbl)[7]))(
            this,
            rgkeyOrder,
            cVisible
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetColumnInfo(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            [NativeTypeName("const CM_COLUMNINFO *")] CM_COLUMNINFO* pcmci
        );

        [VtblIndex(4)]
        HRESULT GetColumnInfo(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            CM_COLUMNINFO* pcmci
        );

        [VtblIndex(5)]
        HRESULT GetColumnCount(CM_ENUM_FLAGS dwFlags, uint* puCount);

        [VtblIndex(6)]
        HRESULT GetColumns(CM_ENUM_FLAGS dwFlags, PROPERTYKEY* rgkeyOrder, uint cColumns);

        [VtblIndex(7)]
        HRESULT SetColumns(
            [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgkeyOrder,
            uint cVisible
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

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const CM_COLUMNINFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, CM_COLUMNINFO*, int> SetColumnInfo;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, CM_COLUMNINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, CM_COLUMNINFO*, int> GetColumnInfo;

        [NativeTypeName("HRESULT (CM_ENUM_FLAGS, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CM_ENUM_FLAGS, uint*, int> GetColumnCount;

        [NativeTypeName("HRESULT (CM_ENUM_FLAGS, PROPERTYKEY *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CM_ENUM_FLAGS, PROPERTYKEY*, uint, int> GetColumns;

        [NativeTypeName("HRESULT (const PROPERTYKEY *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, uint, int> SetColumns;
    }

    /// <summary>Initializes a new instance of the <see cref = "IColumnManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IColumnManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IColumnManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IColumnManager(Silk.NET.Windows.IUnknown value)
    {
        return new IColumnManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IColumnManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IColumnManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IColumnManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
