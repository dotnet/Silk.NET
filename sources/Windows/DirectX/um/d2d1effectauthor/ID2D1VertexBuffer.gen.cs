// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1VertexBuffer.xml' path='doc/member[@name="ID2D1VertexBuffer"]/*'/>
[Guid("9B8B1336-00A5-4668-92B7-CED5D8BF9B7B")]
[NativeTypeName("struct ID2D1VertexBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1VertexBuffer : ID2D1VertexBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1VertexBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, uint> )(lpVtbl[1]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, uint> )(lpVtbl[2]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1VertexBuffer.xml' path='doc/member[@name="ID2D1VertexBuffer.Map"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Map(byte** data, [NativeTypeName("UINT32")] uint bufferSize)
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, byte**, uint, int> )(lpVtbl[3]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this), data, bufferSize);
    }

    /// <include file='ID2D1VertexBuffer.xml' path='doc/member[@name="ID2D1VertexBuffer.Unmap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unmap()
    {
        return ((delegate* unmanaged<ID2D1VertexBuffer*, int> )(lpVtbl[4]))((ID2D1VertexBuffer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Map(byte** data, [NativeTypeName("UINT32")] uint bufferSize);
        [VtblIndex(4)]
        HRESULT Unmap();
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
        [NativeTypeName("HRESULT (BYTE **, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint, int> Map;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unmap;
    }
}