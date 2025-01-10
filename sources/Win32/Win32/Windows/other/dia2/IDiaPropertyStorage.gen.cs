// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9D416F9C-E184-45B2-A4F0-CE517F719E9B")]
[NativeTypeName("struct IDiaPropertyStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaPropertyStorage : IDiaPropertyStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaPropertyStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaPropertyStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadMultiple(
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC *")] PROPSPEC* rgpspec,
        PROPVARIANT* rgvar
    )
    {
        return (
            (delegate* unmanaged<IDiaPropertyStorage, uint, PROPSPEC*, PROPVARIANT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, cpspec, rgpspec, rgvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ReadPropertyNames(
        [NativeTypeName("ULONG")] uint cpropid,
        [NativeTypeName("const PROPID *")] uint* rgpropid,
        [NativeTypeName("BSTR *")] ushort** rglpwstrName
    )
    {
        return (
            (delegate* unmanaged<IDiaPropertyStorage, uint, uint*, ushort**, int>)((*lpVtbl)[4])
        )(this, cpropid, rgpropid, rglpwstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Enum(IEnumSTATPROPSTG* ppenum)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, IEnumSTATPROPSTG*, int>)((*lpVtbl)[5]))(
            this,
            ppenum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadDWORD(
        [NativeTypeName("PROPID")] uint id,
        [NativeTypeName("DWORD *")] uint* pValue
    )
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint, uint*, int>)((*lpVtbl)[6]))(
            this,
            id,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadLONG(
        [NativeTypeName("PROPID")] uint id,
        [NativeTypeName("LONG *")] int* pValue
    )
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint, int*, int>)((*lpVtbl)[7]))(
            this,
            id,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadBOOL([NativeTypeName("PROPID")] uint id, BOOL* pValue)
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint, BOOL*, int>)((*lpVtbl)[8]))(
            this,
            id,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadULONGLONG(
        [NativeTypeName("PROPID")] uint id,
        [NativeTypeName("ULONGLONG *")] ulong* pValue
    )
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint, ulong*, int>)((*lpVtbl)[9]))(
            this,
            id,
            pValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadBSTR(
        [NativeTypeName("PROPID")] uint id,
        [NativeTypeName("BSTR *")] ushort** pValue
    )
    {
        return ((delegate* unmanaged<IDiaPropertyStorage, uint, ushort**, int>)((*lpVtbl)[10]))(
            this,
            id,
            pValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadMultiple(
            [NativeTypeName("ULONG")] uint cpspec,
            [NativeTypeName("const PROPSPEC *")] PROPSPEC* rgpspec,
            PROPVARIANT* rgvar
        );

        [VtblIndex(4)]
        HRESULT ReadPropertyNames(
            [NativeTypeName("ULONG")] uint cpropid,
            [NativeTypeName("const PROPID *")] uint* rgpropid,
            [NativeTypeName("BSTR *")] ushort** rglpwstrName
        );

        [VtblIndex(5)]
        HRESULT Enum(IEnumSTATPROPSTG* ppenum);

        [VtblIndex(6)]
        HRESULT ReadDWORD(
            [NativeTypeName("PROPID")] uint id,
            [NativeTypeName("DWORD *")] uint* pValue
        );

        [VtblIndex(7)]
        HRESULT ReadLONG(
            [NativeTypeName("PROPID")] uint id,
            [NativeTypeName("LONG *")] int* pValue
        );

        [VtblIndex(8)]
        HRESULT ReadBOOL([NativeTypeName("PROPID")] uint id, BOOL* pValue);

        [VtblIndex(9)]
        HRESULT ReadULONGLONG(
            [NativeTypeName("PROPID")] uint id,
            [NativeTypeName("ULONGLONG *")] ulong* pValue
        );

        [VtblIndex(10)]
        HRESULT ReadBSTR(
            [NativeTypeName("PROPID")] uint id,
            [NativeTypeName("BSTR *")] ushort** pValue
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
            "HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, PROPSPEC*, PROPVARIANT*, int> ReadMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPID *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, ushort**, int> ReadPropertyNames;

        [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATPROPSTG*, int> Enum;

        [NativeTypeName("HRESULT (PROPID, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> ReadDWORD;

        [NativeTypeName("HRESULT (PROPID, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> ReadLONG;

        [NativeTypeName("HRESULT (PROPID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, int> ReadBOOL;

        [NativeTypeName("HRESULT (PROPID, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, int> ReadULONGLONG;

        [NativeTypeName("HRESULT (PROPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> ReadBSTR;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaPropertyStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaPropertyStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaPropertyStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaPropertyStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaPropertyStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaPropertyStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaPropertyStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaPropertyStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
