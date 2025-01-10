// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("F0DB4C7F-FE5A-42A2-BD62-F2A6CF6FC83E")]
[NativeTypeName("struct IDXCoreAdapter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IDXCoreAdapter : IDXCoreAdapter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXCoreAdapter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXCoreAdapter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXCoreAdapter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public bool IsValid()
    {
        return ((delegate* unmanaged<IDXCoreAdapter, byte>)((*lpVtbl)[3]))(this) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, Guid*, byte>)((*lpVtbl)[4]))(
                this,
                attributeGUID
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public bool IsPropertySupported(DXCoreAdapterProperty property)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, DXCoreAdapterProperty, byte>)((*lpVtbl)[5]))(
                this,
                property
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProperty(
        DXCoreAdapterProperty property,
        [NativeTypeName("size_t")] nuint bufferSize,
        void* propertyData
    )
    {
        return (
            (delegate* unmanaged<IDXCoreAdapter, DXCoreAdapterProperty, nuint, void*, int>)(
                (*lpVtbl)[6]
            )
        )(this, property, bufferSize, propertyData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertySize(
        DXCoreAdapterProperty property,
        [NativeTypeName("size_t *")] nuint* bufferSize
    )
    {
        return (
            (delegate* unmanaged<IDXCoreAdapter, DXCoreAdapterProperty, nuint*, int>)((*lpVtbl)[7])
        )(this, property, bufferSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public bool IsQueryStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, DXCoreAdapterState, byte>)((*lpVtbl)[8]))(
                this,
                property
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryState(
        DXCoreAdapterState state,
        [NativeTypeName("size_t")] nuint inputStateDetailsSize,
        [NativeTypeName("const void *")] void* inputStateDetails,
        [NativeTypeName("size_t")] nuint outputBufferSize,
        void* outputBuffer
    )
    {
        return (
            (delegate* unmanaged<
                IDXCoreAdapter,
                DXCoreAdapterState,
                nuint,
                void*,
                nuint,
                void*,
                int>)((*lpVtbl)[9])
        )(this, state, inputStateDetailsSize, inputStateDetails, outputBufferSize, outputBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public bool IsSetStateSupported(DXCoreAdapterState property)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, DXCoreAdapterState, byte>)((*lpVtbl)[10]))(
                this,
                property
            ) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetState(
        DXCoreAdapterState state,
        [NativeTypeName("size_t")] nuint inputStateDetailsSize,
        [NativeTypeName("const void *")] void* inputStateDetails,
        [NativeTypeName("size_t")] nuint inputDataSize,
        [NativeTypeName("const void *")] void* inputData
    )
    {
        return (
            (delegate* unmanaged<
                IDXCoreAdapter,
                DXCoreAdapterState,
                nuint,
                void*,
                nuint,
                void*,
                int>)((*lpVtbl)[11])
        )(this, state, inputStateDetailsSize, inputStateDetails, inputDataSize, inputData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
    {
        return ((delegate* unmanaged<IDXCoreAdapter, Guid*, void**, int>)((*lpVtbl)[12]))(
            this,
            riid,
            ppvFactory
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        bool IsValid();

        [VtblIndex(4)]
        bool IsAttributeSupported([NativeTypeName("const GUID &")] Guid* attributeGUID);

        [VtblIndex(5)]
        bool IsPropertySupported(DXCoreAdapterProperty property);

        [VtblIndex(6)]
        HRESULT GetProperty(
            DXCoreAdapterProperty property,
            [NativeTypeName("size_t")] nuint bufferSize,
            void* propertyData
        );

        [VtblIndex(7)]
        HRESULT GetPropertySize(
            DXCoreAdapterProperty property,
            [NativeTypeName("size_t *")] nuint* bufferSize
        );

        [VtblIndex(8)]
        bool IsQueryStateSupported(DXCoreAdapterState property);

        [VtblIndex(9)]
        HRESULT QueryState(
            DXCoreAdapterState state,
            [NativeTypeName("size_t")] nuint inputStateDetailsSize,
            [NativeTypeName("const void *")] void* inputStateDetails,
            [NativeTypeName("size_t")] nuint outputBufferSize,
            void* outputBuffer
        );

        [VtblIndex(10)]
        bool IsSetStateSupported(DXCoreAdapterState property);

        [VtblIndex(11)]
        HRESULT SetState(
            DXCoreAdapterState state,
            [NativeTypeName("size_t")] nuint inputStateDetailsSize,
            [NativeTypeName("const void *")] void* inputStateDetails,
            [NativeTypeName("size_t")] nuint inputDataSize,
            [NativeTypeName("const void *")] void* inputData
        );

        [VtblIndex(12)]
        HRESULT GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory);
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

        [NativeTypeName("bool () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte> IsValid;

        [NativeTypeName("bool (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte> IsAttributeSupported;

        [NativeTypeName("bool (DXCoreAdapterProperty) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, byte> IsPropertySupported;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, nuint, void*, int> GetProperty;

        [NativeTypeName("HRESULT (DXCoreAdapterProperty, size_t *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXCoreAdapterProperty, nuint*, int> GetPropertySize;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXCoreAdapterState, byte> IsQueryStateSupported;

        [NativeTypeName(
            "HRESULT (DXCoreAdapterState, size_t, const void *, size_t, void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXCoreAdapterState,
            nuint,
            void*,
            nuint,
            void*,
            int> QueryState;

        [NativeTypeName("bool (DXCoreAdapterState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXCoreAdapterState, byte> IsSetStateSupported;

        [NativeTypeName(
            "HRESULT (DXCoreAdapterState, size_t, const void *, size_t, const void *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXCoreAdapterState,
            nuint,
            void*,
            nuint,
            void*,
            int> SetState;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetFactory;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXCoreAdapter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXCoreAdapter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXCoreAdapter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXCoreAdapter(Silk.NET.Windows.IUnknown value)
    {
        return new IDXCoreAdapter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXCoreAdapter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXCoreAdapter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXCoreAdapter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
