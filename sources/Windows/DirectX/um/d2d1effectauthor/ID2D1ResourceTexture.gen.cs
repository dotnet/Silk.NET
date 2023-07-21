// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1ResourceTexture.xml' path='doc/member[@name="ID2D1ResourceTexture"]/*' />
[Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
[NativeTypeName("struct ID2D1ResourceTexture : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1ResourceTexture : ID2D1ResourceTexture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ResourceTexture));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture*, uint>)(lpVtbl[1]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture*, uint>)(lpVtbl[2]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ResourceTexture.xml' path='doc/member[@name="ID2D1ResourceTexture.Update"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Update([NativeTypeName("const UINT32 *")] uint* minimumExtents, [NativeTypeName("const UINT32 *")] uint* maximimumExtents, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dimensions, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount)
    {
        return ((delegate* unmanaged<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)(lpVtbl[3]))((ID2D1ResourceTexture*)Unsafe.AsPointer(ref this), minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Update([NativeTypeName("const UINT32 *")] uint* minimumExtents, [NativeTypeName("const UINT32 *")] uint* maximimumExtents, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("UINT32")] uint dimensions, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount);
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

        [NativeTypeName("HRESULT (const UINT32 *, const UINT32 *, const UINT32 *, UINT32, const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, uint, byte*, uint, int> Update;
    }
}
