// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("45CD1EB3-5C6C-43E3-B20A-A4D8035DE4E2")]
[NativeTypeName("struct IDiaEnumSourceLink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSourceLink : IDiaEnumSourceLink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSourceLink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint*, int>)((*lpVtbl)[3]))(this, pCnt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint*, int>)((*lpVtbl)[4]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Next(
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("DWORD *")] uint* pcb,
        byte* pb
    )
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint, uint*, byte*, int>)((*lpVtbl)[5]))(
            this,
            cb,
            pcb,
            pb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("DWORD")] uint cnt)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, uint, int>)((*lpVtbl)[6]))(this, cnt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSourceLink* ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink, IDiaEnumSourceLink*, int>)((*lpVtbl)[8]))(
            this,
            ppenum
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt);

        [VtblIndex(4)]
        HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(5)]
        HRESULT Next(
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("DWORD *")] uint* pcb,
            byte* pb
        );

        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("DWORD")] uint cnt);

        [VtblIndex(7)]
        HRESULT Reset();

        [VtblIndex(8)]
        HRESULT Clone(IDiaEnumSourceLink* ppenum);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> Count;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> SizeOfNext;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, byte*, int> Next;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumSourceLink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSourceLink*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaEnumSourceLink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaEnumSourceLink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaEnumSourceLink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaEnumSourceLink(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaEnumSourceLink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumSourceLink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumSourceLink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaEnumSourceLink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
