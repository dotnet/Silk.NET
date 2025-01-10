// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
[NativeTypeName("struct ID2D1ResourceTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1ResourceTexture : ID2D1ResourceTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ResourceTexture));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1ResourceTexture, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Update(
        [NativeTypeName("const UINT32 *")] uint* minimumExtents,
        [NativeTypeName("const UINT32 *")] uint* maximimumExtents,
        [NativeTypeName("const UINT32 *")] uint* strides,
        [NativeTypeName("UINT32")] uint dimensions,
        [NativeTypeName("const BYTE *")] byte* data,
        [NativeTypeName("UINT32")] uint dataCount
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1ResourceTexture,
                uint*,
                uint*,
                uint*,
                uint,
                byte*,
                uint,
                int>)((*lpVtbl)[3])
        )(this, minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Update(
            [NativeTypeName("const UINT32 *")] uint* minimumExtents,
            [NativeTypeName("const UINT32 *")] uint* maximimumExtents,
            [NativeTypeName("const UINT32 *")] uint* strides,
            [NativeTypeName("UINT32")] uint dimensions,
            [NativeTypeName("const BYTE *")] byte* data,
            [NativeTypeName("UINT32")] uint dataCount
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

        [NativeTypeName(
            "HRESULT (const UINT32 *, const UINT32 *, const UINT32 *, UINT32, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint, byte*, uint, int> Update;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1ResourceTexture"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1ResourceTexture(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1ResourceTexture"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1ResourceTexture(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1ResourceTexture(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1ResourceTexture"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1ResourceTexture"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1ResourceTexture value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
