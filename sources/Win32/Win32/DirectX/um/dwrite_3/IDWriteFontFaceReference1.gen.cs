// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("C081FE77-2FD1-41AC-A5A3-34983C4BA61A")]
[NativeTypeName("struct IDWriteFontFaceReference1 : IDWriteFontFaceReference")]
[NativeInheritance("IDWriteFontFaceReference")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontFaceReference1
    : IDWriteFontFaceReference1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontFaceReference1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateFontFace(IDWriteFontFace3* fontFace)
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, IDWriteFontFace3*, int>)((*lpVtbl)[3])
        )(this, fontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateFontFaceWithSimulations(
        DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags,
        IDWriteFontFace3* fontFace
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontFaceReference1,
                DWRITE_FONT_SIMULATIONS,
                IDWriteFontFace3*,
                int>)((*lpVtbl)[4])
        )(this, fontFaceSimulationFlags, fontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL Equals(IDWriteFontFaceReference fontFaceReference)
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, IDWriteFontFaceReference, int>)(
                (*lpVtbl)[5]
            )
        )(this, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFaceIndex()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, uint>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public DWRITE_FONT_SIMULATIONS GetSimulations()
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, DWRITE_FONT_SIMULATIONS>)((*lpVtbl)[7])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFontFile(IDWriteFontFile* fontFile)
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, IDWriteFontFile*, int>)((*lpVtbl)[8])
        )(this, fontFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetLocalFileSize()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, ulong>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetFileSize()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, ulong>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFileTime(FILETIME* lastWriteTime)
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, FILETIME*, int>)((*lpVtbl)[11]))(
            this,
            lastWriteTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_LOCALITY GetLocality()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, DWRITE_LOCALITY>)((*lpVtbl)[12]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT EnqueueFontDownloadRequest()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnqueueCharacterDownloadRequest(
        [NativeTypeName("const WCHAR *")] ushort* characters,
        [NativeTypeName("UINT32")] uint characterCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, ushort*, uint, int>)((*lpVtbl)[14])
        )(this, characters, characterCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT EnqueueGlyphDownloadRequest(
        [NativeTypeName("const UINT16 *")] ushort* glyphIndices,
        [NativeTypeName("UINT32")] uint glyphCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, ushort*, uint, int>)((*lpVtbl)[15])
        )(this, glyphIndices, glyphCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnqueueFileFragmentDownloadRequest(
        [NativeTypeName("UINT64")] ulong fileOffset,
        [NativeTypeName("UINT64")] ulong fragmentSize
    )
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, ulong, ulong, int>)((*lpVtbl)[16]))(
            this,
            fileOffset,
            fragmentSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateFontFace(IDWriteFontFace5* fontFace)
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, IDWriteFontFace5*, int>)((*lpVtbl)[17])
        )(this, fontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontAxisValueCount()
    {
        return ((delegate* unmanaged<IDWriteFontFaceReference1, uint>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontAxisValues(
        DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontFaceReference1, DWRITE_FONT_AXIS_VALUE*, uint, int>)(
                (*lpVtbl)[19]
            )
        )(this, fontAxisValues, fontAxisValueCount);
    }

    public interface Interface : IDWriteFontFaceReference.Interface
    {
        [VtblIndex(17)]
        HRESULT CreateFontFace(IDWriteFontFace5* fontFace);

        [VtblIndex(18)]
        [return: NativeTypeName("UINT32")]
        uint GetFontAxisValueCount();

        [VtblIndex(19)]
        HRESULT GetFontAxisValues(
            DWRITE_FONT_AXIS_VALUE* fontAxisValues,
            [NativeTypeName("UINT32")] uint fontAxisValueCount
        );
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

        [NativeTypeName(
            "HRESULT (IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFace3*, int> CreateFontFace;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_SIMULATIONS, IDWriteFontFace3 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_SIMULATIONS,
            IDWriteFontFace3*,
            int> CreateFontFaceWithSimulations;

        [NativeTypeName(
            "BOOL (IDWriteFontFaceReference *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public new delegate* unmanaged<TSelf*, IDWriteFontFaceReference, int> Equals;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFaceIndex;

        [NativeTypeName(
            "DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS> GetSimulations;

        [NativeTypeName(
            "HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFile*, int> GetFontFile;

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

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> EnqueueCharacterDownloadRequest;

        [NativeTypeName(
            "HRESULT (const UINT16 *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> EnqueueGlyphDownloadRequest;

        [NativeTypeName(
            "HRESULT (UINT64, UINT64) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, ulong, int> EnqueueFileFragmentDownloadRequest;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFace5*, int> CreateFontFace1;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontAxisValueCount;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetFontAxisValues;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontFaceReference1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontFaceReference1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontFaceReference"/> to <see cref = "IDWriteFontFaceReference1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontFaceReference"/> instance to be converted </param>
    public static explicit operator IDWriteFontFaceReference1(
        Silk.NET.DirectX.IDWriteFontFaceReference value
    )
    {
        return new IDWriteFontFaceReference1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFaceReference1"/> to <see cref = "Silk.NET.DirectX.IDWriteFontFaceReference"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFaceReference1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontFaceReference(
        IDWriteFontFaceReference1 value
    )
    {
        return new Silk.NET.DirectX.IDWriteFontFaceReference(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontFaceReference1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontFaceReference1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontFaceReference1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontFaceReference1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontFaceReference1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontFaceReference1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
