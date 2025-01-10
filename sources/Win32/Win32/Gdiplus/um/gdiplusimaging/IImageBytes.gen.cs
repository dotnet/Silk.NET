// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

[Guid("025D1823-6C7D-447B-BBDB-A3CBC3DFA2FC")]
[NativeTypeName("struct IImageBytes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IImageBytes : IImageBytes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageBytes));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IImageBytes, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IImageBytes, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IImageBytes, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CountBytes(uint* pcb)
    {
        return ((delegate* unmanaged<IImageBytes, uint*, int>)((*lpVtbl)[3]))(this, pcb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LockBytes(
        uint cb,
        [NativeTypeName("ULONG")] uint ulOffset,
        [NativeTypeName("const void **")] void** ppvBytes
    )
    {
        return ((delegate* unmanaged<IImageBytes, uint, uint, void**, int>)((*lpVtbl)[4]))(
            this,
            cb,
            ulOffset,
            ppvBytes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UnlockBytes(
        [NativeTypeName("const void *")] void* pvBytes,
        uint cb,
        [NativeTypeName("ULONG")] uint ulOffset
    )
    {
        return ((delegate* unmanaged<IImageBytes, void*, uint, uint, int>)((*lpVtbl)[5]))(
            this,
            pvBytes,
            cb,
            ulOffset
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CountBytes(uint* pcb);

        [VtblIndex(4)]
        HRESULT LockBytes(
            uint cb,
            [NativeTypeName("ULONG")] uint ulOffset,
            [NativeTypeName("const void **")] void** ppvBytes
        );

        [VtblIndex(5)]
        HRESULT UnlockBytes(
            [NativeTypeName("const void *")] void* pvBytes,
            uint cb,
            [NativeTypeName("ULONG")] uint ulOffset
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> CountBytes;

        [NativeTypeName(
            "HRESULT (UINT, ULONG, const void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, void**, int> LockBytes;

        [NativeTypeName(
            "HRESULT (const void *, UINT, ULONG) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, uint, int> UnlockBytes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IImageBytes"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IImageBytes(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IImageBytes"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IImageBytes(Silk.NET.Windows.IUnknown value)
    {
        return new IImageBytes(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IImageBytes"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IImageBytes"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IImageBytes value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
