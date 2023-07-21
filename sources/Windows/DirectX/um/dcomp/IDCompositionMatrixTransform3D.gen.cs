// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDCompositionMatrixTransform3D.xml' path='doc/member[@name="IDCompositionMatrixTransform3D"]/*' />
[Guid("4B3363F0-643B-41B7-B6E0-CCF22D34467C")]
[NativeTypeName("struct IDCompositionMatrixTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionMatrixTransform3D : IDCompositionMatrixTransform3D.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionMatrixTransform3D));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[1]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, uint>)(lpVtbl[2]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionMatrixTransform3D.xml' path='doc/member[@name="IDCompositionMatrixTransform3D.SetMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix)
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, D2D_MATRIX_4X4_F*, int>)(lpVtbl[3]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), matrix);
    }

    /// <include file='IDCompositionMatrixTransform3D.xml' path='doc/member[@name="IDCompositionMatrixTransform3D.SetMatrixElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, int, int, IDCompositionAnimation*, int>)(lpVtbl[4]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, animation);
    }

    /// <include file='IDCompositionMatrixTransform3D.xml' path='doc/member[@name="IDCompositionMatrixTransform3D.SetMatrixElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMatrixElement(int row, int column, float value)
    {
        return ((delegate* unmanaged<IDCompositionMatrixTransform3D*, int, int, float, int>)(lpVtbl[5]))((IDCompositionMatrixTransform3D*)Unsafe.AsPointer(ref this), row, column, value);
    }

    public interface Interface : IDCompositionTransform3D.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMatrix([NativeTypeName("const D3DMATRIX &")] D2D_MATRIX_4X4_F* matrix);

        [VtblIndex(4)]
        HRESULT SetMatrixElement(int row, int column, IDCompositionAnimation* animation);

        [VtblIndex(5)]
        HRESULT SetMatrixElement(int row, int column, float value);
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

        [NativeTypeName("HRESULT (const D3DMATRIX &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_MATRIX_4X4_F*, int> SetMatrix;

        [NativeTypeName("HRESULT (int, int, IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, IDCompositionAnimation*, int> SetMatrixElement;

        [NativeTypeName("HRESULT (int, int, float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, float, int> SetMatrixElement1;
    }
}
