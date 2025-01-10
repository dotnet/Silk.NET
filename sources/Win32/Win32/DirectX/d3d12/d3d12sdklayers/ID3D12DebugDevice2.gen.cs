// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("60ECCBC1-378D-4DF1-894C-F8AC5CE4D7DD")]
[NativeTypeName("struct ID3D12DebugDevice2 : ID3D12DebugDevice")]
[NativeInheritance("ID3D12DebugDevice")]
public unsafe partial struct ID3D12DebugDevice2 : ID3D12DebugDevice2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12DebugDevice2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12DebugDevice2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugDevice2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice2, D3D12_DEBUG_FEATURE, int>)((*lpVtbl)[3]))(
            this,
            Mask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public D3D12_DEBUG_FEATURE GetFeatureMask()
    {
        return ((delegate* unmanaged<ID3D12DebugDevice2, D3D12_DEBUG_FEATURE>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
    {
        return ((delegate* unmanaged<ID3D12DebugDevice2, D3D12_RLDO_FLAGS, int>)((*lpVtbl)[5]))(
            this,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDebugParameter(
        D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
        [NativeTypeName("const void *")] void* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12DebugDevice2,
                D3D12_DEBUG_DEVICE_PARAMETER_TYPE,
                void*,
                uint,
                int>)((*lpVtbl)[6])
        )(this, Type, pData, DataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDebugParameter(
        D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
        void* pData,
        uint DataSize
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12DebugDevice2,
                D3D12_DEBUG_DEVICE_PARAMETER_TYPE,
                void*,
                uint,
                int>)((*lpVtbl)[7])
        )(this, Type, pData, DataSize);
    }

    public interface Interface : ID3D12DebugDevice.Interface
    {
        [VtblIndex(6)]
        HRESULT SetDebugParameter(
            D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            [NativeTypeName("const void *")] void* pData,
            uint DataSize
        );

        [VtblIndex(7)]
        HRESULT GetDebugParameter(
            D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type,
            void* pData,
            uint DataSize
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

        [NativeTypeName("HRESULT (D3D12_DEBUG_FEATURE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_FEATURE, int> SetFeatureMask;

        [NativeTypeName("D3D12_DEBUG_FEATURE () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_DEBUG_FEATURE> GetFeatureMask;

        [NativeTypeName("HRESULT (D3D12_RLDO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_RLDO_FLAGS, int> ReportLiveDeviceObjects;

        [NativeTypeName(
            "HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DEBUG_DEVICE_PARAMETER_TYPE,
            void*,
            uint,
            int> SetDebugParameter;

        [NativeTypeName(
            "HRESULT (D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_DEBUG_DEVICE_PARAMETER_TYPE,
            void*,
            uint,
            int> GetDebugParameter;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DebugDevice2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DebugDevice2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12DebugDevice"/> to <see cref = "ID3D12DebugDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12DebugDevice"/> instance to be converted </param>
    public static explicit operator ID3D12DebugDevice2(Silk.NET.DirectX.ID3D12DebugDevice value)
    {
        return new ID3D12DebugDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugDevice2"/> to <see cref = "Silk.NET.DirectX.ID3D12DebugDevice"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12DebugDevice(ID3D12DebugDevice2 value)
    {
        return new Silk.NET.DirectX.ID3D12DebugDevice(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12DebugDevice2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12DebugDevice2(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12DebugDevice2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12DebugDevice2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DebugDevice2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12DebugDevice2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
