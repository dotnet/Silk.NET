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

[Guid("82A816D6-5D01-4157-97D0-4975463FD1ED")]
[NativeTypeName("struct ID3D12Debug6 : ID3D12Debug5")]
[NativeInheritance("ID3D12Debug5")]
public unsafe partial struct ID3D12Debug6 : ID3D12Debug6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12Debug6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug6, void>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6, BOOL, void>)((*lpVtbl)[4]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6, BOOL, void>)((*lpVtbl)[5]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12Debug6, D3D12_GPU_BASED_VALIDATION_FLAGS, void>)((*lpVtbl)[6]))(
            this,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void DisableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug6, void>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void SetEnableAutoName(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6, BOOL, void>)((*lpVtbl)[8]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void SetForceLegacyBarrierValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug6, BOOL, void>)((*lpVtbl)[9]))(this, Enable);
    }

    public interface Interface : ID3D12Debug5.Interface
    {
        [VtblIndex(9)]
        void SetForceLegacyBarrierValidation(BOOL Enable);
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

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EnableDebugLayer;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableGPUBasedValidation;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableSynchronizedCommandQueueValidation;

        [NativeTypeName("void (D3D12_GPU_BASED_VALIDATION_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_GPU_BASED_VALIDATION_FLAGS,
            void> SetGPUBasedValidationFlags;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> DisableDebugLayer;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableAutoName;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetForceLegacyBarrierValidation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Debug5"/> to <see cref = "ID3D12Debug6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Debug5"/> instance to be converted </param>
    public static explicit operator ID3D12Debug6(Silk.NET.DirectX.ID3D12Debug5 value)
    {
        return new ID3D12Debug6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug6"/> to <see cref = "Silk.NET.DirectX.ID3D12Debug5"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Debug5(ID3D12Debug6 value)
    {
        return new Silk.NET.DirectX.ID3D12Debug5(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Debug4"/> to <see cref = "ID3D12Debug6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Debug4"/> instance to be converted </param>
    public static explicit operator ID3D12Debug6(Silk.NET.DirectX.ID3D12Debug4 value)
    {
        return new ID3D12Debug6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug6"/> to <see cref = "Silk.NET.DirectX.ID3D12Debug4"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Debug4(ID3D12Debug6 value)
    {
        return new Silk.NET.DirectX.ID3D12Debug4(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Debug3"/> to <see cref = "ID3D12Debug6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Debug3"/> instance to be converted </param>
    public static explicit operator ID3D12Debug6(Silk.NET.DirectX.ID3D12Debug3 value)
    {
        return new ID3D12Debug6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug6"/> to <see cref = "Silk.NET.DirectX.ID3D12Debug3"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Debug3(ID3D12Debug6 value)
    {
        return new Silk.NET.DirectX.ID3D12Debug3(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Debug"/> to <see cref = "ID3D12Debug6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Debug"/> instance to be converted </param>
    public static explicit operator ID3D12Debug6(Silk.NET.DirectX.ID3D12Debug value)
    {
        return new ID3D12Debug6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug6"/> to <see cref = "Silk.NET.DirectX.ID3D12Debug"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug6"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Debug(ID3D12Debug6 value)
    {
        return new Silk.NET.DirectX.ID3D12Debug(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12Debug6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12Debug6(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12Debug6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12Debug6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
