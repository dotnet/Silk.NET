// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16"]/*'/>
[Guid("A3F84EAB-0FAA-497E-A39C-EE6ED60B2D84")]
[NativeTypeName("struct IDxcBlobUtf16 : IDxcBlobEncoding")]
[NativeInheritance("IDxcBlobEncoding")]
public unsafe partial struct IDxcBlobUtf16 : IDxcBlobUtf16.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcBlobUtf16));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int> )(lpVtbl[0]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, uint> )(lpVtbl[1]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, uint> )(lpVtbl[2]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferPointer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("LPVOID")]
    public void* GetBufferPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, void*> )(lpVtbl[3]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlob.GetBufferSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetBufferSize()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, nuint> )(lpVtbl[4]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDxcBlobEncoding.GetEncoding"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetEncoding(BOOL* pKnown, [NativeTypeName("UINT32 *")] uint* pCodePage)
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, BOOL*, uint*, int> )(lpVtbl[5]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this), pKnown, pCodePage);
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringPointer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("LPCWSTR")]
    public ushort* GetStringPointer()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, ushort*> )(lpVtbl[6]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcBlobUtf16.xml' path='doc/member[@name="IDxcBlobUtf16.GetStringLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetStringLength()
    {
        return ((delegate* unmanaged<IDxcBlobUtf16*, nuint> )(lpVtbl[7]))((IDxcBlobUtf16*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDxcBlobEncoding.Interface
    {
        [VtblIndex(6)]
        [return: NativeTypeName("LPCWSTR")]
        ushort* GetStringPointer();
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
        [NativeTypeName("LPCWSTR () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*> GetStringPointer;
        [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetStringLength;
    }
}