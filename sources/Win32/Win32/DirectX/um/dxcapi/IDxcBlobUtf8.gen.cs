// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("3DA636C9-BA71-4024-A301-30CBF125305B")]
[NativeTypeName("struct IDxcBlobUtf8 : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
public unsafe partial struct IDxcBlobUtf8 : IDxcBlobUtf8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobUtf8));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcBlobUtf8, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, void*>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, nuint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, BOOL*, uint*, int>)((*lpVtbl)[5]))(
            this,
            pKnown,
            pCodePage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetStringPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, sbyte*>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8, nuint>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IDxcBlobEncoding.Interface
    {
        [VtblIndex(6)]
        [return: NativeTypeName("LPCSTR")]
        sbyte* GetStringPointer();

        [VtblIndex(7)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetStringLength();
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

        [NativeTypeName("LPVOID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetBufferPointer;

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetBufferSize;

        [NativeTypeName("HRESULT (BOOL *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, uint*, int> GetEncoding;

        [NativeTypeName("LPCSTR () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*> GetStringPointer;

        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetStringLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcBlobUtf8"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcBlobUtf8(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcBlobEncoding"/> to <see cref = "IDxcBlobUtf8"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcBlobEncoding"/> instance to be converted </param>
    public static explicit operator IDxcBlobUtf8(Silk.NET.DirectX.IDxcBlobEncoding value)
    {
        return new IDxcBlobUtf8(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcBlobUtf8"/> to <see cref = "Silk.NET.DirectX.IDxcBlobEncoding"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcBlobUtf8"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcBlobEncoding(IDxcBlobUtf8 value)
    {
        return new Silk.NET.DirectX.IDxcBlobEncoding(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcBlob"/> to <see cref = "IDxcBlobUtf8"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcBlob"/> instance to be converted </param>
    public static explicit operator IDxcBlobUtf8(Silk.NET.DirectX.IDxcBlob value)
    {
        return new IDxcBlobUtf8(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcBlobUtf8"/> to <see cref = "Silk.NET.DirectX.IDxcBlob"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcBlobUtf8"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcBlob(IDxcBlobUtf8 value)
    {
        return new Silk.NET.DirectX.IDxcBlob(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcBlobUtf8"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcBlobUtf8(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcBlobUtf8(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcBlobUtf8"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcBlobUtf8"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcBlobUtf8 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
