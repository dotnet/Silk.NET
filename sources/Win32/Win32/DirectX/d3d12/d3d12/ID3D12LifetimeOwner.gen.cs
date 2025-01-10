// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("E667AF9F-CD56-4F46-83CE-032E595D70A8")]
[NativeTypeName("struct ID3D12LifetimeOwner : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12LifetimeOwner : ID3D12LifetimeOwner.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12LifetimeOwner));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12LifetimeOwner, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12LifetimeOwner, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12LifetimeOwner, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState)
    {
        ((delegate* unmanaged<ID3D12LifetimeOwner, D3D12_LIFETIME_STATE, void>)((*lpVtbl)[3]))(
            this,
            NewState
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void LifetimeStateUpdated(D3D12_LIFETIME_STATE NewState);
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

        [NativeTypeName("void (D3D12_LIFETIME_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_LIFETIME_STATE, void> LifetimeStateUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12LifetimeOwner"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12LifetimeOwner(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12LifetimeOwner"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12LifetimeOwner(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12LifetimeOwner(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12LifetimeOwner"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12LifetimeOwner"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12LifetimeOwner value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
