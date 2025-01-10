// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("587A461C-B80B-4F54-9194-5032589A6319")]
[NativeTypeName("struct IDiaReadExeAtOffsetCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaReadExeAtOffsetCallback
    : IDiaReadExeAtOffsetCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaReadExeAtOffsetCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDiaReadExeAtOffsetCallback, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaReadExeAtOffsetCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadExecutableAt(
        [NativeTypeName("DWORDLONG")] ulong fileOffset,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData
    )
    {
        return (
            (delegate* unmanaged<IDiaReadExeAtOffsetCallback, ulong, uint, uint*, byte*, int>)(
                (*lpVtbl)[3]
            )
        )(this, fileOffset, cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadExecutableAt(
            [NativeTypeName("DWORDLONG")] ulong fileOffset,
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData
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

        [NativeTypeName("HRESULT (DWORDLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, byte*, int> ReadExecutableAt;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaReadExeAtOffsetCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaReadExeAtOffsetCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaReadExeAtOffsetCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaReadExeAtOffsetCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaReadExeAtOffsetCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaReadExeAtOffsetCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaReadExeAtOffsetCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaReadExeAtOffsetCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
