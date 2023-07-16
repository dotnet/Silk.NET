// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteRemoteFontFileStream.xml' path='doc/member[@name="IDWriteRemoteFontFileStream"]/*'/>
[Guid("4DB3757A-2C72-4ED9-B2B6-1ABABE1AFF9C")]
[NativeTypeName("struct IDWriteRemoteFontFileStream : IDWriteFontFileStream")]
[NativeInheritance("IDWriteFontFileStream")]
public unsafe partial struct IDWriteRemoteFontFileStream : IDWriteRemoteFontFileStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRemoteFontFileStream));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, uint> )(lpVtbl[1]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, uint> )(lpVtbl[2]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontFileStream.ReadFileFragment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadFileFragment([NativeTypeName("const void **")] void** fragmentStart, [NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, void** fragmentContext)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int> )(lpVtbl[3]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentStart, fileOffset, fragmentSize, fragmentContext);
    }

    /// <inheritdoc cref = "IDWriteFontFileStream.ReleaseFileFragment"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ReleaseFileFragment(void* fragmentContext)
    {
        ((delegate* unmanaged<IDWriteRemoteFontFileStream*, void*, void> )(lpVtbl[4]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fragmentContext);
    }

    /// <inheritdoc cref = "IDWriteFontFileStream.GetFileSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFileSize([NativeTypeName("UINT64 *")] ulong* fileSize)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int> )(lpVtbl[5]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileSize);
    }

    /// <inheritdoc cref = "IDWriteFontFileStream.GetLastWriteTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastWriteTime([NativeTypeName("UINT64 *")] ulong* lastWriteTime)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int> )(lpVtbl[6]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), lastWriteTime);
    }

    /// <include file='IDWriteRemoteFontFileStream.xml' path='doc/member[@name="IDWriteRemoteFontFileStream.GetLocalFileSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong*, int> )(lpVtbl[7]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), localFileSize);
    }

    /// <include file='IDWriteRemoteFontFileStream.xml' path='doc/member[@name="IDWriteRemoteFontFileStream.GetFileFragmentLocality"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, BOOL* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, ulong, ulong, BOOL*, ulong*, int> )(lpVtbl[8]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize, isLocal, partialSize);
    }

    /// <include file='IDWriteRemoteFontFileStream.xml' path='doc/member[@name="IDWriteRemoteFontFileStream.GetLocality"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_LOCALITY GetLocality()
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, DWRITE_LOCALITY> )(lpVtbl[9]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteRemoteFontFileStream.xml' path='doc/member[@name="IDWriteRemoteFontFileStream.BeginDownload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, IDWriteAsyncResult** asyncResult)
    {
        return ((delegate* unmanaged<IDWriteRemoteFontFileStream*, Guid*, DWRITE_FILE_FRAGMENT*, uint, IDWriteAsyncResult**, int> )(lpVtbl[10]))((IDWriteRemoteFontFileStream*)Unsafe.AsPointer(ref this), downloadOperationID, fileFragments, fragmentCount, asyncResult);
    }

    public interface Interface : IDWriteFontFileStream.Interface
    {
        [VtblIndex(7)]
        HRESULT GetLocalFileSize([NativeTypeName("UINT64 *")] ulong* localFileSize);
        [VtblIndex(8)]
        HRESULT GetFileFragmentLocality([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize, BOOL* isLocal, [NativeTypeName("UINT64 *")] ulong* partialSize);
        [VtblIndex(9)]
        DWRITE_LOCALITY GetLocality();
        [VtblIndex(10)]
        HRESULT BeginDownload([NativeTypeName("const UUID *")] Guid* downloadOperationID, [NativeTypeName("const DWRITE_FILE_FRAGMENT *")] DWRITE_FILE_FRAGMENT* fileFragments, [NativeTypeName("UINT32")] uint fragmentCount, IDWriteAsyncResult** asyncResult);
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
        [NativeTypeName("HRESULT (const void **, UINT64, UINT64, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, ulong, ulong, void**, int> ReadFileFragment;
        [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> ReleaseFileFragment;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetFileSize;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetLastWriteTime;
        [NativeTypeName("HRESULT (UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetLocalFileSize;
        [NativeTypeName("HRESULT (UINT64, UINT64, BOOL *, UINT64 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, BOOL*, ulong*, int> GetFileFragmentLocality;
        [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LOCALITY> GetLocality;
        [NativeTypeName("HRESULT (const UUID *, const DWRITE_FILE_FRAGMENT *, UINT32, IDWriteAsyncResult **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DWRITE_FILE_FRAGMENT*, uint, IDWriteAsyncResult**, int> BeginDownload;
    }
}