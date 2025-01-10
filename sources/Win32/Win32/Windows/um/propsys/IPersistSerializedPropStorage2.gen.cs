// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("77EFFA68-4F98-4366-BA72-573B3D880571")]
[NativeTypeName("struct IPersistSerializedPropStorage2 : IPersistSerializedPropStorage")]
[NativeInheritance("IPersistSerializedPropStorage")]
public unsafe partial struct IPersistSerializedPropStorage2
    : IPersistSerializedPropStorage2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistSerializedPropStorage2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPersistSerializedPropStorage2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage2, int, int>)((*lpVtbl)[3]))(
            this,
            flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPropertyStorage(
        PCUSERIALIZEDPROPSTORAGE psps,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        return (
            (delegate* unmanaged<
                IPersistSerializedPropStorage2,
                PCUSERIALIZEDPROPSTORAGE,
                uint,
                int>)((*lpVtbl)[4])
        )(this, psps, cb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyStorage(
        [NativeTypeName("SERIALIZEDPROPSTORAGE **")] PCUSERIALIZEDPROPSTORAGE* ppsps,
        [NativeTypeName("DWORD *")] uint* pcb
    )
    {
        return (
            (delegate* unmanaged<
                IPersistSerializedPropStorage2,
                PCUSERIALIZEDPROPSTORAGE*,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, ppsps, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb)
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage2, uint*, int>)((*lpVtbl)[6]))(
            this,
            pcb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyStorageBuffer(
        [NativeTypeName("SERIALIZEDPROPSTORAGE*")] PCUSERIALIZEDPROPSTORAGE psps,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("DWORD *")] uint* pcbWritten
    )
    {
        return (
            (delegate* unmanaged<
                IPersistSerializedPropStorage2,
                PCUSERIALIZEDPROPSTORAGE,
                uint,
                uint*,
                int>)((*lpVtbl)[7])
        )(this, psps, cb, pcbWritten);
    }

    public interface Interface : IPersistSerializedPropStorage.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPropertyStorageSize([NativeTypeName("DWORD *")] uint* pcb);

        [VtblIndex(7)]
        HRESULT GetPropertyStorageBuffer(
            [NativeTypeName("SERIALIZEDPROPSTORAGE*")] PCUSERIALIZEDPROPSTORAGE psps,
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("DWORD *")] uint* pcbWritten
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

        [NativeTypeName("HRESULT (PERSIST_SPROPSTORE_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetFlags;

        [NativeTypeName("HRESULT (PCUSERIALIZEDPROPSTORAGE, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PCUSERIALIZEDPROPSTORAGE, uint, int> SetPropertyStorage;

        [NativeTypeName("HRESULT (SERIALIZEDPROPSTORAGE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            PCUSERIALIZEDPROPSTORAGE*,
            uint*,
            int> GetPropertyStorage;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPropertyStorageSize;

        [NativeTypeName(
            "HRESULT (SERIALIZEDPROPSTORAGE *, DWORD, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PCUSERIALIZEDPROPSTORAGE,
            uint,
            uint*,
            int> GetPropertyStorageBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistSerializedPropStorage2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistSerializedPropStorage2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersistSerializedPropStorage"/> to <see cref = "IPersistSerializedPropStorage2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersistSerializedPropStorage"/> instance to be converted </param>
    public static explicit operator IPersistSerializedPropStorage2(
        Silk.NET.Windows.IPersistSerializedPropStorage value
    )
    {
        return new IPersistSerializedPropStorage2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistSerializedPropStorage2"/> to <see cref = "Silk.NET.Windows.IPersistSerializedPropStorage"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistSerializedPropStorage2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersistSerializedPropStorage(
        IPersistSerializedPropStorage2 value
    )
    {
        return new Silk.NET.Windows.IPersistSerializedPropStorage(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistSerializedPropStorage2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistSerializedPropStorage2(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistSerializedPropStorage2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistSerializedPropStorage2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistSerializedPropStorage2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistSerializedPropStorage2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
