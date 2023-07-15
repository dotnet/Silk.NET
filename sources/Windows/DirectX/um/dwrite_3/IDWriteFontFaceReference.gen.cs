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
/// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference"]/*'/>
[Guid("5E7FA7CA-DDE3-424C-89F0-9FCD6FED58CD")]
[NativeTypeName("struct IDWriteFontFaceReference : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDWriteFontFaceReference : IDWriteFontFaceReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFaceReference));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, uint> )(lpVtbl[1]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, uint> )(lpVtbl[2]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.CreateFontFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateFontFace(IDWriteFontFace3** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, IDWriteFontFace3**, int> )(lpVtbl[3]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFace);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.CreateFontFaceWithSimulations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int> )(lpVtbl[4]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFaceSimulationFlags, fontFace);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.Equals"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL Equals(IDWriteFontFaceReference* fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, IDWriteFontFaceReference*, int> )(lpVtbl[5]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFaceReference);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetFontFaceIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFaceIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, uint> )(lpVtbl[6]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetSimulations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, DWRITE_FONT_SIMULATIONS> )(lpVtbl[7]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetFontFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFile(IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, IDWriteFontFile**, int> )(lpVtbl[8]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fontFile);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetLocalFileSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetLocalFileSize()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, ulong> )(lpVtbl[9]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetFileSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetFileSize()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, ulong> )(lpVtbl[10]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetFileTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFileTime(FILETIME* lastWriteTime)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, FILETIME*, int> )(lpVtbl[11]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), lastWriteTime);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.GetLocality"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_LOCALITY GetLocality()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, DWRITE_LOCALITY> )(lpVtbl[12]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.EnqueueFontDownloadRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnqueueFontDownloadRequest()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, int> )(lpVtbl[13]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.EnqueueCharacterDownloadRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, ushort*, uint, int> )(lpVtbl[14]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), characters, characterCount);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.EnqueueGlyphDownloadRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, ushort*, uint, int> )(lpVtbl[15]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount);
    }

    /// <include file='IDWriteFontFaceReference.xml' path='doc/member[@name="IDWriteFontFaceReference.EnqueueFileFragmentDownloadRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference*, ulong, ulong, int> )(lpVtbl[16]))((IDWriteFontFaceReference*)Unsafe.AsPointer(ref this), fileOffset, fragmentSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateFontFace(IDWriteFontFace3** fontFace);
        [VtblIndex(4)]
        HRESULT CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, IDWriteFontFace3** fontFace);
        [VtblIndex(5)]
        BOOL Equals(IDWriteFontFaceReference* fontFaceReference);
        [VtblIndex(6)]
        [return: NativeTypeName("UINT32")]
        uint GetFontFaceIndex();
        [VtblIndex(7)]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        [VtblIndex(8)]
        HRESULT GetFontFile(IDWriteFontFile** fontFile);
        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        ulong GetLocalFileSize();
        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        ulong GetFileSize();
        [VtblIndex(11)]
        HRESULT GetFileTime(FILETIME* lastWriteTime);
        [VtblIndex(12)]
        DWRITE_LOCALITY GetLocality();
        [VtblIndex(13)]
        HRESULT EnqueueFontDownloadRequest();
        [VtblIndex(14)]
        HRESULT EnqueueCharacterDownloadRequest([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount);
        [VtblIndex(15)]
        HRESULT EnqueueGlyphDownloadRequest([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount);
        [VtblIndex(16)]
        HRESULT EnqueueFileFragmentDownloadRequest([NativeTypeName("UINT64")] ulong fileOffset, [NativeTypeName("UINT64")] ulong fragmentSize);
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
        [NativeTypeName("HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace3**, int> CreateFontFace;
        [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS, IDWriteFontFace3**, int> CreateFontFaceWithSimulations;
        [NativeTypeName("BOOL (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, IDWriteFontFaceReference*, int> Equals;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFaceIndex;
        [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;
        [NativeTypeName("HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFile**, int> GetFontFile;
        [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetLocalFileSize;
        [NativeTypeName("UINT64 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetFileSize;
        [NativeTypeName("HRESULT (FILETIME *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, int> GetFileTime;
        [NativeTypeName("DWRITE_LOCALITY () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_LOCALITY> GetLocality;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnqueueFontDownloadRequest;
        [NativeTypeName("HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> EnqueueCharacterDownloadRequest;
        [NativeTypeName("HRESULT (const UINT16 *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> EnqueueGlyphDownloadRequest;
        [NativeTypeName("HRESULT (UINT64, UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> EnqueueFileFragmentDownloadRequest;
    }
}