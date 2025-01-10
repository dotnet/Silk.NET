// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
[NativeTypeName("struct ID2D1ColorContext1 : ID2D1ColorContext")]
[NativeInheritance("ID2D1ColorContext")]
public unsafe partial struct ID2D1ColorContext1 : ID2D1ColorContext1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ColorContext1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1ColorContext1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1ColorContext1, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public D2D1_COLOR_SPACE GetColorSpace()
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, D2D1_COLOR_SPACE>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetProfileSize()
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, uint>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProfile(byte* profile, [NativeTypeName("UINT32")] uint profileSize)
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, byte*, uint, int>)((*lpVtbl)[6]))(
            this,
            profile,
            profileSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, D2D1_COLOR_CONTEXT_TYPE>)((*lpVtbl)[7]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
    {
        return ((delegate* unmanaged<ID2D1ColorContext1, DXGI_COLOR_SPACE_TYPE>)((*lpVtbl)[8]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSimpleColorProfile(D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)
    {
        return (
            (delegate* unmanaged<ID2D1ColorContext1, D2D1_SIMPLE_COLOR_PROFILE*, int>)((*lpVtbl)[9])
        )(this, simpleProfile);
    }

    public interface Interface : ID2D1ColorContext.Interface
    {
        [VtblIndex(7)]
        D2D1_COLOR_CONTEXT_TYPE GetColorContextType();

        [VtblIndex(8)]
        DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace();

        [VtblIndex(9)]
        HRESULT GetSimpleColorProfile(D2D1_SIMPLE_COLOR_PROFILE* simpleProfile);
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
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName(
            "D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_SPACE> GetColorSpace;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetProfileSize;

        [NativeTypeName(
            "HRESULT (BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, int> GetProfile;

        [NativeTypeName(
            "D2D1_COLOR_CONTEXT_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_CONTEXT_TYPE> GetColorContextType;

        [NativeTypeName(
            "DXGI_COLOR_SPACE_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DXGI_COLOR_SPACE_TYPE> GetDXGIColorSpace;

        [NativeTypeName(
            "HRESULT (D2D1_SIMPLE_COLOR_PROFILE *) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, D2D1_SIMPLE_COLOR_PROFILE*, int> GetSimpleColorProfile;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1ColorContext1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1ColorContext1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1ColorContext"/> to <see cref = "ID2D1ColorContext1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1ColorContext"/> instance to be converted </param>
    public static explicit operator ID2D1ColorContext1(Silk.NET.DirectX.ID2D1ColorContext value)
    {
        return new ID2D1ColorContext1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ColorContext1"/> to <see cref = "Silk.NET.DirectX.ID2D1ColorContext"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ColorContext1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1ColorContext(ID2D1ColorContext1 value)
    {
        return new Silk.NET.DirectX.ID2D1ColorContext(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1ColorContext1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1ColorContext1(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1ColorContext1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ColorContext1"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ColorContext1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1ColorContext1 value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1ColorContext1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1ColorContext1(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1ColorContext1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ColorContext1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ColorContext1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1ColorContext1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
