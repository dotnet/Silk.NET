// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("54384F1B-5B3E-4BB7-AE01-60BA3097CBB6")]
[NativeTypeName("struct ID3D11LibraryReflection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11LibraryReflection
    : ID3D11LibraryReflection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11LibraryReflection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11LibraryReflection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11LibraryReflection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11LibraryReflection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDesc(D3D11_LIBRARY_DESC* pDesc)
    {
        return (
            (delegate* unmanaged<ID3D11LibraryReflection, D3D11_LIBRARY_DESC*, int>)((*lpVtbl)[3])
        )(this, pDesc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex)
    {
        return (
            (delegate* unmanaged<ID3D11LibraryReflection, int, ID3D11FunctionReflection*>)(
                (*lpVtbl)[4]
            )
        )(this, FunctionIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDesc(D3D11_LIBRARY_DESC* pDesc);

        [VtblIndex(4)]
        ID3D11FunctionReflection* GetFunctionByIndex(int FunctionIndex);
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
            "HRESULT (D3D11_LIBRARY_DESC *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D3D11_LIBRARY_DESC*, int> GetDesc;

        [NativeTypeName(
            "ID3D11FunctionReflection *(INT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, ID3D11FunctionReflection*> GetFunctionByIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11LibraryReflection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11LibraryReflection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11LibraryReflection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11LibraryReflection(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11LibraryReflection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11LibraryReflection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11LibraryReflection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11LibraryReflection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
