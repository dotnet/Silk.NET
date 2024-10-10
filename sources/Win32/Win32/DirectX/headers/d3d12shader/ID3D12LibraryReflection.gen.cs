// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection"]/*'/>
[Guid("8E349D19-54DB-4A56-9DC9-119D87BDB804")]
[NativeTypeName("struct ID3D12LibraryReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12LibraryReflection
    : ID3D12LibraryReflection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12LibraryReflection));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12LibraryReflection*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12LibraryReflection*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12LibraryReflection*, uint>)(lpVtbl[1]))(
            (ID3D12LibraryReflection*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12LibraryReflection*, uint>)(lpVtbl[2]))(
            (ID3D12LibraryReflection*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetDesc"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDesc(D3D12_LIBRARY_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D12LibraryReflection*, D3D12_LIBRARY_DESC*, int>)(lpVtbl[3])
        )((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D12LibraryReflection.xml' path='doc/member[@name="ID3D12LibraryReflection.GetFunctionByIndex"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex)
    {
        return (
            (delegate* unmanaged<ID3D12LibraryReflection*, int, ID3D12FunctionReflection*>)(
                lpVtbl[4]
            )
        )((ID3D12LibraryReflection*)Unsafe.AsPointer(ref this), FunctionIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDesc(D3D12_LIBRARY_DESC* pDesc);

        [VtblIndex(4)]
        ID3D12FunctionReflection* GetFunctionByIndex(int FunctionIndex);
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
            "HRESULT (D3D12_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D12_LIBRARY_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D12FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, ID3D12FunctionReflection*> GetFunctionByIndex;
    }
}
