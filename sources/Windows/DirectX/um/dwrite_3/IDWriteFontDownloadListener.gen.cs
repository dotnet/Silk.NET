// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteFontDownloadListener.xml' path='doc/member[@name="IDWriteFontDownloadListener"]/*' />
[Guid("B06FE5B9-43EC-4393-881B-DBE4DC72FDA7")]
[NativeTypeName("struct IDWriteFontDownloadListener : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteFontDownloadListener : IDWriteFontDownloadListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadListener));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, uint>)(lpVtbl[1]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadListener*, uint>)(lpVtbl[2]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontDownloadListener.xml' path='doc/member[@name="IDWriteFontDownloadListener.DownloadCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HRESULT downloadResult)
    {
        ((delegate* unmanaged<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, IUnknown*, HRESULT, void>)(lpVtbl[3]))((IDWriteFontDownloadListener*)Unsafe.AsPointer(ref this), downloadQueue, context, downloadResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, IUnknown* context, HRESULT downloadResult);
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

        [NativeTypeName("void (IDWriteFontDownloadQueue *, IUnknown *, HRESULT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontDownloadQueue*, IUnknown*, HRESULT, void> DownloadCompleted;
    }
}
