// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFontFaceReference1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontFaceReference1> thisVtbl, IDWriteFontFace3** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)@this->LpVtbl[3])(@this, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref IDWriteFontFace3* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace3** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFace3**, int>)@this->LpVtbl[3])(@this, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceWithSimulations(this ComPtr<IDWriteFontFaceReference1> thisVtbl, FontSimulations fontFaceSimulationFlags, IDWriteFontFace3** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)@this->LpVtbl[4])(@this, fontFaceSimulationFlags, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceWithSimulations(this ComPtr<IDWriteFontFaceReference1> thisVtbl, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace3* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace3** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations, IDWriteFontFace3**, int>)@this->LpVtbl[4])(@this, fontFaceSimulationFlags, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe Silk.NET.Core.Bool32 Equals(this ComPtr<IDWriteFontFaceReference1> thisVtbl, IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 Equals(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref IDWriteFontFaceReference fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFaceReference*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFaceIndex(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontSimulations>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFile(this ComPtr<IDWriteFontFaceReference1> thisVtbl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFile(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetLocalFileSize(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ulong GetFileSize(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ulong ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFileTime(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[11])(@this, lastWriteTime);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFileTime(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref Silk.NET.Core.Win32Extras.Filetime lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[11])(@this, lastWriteTimePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetLocality(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, Locality>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueFontDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, int>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueCharacterDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, char*, uint, int>)@this->LpVtbl[14])(@this, characters, characterCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueCharacterDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char characters, uint characterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* charactersPtr = &characters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, char*, uint, int>)@this->LpVtbl[14])(@this, charactersPtr, characterCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueCharacterDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, byte*, uint, int>)@this->LpVtbl[14])(@this, charactersPtr, characterCount);
        SilkMarshal.Free((nint)charactersPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int EnqueueGlyphDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)@this->LpVtbl[15])(@this, glyphIndices, glyphCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueGlyphDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ushort glyphIndices, uint glyphCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ushort*, uint, int>)@this->LpVtbl[15])(@this, glyphIndicesPtr, glyphCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueFileFragmentDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ulong fileOffset, ulong fragmentSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, ulong, ulong, int>)@this->LpVtbl[16])(@this, fileOffset, fragmentSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontAxisValueCount(this ComPtr<IDWriteFontFaceReference1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, uint>)@this->LpVtbl[18])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisValues(this ComPtr<IDWriteFontFaceReference1> thisVtbl, FontAxisValue* fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)@this->LpVtbl[19])(@this, fontAxisValues, fontAxisValueCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisValues(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref FontAxisValue fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFaceReference1*, FontAxisValue*, uint, int>)@this->LpVtbl[19])(@this, fontAxisValuesPtr, fontAxisValueCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFace<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace3>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace((IDWriteFontFace3**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFaceWithSimulations<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace3>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFaceWithSimulations(fontFaceSimulationFlags, (IDWriteFontFace3**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 Equals<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Equals((IDWriteFontFaceReference*) fontFaceReference.Handle);
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 Equals(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Equals(ref fontFaceReference.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFile<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFile((IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFileTime(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Span<Silk.NET.Core.Win32Extras.Filetime> lastWriteTime)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFileTime(ref lastWriteTime.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueCharacterDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> characters, uint characterCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnqueueCharacterDownloadRequest(in characters.GetPinnableReference(), characterCount);
    }

    /// <summary>To be documented.</summary>
    public static int EnqueueGlyphDownloadRequest(this ComPtr<IDWriteFontFaceReference1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->EnqueueGlyphDownloadRequest(in glyphIndices.GetPinnableReference(), glyphCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisValues(this ComPtr<IDWriteFontFaceReference1> thisVtbl, Span<FontAxisValue> fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAxisValues(ref fontAxisValues.GetPinnableReference(), fontAxisValueCount);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFaceReference1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
