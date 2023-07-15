// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteAsyncResult.xml' path='doc/member[@name="IDWriteAsyncResult"]/*'/>
[Guid("CE25F8FD-863B-4D13-9651-C1F88DC73FE2")]
[NativeTypeName("struct IDWriteAsyncResult : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteAsyncResult : IDWriteAsyncResult.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteAsyncResult));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteAsyncResult*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteAsyncResult*, uint> )(lpVtbl[1]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteAsyncResult*, uint> )(lpVtbl[2]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteAsyncResult.xml' path='doc/member[@name="IDWriteAsyncResult.GetWaitHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HANDLE GetWaitHandle()
    {
        return ((HANDLE)(((delegate* unmanaged<IDWriteAsyncResult*, void*> )(lpVtbl[3]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this))));
    }

    /// <include file='IDWriteAsyncResult.xml' path='doc/member[@name="IDWriteAsyncResult.GetResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetResult()
    {
        return ((delegate* unmanaged<IDWriteAsyncResult*, int> )(lpVtbl[4]))((IDWriteAsyncResult*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HANDLE GetWaitHandle();
        [VtblIndex(4)]
        HRESULT GetResult();
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
        [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetWaitHandle;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetResult;
    }
}