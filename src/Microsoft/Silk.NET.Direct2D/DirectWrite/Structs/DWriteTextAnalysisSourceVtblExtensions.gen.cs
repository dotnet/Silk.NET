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

public unsafe static class DWriteTextAnalysisSourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextAnalysisSource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextAnalysisSource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** textStringPtr = &textString)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textStringPtr, textLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** textStringPtr = &textString)
        {
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textStringPtr, textLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLength);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLengthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** textStringPtr = &textString)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textStringPtr, textLength);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** textStringPtr = &textString)
        {
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textStringPtr, textLengthPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetParagraphReadingDirection(this ComPtr<IDWriteTextAnalysisSource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, ReadingDirection>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLengthPtr, localeName);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            fixed (char** localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLengthPtr, localeNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitution);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitutionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLengthPtr, numberSubstitution);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textLengthPtr = &textLength)
        {
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLengthPtr, numberSubstitutionPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
        var ret = @this->GetTextAtPosition(textPosition, textString, textLength);
        SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
        SilkMarshal.Free((nint) textString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
        var ret = @this->GetTextAtPosition(textPosition, textString, ref textLength);
        SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
        SilkMarshal.Free((nint) textString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, Span<uint> textLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextAtPosition(textPosition, textString, ref textLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAtPosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, Span<uint> textLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextAtPosition(textPosition, in textString, ref textLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, uint* textLength)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
        var ret = @this->GetTextBeforePosition(textPosition, textString, textLength);
        SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
        SilkMarshal.Free((nint) textString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, ref uint textLength)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
        var ret = @this->GetTextBeforePosition(textPosition, textString, ref textLength);
        SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
        SilkMarshal.Free((nint) textString);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, Span<uint> textLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextBeforePosition(textPosition, textString, ref textLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextBeforePosition(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, Span<uint> textLength)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextBeforePosition(textPosition, in textString, ref textLength.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] localeNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var localeName = (char**) SilkMarshal.StringArrayToPtr(localeNameSa);
        var ret = @this->GetLocaleName(textPosition, textLength, localeName);
        SilkMarshal.CopyPtrToStringArray((nint) localeName, localeNameSa);
        SilkMarshal.Free((nint) localeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] localeNameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var localeName = (char**) SilkMarshal.StringArrayToPtr(localeNameSa);
        var ret = @this->GetLocaleName(textPosition, ref textLength, localeName);
        SilkMarshal.CopyPtrToStringArray((nint) localeName, localeNameSa);
        SilkMarshal.Free((nint) localeName);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, Span<uint> textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleName(textPosition, ref textLength.GetPinnableReference(), localeName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, Span<uint> textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleName(textPosition, ref textLength.GetPinnableReference(), in localeName);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, uint* textLength, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetNumberSubstitution(textPosition, textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, Span<uint> textLength, IDWriteNumberSubstitution** numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNumberSubstitution(textPosition, ref textLength.GetPinnableReference(), numberSubstitution);
    }

    /// <summary>To be documented.</summary>
    public static int GetNumberSubstitution<TI0>(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, ref uint textLength, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetNumberSubstitution(textPosition, ref textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetNumberSubstitution(this ComPtr<IDWriteTextAnalysisSource> thisVtbl, uint textPosition, Span<uint> textLength, ref IDWriteNumberSubstitution* numberSubstitution)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetNumberSubstitution(textPosition, ref textLength.GetPinnableReference(), ref numberSubstitution);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextAnalysisSource> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
