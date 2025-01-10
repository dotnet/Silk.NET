// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0775B784-C75B-4449-848B-B7BD3159545B")]
[NativeTypeName("struct IDiaSegment : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaSegment : IDiaSegment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaSegment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaSegment, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaSegment, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaSegment, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_frame([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, uint*, int>)((*lpVtbl)[3]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_offset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, uint*, int>)((*lpVtbl)[4]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, uint*, int>)((*lpVtbl)[5]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_read(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, BOOL*, int>)((*lpVtbl)[6]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_write(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, BOOL*, int>)((*lpVtbl)[7]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_execute(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, BOOL*, int>)((*lpVtbl)[8]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, uint*, int>)((*lpVtbl)[9]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, uint*, int>)((*lpVtbl)[10]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSegment, ulong*, int>)((*lpVtbl)[11]))(this, pRetVal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_frame([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_offset([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(5)]
        HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_read(BOOL* pRetVal);

        [VtblIndex(7)]
        HRESULT get_write(BOOL* pRetVal);

        [VtblIndex(8)]
        HRESULT get_execute(BOOL* pRetVal);

        [VtblIndex(9)]
        HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(10)]
        HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(11)]
        HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);
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
        public delegate* unmanaged<TSelf*, uint*, int> get_frame;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_offset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_length;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_read;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_write;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_execute;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_virtualAddress;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaSegment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaSegment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaSegment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaSegment(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaSegment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaSegment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaSegment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaSegment value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
