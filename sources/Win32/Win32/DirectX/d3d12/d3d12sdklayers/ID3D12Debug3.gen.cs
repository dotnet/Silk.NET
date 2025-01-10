// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("5CF4E58F-F671-4FF1-A542-3686E3D153D1")]
[NativeTypeName("struct ID3D12Debug3 : ID3D12Debug")]
[NativeInheritance("ID3D12Debug")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12Debug3 : ID3D12Debug3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12Debug3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug3, void>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug3, BOOL, void>)((*lpVtbl)[4]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug3, BOOL, void>)((*lpVtbl)[5]))(this, Enable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12Debug3, D3D12_GPU_BASED_VALIDATION_FLAGS, void>)((*lpVtbl)[6]))(
            this,
            Flags
        );
    }

    public interface Interface : ID3D12Debug.Interface
    {
        [VtblIndex(4)]
        void SetEnableGPUBasedValidation(BOOL Enable);

        [VtblIndex(5)]
        void SetEnableSynchronizedCommandQueueValidation(BOOL Enable);

        [VtblIndex(6)]
        void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Debug3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Debug3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12Debug"/> to <see cref = "ID3D12Debug3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12Debug"/> instance to be converted </param>
    public static explicit operator ID3D12Debug3(Silk.NET.DirectX.ID3D12Debug value)
    {
        return new ID3D12Debug3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug3"/> to <see cref = "Silk.NET.DirectX.ID3D12Debug"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12Debug(ID3D12Debug3 value)
    {
        return new Silk.NET.DirectX.ID3D12Debug(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12Debug3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12Debug3(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12Debug3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12Debug3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Debug3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12Debug3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
