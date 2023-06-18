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

namespace Silk.NET.DirectWrite
{
    [Guid("6d3b5641-e550-430d-a85b-b7bf48a93427")]
    [NativeName("Name", "IDWriteTextFormat3")]
    public unsafe partial struct IDWriteTextFormat3 : IComVtbl<IDWriteTextFormat3>, IComVtbl<IDWriteTextFormat2>, IComVtbl<IDWriteTextFormat1>, IComVtbl<IDWriteTextFormat>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6d3b5641-e550-430d-a85b-b7bf48a93427");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextFormat2(IDWriteTextFormat3 val)
            => Unsafe.As<IDWriteTextFormat3, IDWriteTextFormat2>(ref val);

        public static implicit operator IDWriteTextFormat1(IDWriteTextFormat3 val)
            => Unsafe.As<IDWriteTextFormat3, IDWriteTextFormat1>(ref val);

        public static implicit operator IDWriteTextFormat(IDWriteTextFormat3 val)
            => Unsafe.As<IDWriteTextFormat3, IDWriteTextFormat>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextFormat3 val)
            => Unsafe.As<IDWriteTextFormat3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextFormat3
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAlignment(TextAlignment textAlignment)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWordWrapping(WordWrapping wordWrapping)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetReadingDirection(ReadingDirection readingDirection)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFlowDirection(FlowDirection flowDirection)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIncrementalTabStop(float incrementalTabStop)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TextAlignment GetTextAlignment()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, TextAlignment>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ParagraphAlignment GetParagraphAlignment()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ParagraphAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly WordWrapping GetWordWrapping()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            WordWrapping ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, WordWrapping>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetReadingDirection()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, ReadingDirection>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FlowDirection GetFlowDirection()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FlowDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FlowDirection>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetIncrementalTabStop()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyNameLength()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamilyName(char* fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetFontWeight()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontWeight>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetFontStyle()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontStyle>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetFontStretch()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontStretch>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetFontSize()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, float>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLocaleNameLength()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(char* localeName, uint nameSize)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, VerticalGlyphOrientation, int>)@this->LpVtbl[28])(@this, glyphOrientation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly VerticalGlyphOrientation GetVerticalGlyphOrientation()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            VerticalGlyphOrientation ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, VerticalGlyphOrientation>)@this->LpVtbl[29])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLastLineWrapping(Silk.NET.Core.Bool32 isLastLineWrappingEnabled)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[30])(@this, isLastLineWrappingEnabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetLastLineWrapping()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, Silk.NET.Core.Bool32>)@this->LpVtbl[31])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOpticalAlignment(OpticalAlignment opticalAlignment)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, OpticalAlignment, int>)@this->LpVtbl[32])(@this, opticalAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OpticalAlignment GetOpticalAlignment()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OpticalAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, OpticalAlignment>)@this->LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontFallback*, int>)@this->LpVtbl[34])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, IDWriteFontFallback**, int>)@this->LpVtbl[35])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontAxisValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontAxisValue*, uint, int>)@this->LpVtbl[38])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontAxisValueCount()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, uint>)@this->LpVtbl[39])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAxisValues(FontAxisValue* fontAxisValues, uint fontAxisValueCount)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, FontAxisValue*, uint, int>)@this->LpVtbl[40])(@this, fontAxisValues, fontAxisValueCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly AutomaticFontAxes GetAutomaticFontAxes()
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            AutomaticFontAxes ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, AutomaticFontAxes>)@this->LpVtbl[41])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAutomaticFontAxes(AutomaticFontAxes automaticFontAxes)
        {
            var @this = (IDWriteTextFormat3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat3*, AutomaticFontAxes, int>)@this->LpVtbl[42])(@this, automaticFontAxes);
            return ret;
        }

    }
}
