// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E5F549CD-C909-444F-8809-7CC18A9C8920")]
[NativeTypeName("struct IHolographicQuadLayerUpdateParametersInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IHolographicQuadLayerUpdateParametersInterop
    : IHolographicQuadLayerUpdateParametersInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHolographicQuadLayerUpdateParametersInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHolographicQuadLayerUpdateParametersInterop, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CommitDirect3D12Resource(
        ID3D12Resource pColorResourceToCommit,
        ID3D12Fence pColorResourceFence,
        [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue
    )
    {
        return (
            (delegate* unmanaged<
                IHolographicQuadLayerUpdateParametersInterop,
                ID3D12Resource,
                ID3D12Fence,
                ulong,
                int>)((*lpVtbl)[6])
        )(this, pColorResourceToCommit, pColorResourceFence, colorResourceFenceSignalValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CommitDirect3D12Resource(
            ID3D12Resource pColorResourceToCommit,
            ID3D12Fence pColorResourceFence,
            [NativeTypeName("UINT64")] ulong colorResourceFenceSignalValue
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ID3D12Resource *, ID3D12Fence *, UINT64) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID3D12Resource,
            ID3D12Fence,
            ulong,
            int> CommitDirect3D12Resource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHolographicQuadLayerUpdateParametersInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHolographicQuadLayerUpdateParametersInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHolographicQuadLayerUpdateParametersInterop(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHolographicQuadLayerUpdateParametersInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHolographicQuadLayerUpdateParametersInterop value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHolographicQuadLayerUpdateParametersInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHolographicQuadLayerUpdateParametersInterop(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHolographicQuadLayerUpdateParametersInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHolographicQuadLayerUpdateParametersInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHolographicQuadLayerUpdateParametersInterop value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
