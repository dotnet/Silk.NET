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
    [Guid("4b0b5bd3-0797-4549-8ac5-fe915cc53856")]
    [NativeName("Name", "IDWriteFactory4")]
    public unsafe partial struct IDWriteFactory4 : IComVtbl<IDWriteFactory4>, IComVtbl<IDWriteFactory3>, IComVtbl<IDWriteFactory2>, IComVtbl<IDWriteFactory1>, IComVtbl<IDWriteFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4b0b5bd3-0797-4549-8ac5-fe915cc53856");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFactory3(IDWriteFactory4 val)
            => Unsafe.As<IDWriteFactory4, IDWriteFactory3>(ref val);

        public static implicit operator IDWriteFactory2(IDWriteFactory4 val)
            => Unsafe.As<IDWriteFactory4, IDWriteFactory2>(ref val);

        public static implicit operator IDWriteFactory1(IDWriteFactory4 val)
            => Unsafe.As<IDWriteFactory4, IDWriteFactory1>(ref val);

        public static implicit operator IDWriteFactory(IDWriteFactory4 val)
            => Unsafe.As<IDWriteFactory4, IDWriteFactory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFactory4 val)
            => Unsafe.As<IDWriteFactory4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFactory4
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
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontCollection(IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMonitorRenderingParams(nint monitor, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypography(IDWriteTypography** typography)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEudcFontCollection(IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollection, checkForUpdates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontSet**, int>)@this->LpVtbl[35])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontSetBuilder**, int>)@this->LpVtbl[36])(@this, fontSetBuilder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSet, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, IDWriteFontDownloadQueue**, int>)@this->LpVtbl[39])(@this, fontDownloadQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
        {
            var @this = (IDWriteFactory4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory4*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
            return ret;
        }

    }
}
