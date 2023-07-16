// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding"]/*'/>
[Guid("7241D424-2646-4191-97C0-98E96E42FC68")]
[NativeTypeName("struct IDxcBlobEncoding : IDxcBlob")]
[NativeInheritance("IDxcBlob")]
public unsafe partial struct IDxcBlobEncoding : IDxcBlobEncoding.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobEncoding));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, Guid*, void**, int> )(lpVtbl[0]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, uint> )(lpVtbl[1]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, uint> )(lpVtbl[2]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferPointer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, void*> )(lpVtbl[3]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, nuint> )(lpVtbl[4]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobEncoding.xml' path='doc/member[@name="IDxcBlobEncoding.GetEncoding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged<IDxcBlobEncoding*, BOOL*, uint*, int> )(lpVtbl[5]))((IDxcBlobEncoding*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    public interface Interface : IDxcBlob.Interface
    {
        [VtblIndex(5)]
        HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage);
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
    }
}