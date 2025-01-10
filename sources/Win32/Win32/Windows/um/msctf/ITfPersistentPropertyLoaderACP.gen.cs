// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4EF89150-0807-11D3-8DF0-00105A2799B5")]
[NativeTypeName("struct ITfPersistentPropertyLoaderACP : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfPersistentPropertyLoaderACP
    : ITfPersistentPropertyLoaderACP.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfPersistentPropertyLoaderACP));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfPersistentPropertyLoaderACP, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfPersistentPropertyLoaderACP, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadProperty(
        [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")]
            TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
        IStream* ppStream
    )
    {
        return (
            (delegate* unmanaged<
                ITfPersistentPropertyLoaderACP,
                TF_PERSISTENT_PROPERTY_HEADER_ACP*,
                IStream*,
                int>)((*lpVtbl)[3])
        )(this, pHdr, ppStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadProperty(
            [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")]
                TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
            IStream* ppStream
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
            "HRESULT (const TF_PERSISTENT_PROPERTY_HEADER_ACP *, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            TF_PERSISTENT_PROPERTY_HEADER_ACP*,
            IStream*,
            int> LoadProperty;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfPersistentPropertyLoaderACP"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfPersistentPropertyLoaderACP(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfPersistentPropertyLoaderACP"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfPersistentPropertyLoaderACP(Silk.NET.Windows.IUnknown value)
    {
        return new ITfPersistentPropertyLoaderACP(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfPersistentPropertyLoaderACP"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfPersistentPropertyLoaderACP"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfPersistentPropertyLoaderACP value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
