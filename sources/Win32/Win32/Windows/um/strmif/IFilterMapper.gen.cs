// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A3-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFilterMapper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFilterMapper : IFilterMapper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterMapper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterMapper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFilterMapper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterMapper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterFilter(
        [NativeTypeName("CLSID")] Guid clsid,
        [NativeTypeName("LPCWSTR")] ushort* Name,
        [NativeTypeName("DWORD")] uint dwMerit
    )
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            clsid,
            Name,
            dwMerit
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RegisterFilterInstance(
        [NativeTypeName("CLSID")] Guid clsid,
        [NativeTypeName("LPCWSTR")] ushort* Name,
        [NativeTypeName("CLSID *")] Guid* MRId
    )
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, ushort*, Guid*, int>)((*lpVtbl)[4]))(
            this,
            clsid,
            Name,
            MRId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RegisterPin(
        [NativeTypeName("CLSID")] Guid Filter,
        [NativeTypeName("LPCWSTR")] ushort* Name,
        BOOL bRendered,
        BOOL bOutput,
        BOOL bZero,
        BOOL bMany,
        [NativeTypeName("CLSID")] Guid ConnectsToFilter,
        [NativeTypeName("LPCWSTR")] ushort* ConnectsToPin
    )
    {
        return (
            (delegate* unmanaged<
                IFilterMapper,
                Guid,
                ushort*,
                BOOL,
                BOOL,
                BOOL,
                BOOL,
                Guid,
                ushort*,
                int>)((*lpVtbl)[5])
        )(this, Filter, Name, bRendered, bOutput, bZero, bMany, ConnectsToFilter, ConnectsToPin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RegisterPinType(
        [NativeTypeName("CLSID")] Guid clsFilter,
        [NativeTypeName("LPCWSTR")] ushort* strName,
        [NativeTypeName("CLSID")] Guid clsMajorType,
        [NativeTypeName("CLSID")] Guid clsSubType
    )
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, ushort*, Guid, Guid, int>)((*lpVtbl)[6]))(
            this,
            clsFilter,
            strName,
            clsMajorType,
            clsSubType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnregisterFilter([NativeTypeName("CLSID")] Guid Filter)
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, int>)((*lpVtbl)[7]))(this, Filter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnregisterFilterInstance([NativeTypeName("CLSID")] Guid MRId)
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, int>)((*lpVtbl)[8]))(this, MRId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterPin(
        [NativeTypeName("CLSID")] Guid Filter,
        [NativeTypeName("LPCWSTR")] ushort* Name
    )
    {
        return ((delegate* unmanaged<IFilterMapper, Guid, ushort*, int>)((*lpVtbl)[9]))(
            this,
            Filter,
            Name
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumMatchingFilters(
        IEnumRegFilters* ppEnum,
        [NativeTypeName("DWORD")] uint dwMerit,
        BOOL bInputNeeded,
        [NativeTypeName("CLSID")] Guid clsInMaj,
        [NativeTypeName("CLSID")] Guid clsInSub,
        BOOL bRender,
        BOOL bOututNeeded,
        [NativeTypeName("CLSID")] Guid clsOutMaj,
        [NativeTypeName("CLSID")] Guid clsOutSub
    )
    {
        return (
            (delegate* unmanaged<
                IFilterMapper,
                IEnumRegFilters*,
                uint,
                BOOL,
                Guid,
                Guid,
                BOOL,
                BOOL,
                Guid,
                Guid,
                int>)((*lpVtbl)[10])
        )(
            this,
            ppEnum,
            dwMerit,
            bInputNeeded,
            clsInMaj,
            clsInSub,
            bRender,
            bOututNeeded,
            clsOutMaj,
            clsOutSub
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterFilter(
            [NativeTypeName("CLSID")] Guid clsid,
            [NativeTypeName("LPCWSTR")] ushort* Name,
            [NativeTypeName("DWORD")] uint dwMerit
        );

        [VtblIndex(4)]
        HRESULT RegisterFilterInstance(
            [NativeTypeName("CLSID")] Guid clsid,
            [NativeTypeName("LPCWSTR")] ushort* Name,
            [NativeTypeName("CLSID *")] Guid* MRId
        );

        [VtblIndex(5)]
        HRESULT RegisterPin(
            [NativeTypeName("CLSID")] Guid Filter,
            [NativeTypeName("LPCWSTR")] ushort* Name,
            BOOL bRendered,
            BOOL bOutput,
            BOOL bZero,
            BOOL bMany,
            [NativeTypeName("CLSID")] Guid ConnectsToFilter,
            [NativeTypeName("LPCWSTR")] ushort* ConnectsToPin
        );

        [VtblIndex(6)]
        HRESULT RegisterPinType(
            [NativeTypeName("CLSID")] Guid clsFilter,
            [NativeTypeName("LPCWSTR")] ushort* strName,
            [NativeTypeName("CLSID")] Guid clsMajorType,
            [NativeTypeName("CLSID")] Guid clsSubType
        );

        [VtblIndex(7)]
        HRESULT UnregisterFilter([NativeTypeName("CLSID")] Guid Filter);

        [VtblIndex(8)]
        HRESULT UnregisterFilterInstance([NativeTypeName("CLSID")] Guid MRId);

        [VtblIndex(9)]
        HRESULT UnregisterPin(
            [NativeTypeName("CLSID")] Guid Filter,
            [NativeTypeName("LPCWSTR")] ushort* Name
        );

        [VtblIndex(10)]
        HRESULT EnumMatchingFilters(
            IEnumRegFilters* ppEnum,
            [NativeTypeName("DWORD")] uint dwMerit,
            BOOL bInputNeeded,
            [NativeTypeName("CLSID")] Guid clsInMaj,
            [NativeTypeName("CLSID")] Guid clsInSub,
            BOOL bRender,
            BOOL bOututNeeded,
            [NativeTypeName("CLSID")] Guid clsOutMaj,
            [NativeTypeName("CLSID")] Guid clsOutSub
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

        [NativeTypeName("HRESULT (CLSID, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ushort*, uint, int> RegisterFilter;

        [NativeTypeName("HRESULT (CLSID, LPCWSTR, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ushort*, Guid*, int> RegisterFilterInstance;

        [NativeTypeName(
            "HRESULT (CLSID, LPCWSTR, BOOL, BOOL, BOOL, BOOL, CLSID, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            ushort*,
            BOOL,
            BOOL,
            BOOL,
            BOOL,
            Guid,
            ushort*,
            int> RegisterPin;

        [NativeTypeName("HRESULT (CLSID, LPCWSTR, CLSID, CLSID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ushort*, Guid, Guid, int> RegisterPinType;

        [NativeTypeName("HRESULT (CLSID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> UnregisterFilter;

        [NativeTypeName("HRESULT (CLSID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> UnregisterFilterInstance;

        [NativeTypeName("HRESULT (CLSID, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ushort*, int> UnregisterPin;

        [NativeTypeName(
            "HRESULT (IEnumRegFilters **, DWORD, BOOL, CLSID, CLSID, BOOL, BOOL, CLSID, CLSID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEnumRegFilters*,
            uint,
            BOOL,
            Guid,
            Guid,
            BOOL,
            BOOL,
            Guid,
            Guid,
            int> EnumMatchingFilters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFilterMapper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFilterMapper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFilterMapper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFilterMapper(Silk.NET.Windows.IUnknown value)
    {
        return new IFilterMapper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterMapper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterMapper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFilterMapper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
