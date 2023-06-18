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

public unsafe static class DWriteTextAnalysisSource1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetParagraphReadingDirection(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, ReadingDirection>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphOrientation(this ComPtr<IDWriteTextAnalysisSource1> thisVtbl, uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientation, bidiLevel);
        return ret;
    }

}
