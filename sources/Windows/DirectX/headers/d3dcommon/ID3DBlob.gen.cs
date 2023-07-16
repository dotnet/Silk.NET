// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob"]/*'/>
[Guid("8BA5FB08-5195-40E2-AC58-0D989C3A0102")]
[NativeTypeName("struct ID3D10Blob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3DBlob : ID3DBlob.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Blob));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3DBlob*, Guid*, void**, int> )(lpVtbl[0]))((ID3DBlob*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3DBlob*, uint> )(lpVtbl[1]))((ID3DBlob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3DBlob*, uint> )(lpVtbl[2]))((ID3DBlob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferPointer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<ID3DBlob*, void*> )(lpVtbl[3]))((ID3DBlob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3DBlob.xml' path='doc/member[@name="ID3DBlob.GetBufferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<ID3DBlob*, nuint> )(lpVtbl[4]))((ID3DBlob*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("LPVOID")]
        void* GetBufferPointer();
        [VtblIndex(4)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetBufferSize();
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
    }
}