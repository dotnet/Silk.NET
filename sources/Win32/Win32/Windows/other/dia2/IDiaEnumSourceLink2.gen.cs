// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("136D8151-ADE7-4704-AF13-324080762E8F")]
[NativeTypeName("struct IDiaEnumSourceLink2 : IDiaEnumSourceLink")]
[NativeInheritance("IDiaEnumSourceLink")]
public unsafe partial struct IDiaEnumSourceLink2 : IDiaEnumSourceLink2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSourceLink2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Count([NativeTypeName("DWORD *")] uint* pCnt)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint*, int>)((*lpVtbl)[3]))(this, pCnt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SizeOfNext([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint*, int>)((*lpVtbl)[4]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Next(
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("DWORD *")] uint* pcb,
        byte* pb
    )
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint, uint*, byte*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IDiaEnumSourceLink2, uint, int>)((*lpVtbl)[6]))(this, cnt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Clone(IDiaEnumSourceLink* ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, IDiaEnumSourceLink*, int>)((*lpVtbl)[8]))(
            this,
            ppenum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SizeOfNext2([NativeTypeName("ULONGLONG *")] ulong* pcb)
    {
        return ((delegate* unmanaged<IDiaEnumSourceLink2, ulong*, int>)((*lpVtbl)[9]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Next2(
        [NativeTypeName("ULONGLONG")] ulong cb,
        [NativeTypeName("ULONGLONG *")] ulong* pcb,
        byte* pb
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumSourceLink2, ulong, ulong*, byte*, int>)((*lpVtbl)[10])
        )(this, cb, pcb, pb);
    }

    public interface Interface : IDiaEnumSourceLink.Interface
    {
        [VtblIndex(9)]
        HRESULT SizeOfNext2([NativeTypeName("ULONGLONG *")] ulong* pcb);

        [VtblIndex(10)]
        HRESULT Next2(
            [NativeTypeName("ULONGLONG")] ulong cb,
            [NativeTypeName("ULONGLONG *")] ulong* pcb,
            byte* pb
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

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> SizeOfNext2;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, byte*, int> Next2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaEnumSourceLink2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaEnumSourceLink2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiaEnumSourceLink"/> to <see cref = "IDiaEnumSourceLink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiaEnumSourceLink"/> instance to be converted </param>
    public static explicit operator IDiaEnumSourceLink2(Silk.NET.Windows.IDiaEnumSourceLink value)
    {
        return new IDiaEnumSourceLink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumSourceLink2"/> to <see cref = "Silk.NET.Windows.IDiaEnumSourceLink"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumSourceLink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiaEnumSourceLink(IDiaEnumSourceLink2 value)
    {
        return new Silk.NET.Windows.IDiaEnumSourceLink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaEnumSourceLink2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaEnumSourceLink2(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaEnumSourceLink2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumSourceLink2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumSourceLink2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaEnumSourceLink2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
