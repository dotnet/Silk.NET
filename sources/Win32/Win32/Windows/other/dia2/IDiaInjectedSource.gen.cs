// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
[NativeTypeName("struct IDiaInjectedSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaInjectedSource : IDiaInjectedSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaInjectedSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaInjectedSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaInjectedSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, uint*, int>)((*lpVtbl)[3]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, ulong*, int>)((*lpVtbl)[4]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_filename([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_objectFilename([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, ushort**, int>)((*lpVtbl)[6]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_virtualFilename([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, ushort**, int>)((*lpVtbl)[7]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaInjectedSource, uint*, int>)((*lpVtbl)[8]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_source(
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData
    )
    {
        return ((delegate* unmanaged<IDiaInjectedSource, uint, uint*, byte*, int>)((*lpVtbl)[9]))(
            this,
            cbData,
            pcbData,
            pbData
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_crc([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_length([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(5)]
        HRESULT get_filename([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(6)]
        HRESULT get_objectFilename([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(7)]
        HRESULT get_virtualFilename([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(8)]
        HRESULT get_sourceCompression([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(9)]
        HRESULT get_source(
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData
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
        public delegate* unmanaged<TSelf*, uint*, int> get_crc;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_length;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_filename;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_objectFilename;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_virtualFilename;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_sourceCompression;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, byte*, int> get_source;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaInjectedSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaInjectedSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaInjectedSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaInjectedSource(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaInjectedSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaInjectedSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaInjectedSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaInjectedSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
