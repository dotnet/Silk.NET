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
    [Guid("9064d822-80a7-465c-a986-df65f78b8feb")]
    [NativeName("Name", "IDWriteTextLayout1")]
    public unsafe partial struct IDWriteTextLayout1 : IComVtbl<IDWriteTextLayout1>, IComVtbl<IDWriteTextLayout>, IComVtbl<IDWriteTextFormat>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9064d822-80a7-465c-a986-df65f78b8feb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextLayout(IDWriteTextLayout1 val)
            => Unsafe.As<IDWriteTextLayout1, IDWriteTextLayout>(ref val);

        public static implicit operator IDWriteTextFormat(IDWriteTextLayout1 val)
            => Unsafe.As<IDWriteTextLayout1, IDWriteTextFormat>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextLayout1 val)
            => Unsafe.As<IDWriteTextLayout1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextLayout1
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
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAlignment(TextAlignment textAlignment)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWordWrapping(WordWrapping wordWrapping)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetReadingDirection(ReadingDirection readingDirection)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFlowDirection(FlowDirection flowDirection)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIncrementalTabStop(float incrementalTabStop)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TextAlignment GetTextAlignment()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextAlignment>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ParagraphAlignment GetParagraphAlignment()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ParagraphAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly WordWrapping GetWordWrapping()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            WordWrapping ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, WordWrapping>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetReadingDirection()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ReadingDirection>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FlowDirection GetFlowDirection()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FlowDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FlowDirection>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetIncrementalTabStop()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyNameLength()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamilyName(char* fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetFontWeight()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontWeight>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetFontStyle()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStyle>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetFontStretch()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStretch>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetFontSize()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLocaleNameLength()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(char* localeName, uint nameSize)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaxWidth(float maxWidth)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[28])(@this, maxWidth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaxHeight(float maxHeight)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, int>)@this->LpVtbl[29])(@this, maxHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontCollection(IDWriteFontCollection* fontCollection, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollection, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyName, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontWeight(FontWeight fontWeight, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontWeight, TextRange, int>)@this->LpVtbl[32])(@this, fontWeight, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontStyle(FontStyle fontStyle, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStyle, TextRange, int>)@this->LpVtbl[33])(@this, fontStyle, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontStretch(FontStretch fontStretch, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, FontStretch, TextRange, int>)@this->LpVtbl[34])(@this, fontStretch, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontSize(float fontSize, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, TextRange, int>)@this->LpVtbl[35])(@this, fontSize, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetUnderline(Silk.NET.Core.Bool32 hasUnderline, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[36])(@this, hasUnderline, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStrikethrough(Silk.NET.Core.Bool32 hasStrikethrough, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[37])(@this, hasStrikethrough, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDrawingEffect(Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffect, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInlineObject(IDWriteInlineObject* inlineObject, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObject, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypography(IDWriteTypography* typography, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typography, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLocaleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeName, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetMaxWidth()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetMaxHeight()
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float>)@this->LpVtbl[43])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnderline(uint currentPosition, int* hasUnderline, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStrikethrough(uint currentPosition, int* hasStrikethrough, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect(uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject(uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography(uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, renderer, originX, originY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineMetrics(LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetrics(TextMetrics* textMetrics)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOverhangMetrics(OverhangMetrics* overhangs)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClusterMetrics(ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetermineMinWidth(float* minWidth)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float*, int>)@this->LpVtbl[63])(@this, minWidth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, int* isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPairKerning(Silk.NET.Core.Bool32 isPairKerningEnabled, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[67])(@this, isPairKerningEnabled, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPairKerning(uint currentPosition, int* isPairKerningEnabled, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabled, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, float, float, float, TextRange, int>)@this->LpVtbl[69])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout1*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            return ret;
        }

    }
}
