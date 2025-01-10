// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E318AD57-0AA0-450F-ACA5-6FAB7103D917")]
[NativeTypeName("struct IPersistSerializedPropStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPersistSerializedPropStorage
    : IPersistSerializedPropStorage.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistSerializedPropStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPersistSerializedPropStorage, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags)
    {
        return ((delegate* unmanaged<IPersistSerializedPropStorage, int, int>)((*lpVtbl)[3]))(
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
                IPersistSerializedPropStorage,
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
                IPersistSerializedPropStorage,
                PCUSERIALIZEDPROPSTORAGE*,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, ppsps, pcb);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFlags([NativeTypeName("PERSIST_SPROPSTORE_FLAGS")] int flags);

        [VtblIndex(4)]
        HRESULT SetPropertyStorage(
            PCUSERIALIZEDPROPSTORAGE psps,
            [NativeTypeName("DWORD")] uint cb
        );

        [VtblIndex(5)]
        HRESULT GetPropertyStorage(
            [NativeTypeName("SERIALIZEDPROPSTORAGE **")] PCUSERIALIZEDPROPSTORAGE* ppsps,
            [NativeTypeName("DWORD *")] uint* pcb
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistSerializedPropStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistSerializedPropStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistSerializedPropStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistSerializedPropStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistSerializedPropStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistSerializedPropStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistSerializedPropStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistSerializedPropStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
