// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E901-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITextStoreACPServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreACPServices : ITextStoreACPServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreACPServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreACPServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextStoreACPServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreACPServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Serialize(
        ITfProperty pProp,
        ITfRange pRange,
        TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
        IStream pStream
    )
    {
        return (
            (delegate* unmanaged<
                ITextStoreACPServices,
                ITfProperty,
                ITfRange,
                TF_PERSISTENT_PROPERTY_HEADER_ACP*,
                IStream,
                int>)((*lpVtbl)[3])
        )(this, pProp, pRange, pHdr, pStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unserialize(
        ITfProperty pProp,
        [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")]
            TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
        IStream pStream,
        ITfPersistentPropertyLoaderACP pLoader
    )
    {
        return (
            (delegate* unmanaged<
                ITextStoreACPServices,
                ITfProperty,
                TF_PERSISTENT_PROPERTY_HEADER_ACP*,
                IStream,
                ITfPersistentPropertyLoaderACP,
                int>)((*lpVtbl)[4])
        )(this, pProp, pHdr, pStream, pLoader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ForceLoadProperty(ITfProperty pProp)
    {
        return ((delegate* unmanaged<ITextStoreACPServices, ITfProperty, int>)((*lpVtbl)[5]))(
            this,
            pProp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateRange(
        [NativeTypeName("LONG")] int acpStart,
        [NativeTypeName("LONG")] int acpEnd,
        ITfRangeACP* ppRange
    )
    {
        return (
            (delegate* unmanaged<ITextStoreACPServices, int, int, ITfRangeACP*, int>)((*lpVtbl)[6])
        )(this, acpStart, acpEnd, ppRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Serialize(
            ITfProperty pProp,
            ITfRange pRange,
            TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
            IStream pStream
        );

        [VtblIndex(4)]
        HRESULT Unserialize(
            ITfProperty pProp,
            [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")]
                TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr,
            IStream pStream,
            ITfPersistentPropertyLoaderACP pLoader
        );

        [VtblIndex(5)]
        HRESULT ForceLoadProperty(ITfProperty pProp);

        [VtblIndex(6)]
        HRESULT CreateRange(
            [NativeTypeName("LONG")] int acpStart,
            [NativeTypeName("LONG")] int acpEnd,
            ITfRangeACP* ppRange
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
            "HRESULT (ITfProperty *, ITfRange *, TF_PERSISTENT_PROPERTY_HEADER_ACP *, IStream *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITfProperty,
            ITfRange,
            TF_PERSISTENT_PROPERTY_HEADER_ACP*,
            IStream,
            int> Serialize;

        [NativeTypeName(
            "HRESULT (ITfProperty *, const TF_PERSISTENT_PROPERTY_HEADER_ACP *, IStream *, ITfPersistentPropertyLoaderACP *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITfProperty,
            TF_PERSISTENT_PROPERTY_HEADER_ACP*,
            IStream,
            ITfPersistentPropertyLoaderACP,
            int> Unserialize;

        [NativeTypeName("HRESULT (ITfProperty *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfProperty, int> ForceLoadProperty;

        [NativeTypeName("HRESULT (LONG, LONG, ITfRangeACP **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ITfRangeACP*, int> CreateRange;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextStoreACPServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextStoreACPServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextStoreACPServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextStoreACPServices(Silk.NET.Windows.IUnknown value)
    {
        return new ITextStoreACPServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextStoreACPServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextStoreACPServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextStoreACPServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
