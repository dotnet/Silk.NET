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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFTimedTextFormattedTextVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextFormattedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextFormattedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetText(this ComPtr<IMFTimedTextFormattedText> thisVtbl, char** text)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, char**, int>)@this->LpVtbl[3])(@this, text);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetText(this ComPtr<IMFTimedTextFormattedText> thisVtbl, ref char* text)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** textPtr = &text)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, char**, int>)@this->LpVtbl[3])(@this, textPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetSubformattingCount(this ComPtr<IMFTimedTextFormattedText> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, uint* charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLength, style);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, uint* charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IMFTimedTextStyle** stylePtr = &style)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLength, stylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, ref uint charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* charLengthPtr = &charLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLengthPtr, style);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, ref uint charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* charLengthPtr = &charLength)
        {
            fixed (IMFTimedTextStyle** stylePtr = &style)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLengthPtr, stylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, uint* charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* firstCharPtr = &firstChar)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstCharPtr, charLength, style);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, uint* charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* firstCharPtr = &firstChar)
        {
            fixed (IMFTimedTextStyle** stylePtr = &style)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstCharPtr, charLength, stylePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, ref uint charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* firstCharPtr = &firstChar)
        {
            fixed (uint* charLengthPtr = &charLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstCharPtr, charLengthPtr, style);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, ref uint charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* firstCharPtr = &firstChar)
        {
            fixed (uint* charLengthPtr = &charLength)
            {
                fixed (IMFTimedTextStyle** stylePtr = &style)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstCharPtr, charLengthPtr, stylePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextFormattedText> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetText(this ComPtr<IMFTimedTextFormattedText> thisVtbl, string[] textSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var text = (char**) SilkMarshal.StringArrayToPtr(textSa);
        var ret = @this->GetText(text);
        SilkMarshal.CopyPtrToStringArray((nint) text, textSa);
        SilkMarshal.Free((nint) text);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, uint* charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSubformatting(index, firstChar, charLength, (IMFTimedTextStyle**) style.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, Span<uint> charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, firstChar, ref charLength.GetPinnableReference(), style);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, ref uint charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSubformatting(index, firstChar, ref charLength, (IMFTimedTextStyle**) style.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, uint* firstChar, Span<uint> charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, firstChar, ref charLength.GetPinnableReference(), ref style);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, Span<uint> firstChar, uint* charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, ref firstChar.GetPinnableReference(), charLength, style);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, uint* charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSubformatting(index, ref firstChar, charLength, (IMFTimedTextStyle**) style.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, Span<uint> firstChar, uint* charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, ref firstChar.GetPinnableReference(), charLength, ref style);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, Span<uint> firstChar, Span<uint> charLength, IMFTimedTextStyle** style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, ref firstChar.GetPinnableReference(), ref charLength.GetPinnableReference(), style);
    }

    /// <summary>To be documented.</summary>
    public static int GetSubformatting<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, ref uint firstChar, ref uint charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetSubformatting(index, ref firstChar, ref charLength, (IMFTimedTextStyle**) style.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSubformatting(this ComPtr<IMFTimedTextFormattedText> thisVtbl, uint index, Span<uint> firstChar, Span<uint> charLength, ref IMFTimedTextStyle* style)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSubformatting(index, ref firstChar.GetPinnableReference(), ref charLength.GetPinnableReference(), ref style);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextFormattedText> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
