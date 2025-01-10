// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("460CAAC7-1D24-446A-A184-CA67DB494138")]
[NativeTypeName("struct ID3D12StateObjectProperties1 : ID3D12StateObjectProperties")]
[NativeInheritance("ID3D12StateObjectProperties")]
public unsafe partial struct ID3D12StateObjectProperties1
    : ID3D12StateObjectProperties1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12StateObjectProperties1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ID3D12StateObjectProperties1, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void* GetShaderIdentifier([NativeTypeName("LPCWSTR")] ushort* pExportName)
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties1, ushort*, void*>)((*lpVtbl)[3]))(
            this,
            pExportName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT64")]
    public ulong GetShaderStackSize([NativeTypeName("LPCWSTR")] ushort* pExportName)
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties1, ushort*, ulong>)((*lpVtbl)[4]))(
            this,
            pExportName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPipelineStackSize()
    {
        return ((delegate* unmanaged<ID3D12StateObjectProperties1, ulong>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetPipelineStackSize([NativeTypeName("UINT64")] ulong PipelineStackSizeInBytes)
    {
        ((delegate* unmanaged<ID3D12StateObjectProperties1, ulong, void>)((*lpVtbl)[6]))(
            this,
            PipelineStackSizeInBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier(
        [NativeTypeName("LPCWSTR")] ushort* pProgramName
    )
    {
        D3D12_PROGRAM_IDENTIFIER result;
        return *(
            (delegate* unmanaged<
                ID3D12StateObjectProperties1,
                D3D12_PROGRAM_IDENTIFIER*,
                ushort*,
                D3D12_PROGRAM_IDENTIFIER*>)((*lpVtbl)[7])
        )(this, &result, pProgramName);
    }

    public interface Interface : ID3D12StateObjectProperties.Interface
    {
        [VtblIndex(7)]
        D3D12_PROGRAM_IDENTIFIER GetProgramIdentifier(
            [NativeTypeName("LPCWSTR")] ushort* pProgramName
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

        [NativeTypeName("void *(LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*> GetShaderIdentifier;

        [NativeTypeName("UINT64 (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong> GetShaderStackSize;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetPipelineStackSize;

        [NativeTypeName("void (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, void> SetPipelineStackSize;

        [NativeTypeName("D3D12_PROGRAM_IDENTIFIER (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_PROGRAM_IDENTIFIER*,
            ushort*,
            D3D12_PROGRAM_IDENTIFIER*> GetProgramIdentifier;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12StateObjectProperties1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12StateObjectProperties1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID3D12StateObjectProperties"/> to <see cref = "ID3D12StateObjectProperties1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID3D12StateObjectProperties"/> instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties1(
        Silk.NET.DirectX.ID3D12StateObjectProperties value
    )
    {
        return new ID3D12StateObjectProperties1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12StateObjectProperties1"/> to <see cref = "Silk.NET.DirectX.ID3D12StateObjectProperties"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID3D12StateObjectProperties(
        ID3D12StateObjectProperties1 value
    )
    {
        return new Silk.NET.DirectX.ID3D12StateObjectProperties(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12StateObjectProperties1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12StateObjectProperties1(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12StateObjectProperties1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12StateObjectProperties1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12StateObjectProperties1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12StateObjectProperties1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
