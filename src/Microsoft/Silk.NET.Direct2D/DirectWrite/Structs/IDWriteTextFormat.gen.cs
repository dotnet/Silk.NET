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
    [Guid("9c906818-31d7-4fd3-a151-7c5e225db55a")]
    [NativeName("Name", "IDWriteTextFormat")]
    public unsafe partial struct IDWriteTextFormat : IComVtbl<IDWriteTextFormat>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("9c906818-31d7-4fd3-a151-7c5e225db55a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextFormat val)
            => Unsafe.As<IDWriteTextFormat, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextFormat
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
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAlignment(TextAlignment textAlignment)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWordWrapping(WordWrapping wordWrapping)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetReadingDirection(ReadingDirection readingDirection)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFlowDirection(FlowDirection flowDirection)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIncrementalTabStop(float incrementalTabStop)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ref IDWriteInlineObject trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ref IDWriteInlineObject trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TextAlignment GetTextAlignment()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, TextAlignment>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ParagraphAlignment GetParagraphAlignment()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ParagraphAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly WordWrapping GetWordWrapping()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            WordWrapping ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, WordWrapping>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetReadingDirection()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, ReadingDirection>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FlowDirection GetFlowDirection()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FlowDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FlowDirection>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetIncrementalTabStop()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(ref Trimming trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(ref Trimming trimmingOptions, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* baselinePtr = &baseline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baselinePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baseline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                fixed (float* baselinePtr = &baseline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baselinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baseline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* baselinePtr = &baseline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baselinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* lineSpacingPtr = &lineSpacing)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baseline);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* lineSpacingPtr = &lineSpacing)
                {
                    fixed (float* baselinePtr = &baseline)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baselinePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyNameLength()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamilyName(char* fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamilyName(ref char fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamilyName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, byte*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetFontWeight()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontWeight>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetFontStyle()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontStyle>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetFontStretch()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, FontStretch>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetFontSize()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, float>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLocaleNameLength()
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, uint>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(char* localeName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocaleName(ref char localeName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, char*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocaleName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint nameSize)
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextFormat*, byte*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTrimming(trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTrimming<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTrimming(in trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming<TI0>(Trimming* trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTrimming(trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTrimming<TI0>(ref Trimming trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTrimming(ref trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontCollection<TI0>(ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextFormat*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
