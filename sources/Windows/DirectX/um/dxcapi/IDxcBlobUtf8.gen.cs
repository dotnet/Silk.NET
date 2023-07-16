// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8"]/*'/>
[Guid("3DA636C9-BA71-4024-A301-30CBF125305B")]
[NativeTypeName("struct IDxcBlobUtf8 : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
public unsafe partial struct IDxcBlobUtf8 : IDxcBlobUtf8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobUtf8));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, Guid*, void**, int> )(lpVtbl[0]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, uint> )(lpVtbl[1]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, uint> )(lpVtbl[2]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferPointer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, void*> )(lpVtbl[3]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, nuint> )(lpVtbl[4]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlobEncoding.GetEncoding"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, BOOL*, uint*, int> )(lpVtbl[5]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    /// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8.GetStringPointer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("LPCSTR")]
    public sbyte* GetStringPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, sbyte*> )(lpVtbl[6]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobUtf8.xml' path='doc/member[@name="IDxcBlobUtf8.GetStringLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        return ((delegate* unmanaged<IDxcBlobUtf8*, nuint> )(lpVtbl[7]))((IDxcBlobUtf8*)Unsafe.AsPointer(ref this));
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
}