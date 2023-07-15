// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue"]/*'/>
[Guid("B71E6052-5AEA-4FA3-832E-F60D431F7E91")]
[NativeTypeName("struct IDWriteFontDownloadQueue : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteFontDownloadQueue : IDWriteFontDownloadQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontDownloadQueue));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint> )(lpVtbl[1]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint> )(lpVtbl[2]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.AddListener"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddListener(IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int> )(lpVtbl[3]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), listener, token);
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.RemoveListener"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveListener([NativeTypeName("UINT32")] uint token)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, uint, int> )(lpVtbl[4]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.IsEmpty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL IsEmpty()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, int> )(lpVtbl[5]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.BeginDownload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BeginDownload(IUnknown* context = null)
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, IUnknown*, int> )(lpVtbl[6]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this), context);
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.CancelDownload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CancelDownload()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, int> )(lpVtbl[7]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontDownloadQueue.xml' path='doc/member[@name="IDWriteFontDownloadQueue.GetGenerationCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetGenerationCount()
    {
        return ((delegate* unmanaged<IDWriteFontDownloadQueue*, ulong> )(lpVtbl[8]))((IDWriteFontDownloadQueue*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddListener(IDWriteFontDownloadListener* listener, [NativeTypeName("UINT32 *")] uint* token);
        [VtblIndex(4)]
        HRESULT RemoveListener([NativeTypeName("UINT32")] uint token);
        [VtblIndex(5)]
        BOOL IsEmpty();
        [VtblIndex(6)]
        HRESULT BeginDownload(IUnknown* context = null);
        [VtblIndex(7)]
        HRESULT CancelDownload();
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetGenerationCount();
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
        [NativeTypeName("HRESULT (IDWriteFontDownloadListener *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontDownloadListener*, uint*, int> AddListener;
        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveListener;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsEmpty;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> BeginDownload;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelDownload;
        [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetGenerationCount;
    }
}