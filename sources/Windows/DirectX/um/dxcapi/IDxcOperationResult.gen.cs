// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult"]/*'/>
[Guid("CEDB484A-D4E9-445A-B991-CA21CA157DC2")]
[NativeTypeName("struct IDxcOperationResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDxcOperationResult : IDxcOperationResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcOperationResult));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcOperationResult*, Guid*, void**, int> )(lpVtbl[0]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDxcOperationResult*, uint> )(lpVtbl[1]))((IDxcOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcOperationResult*, uint> )(lpVtbl[2]))((IDxcOperationResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStatus(HRESULT* pStatus)
    {
        return ((delegate* unmanaged<IDxcOperationResult*, HRESULT*, int> )(lpVtbl[3]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult(IDxcBlob** ppResult)
    {
        return ((delegate* unmanaged<IDxcOperationResult*, IDxcBlob**, int> )(lpVtbl[4]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), ppResult);
    }

    /// <include file='IDxcOperationResult.xml' path='doc/member[@name="IDxcOperationResult.GetErrorBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors)
    {
        return ((delegate* unmanaged<IDxcOperationResult*, IDxcBlobEncoding**, int> )(lpVtbl[5]))((IDxcOperationResult*)Unsafe.AsPointer(ref this), ppErrors);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStatus(HRESULT* pStatus);
        [VtblIndex(4)]
        HRESULT GetResult(IDxcBlob** ppResult);
        [VtblIndex(5)]
        HRESULT GetErrorBuffer(IDxcBlobEncoding** ppErrors);
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
        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> GetStatus;
        [NativeTypeName("HRESULT (IDxcBlob **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlob**, int> GetResult;
        [NativeTypeName("HRESULT (IDxcBlobEncoding **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDxcBlobEncoding**, int> GetErrorBuffer;
    }
}