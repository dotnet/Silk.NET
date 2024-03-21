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
    [Guid("1093c18f-8d5e-43f0-b064-0917311b525e")]
    [NativeName("Name", "IDWriteTextLayout2")]
    public unsafe partial struct IDWriteTextLayout2 : IComVtbl<IDWriteTextLayout2>, IComVtbl<IDWriteTextLayout1>, IComVtbl<IDWriteTextLayout>, IComVtbl<IDWriteTextFormat>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1093c18f-8d5e-43f0-b064-0917311b525e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextLayout1(IDWriteTextLayout2 val)
            => Unsafe.As<IDWriteTextLayout2, IDWriteTextLayout1>(ref val);

        public static implicit operator IDWriteTextLayout(IDWriteTextLayout2 val)
            => Unsafe.As<IDWriteTextLayout2, IDWriteTextLayout>(ref val);

        public static implicit operator IDWriteTextFormat(IDWriteTextLayout2 val)
            => Unsafe.As<IDWriteTextLayout2, IDWriteTextFormat>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextLayout2 val)
            => Unsafe.As<IDWriteTextLayout2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextLayout2
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
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTextAlignment(TextAlignment textAlignment)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParagraphAlignment(ParagraphAlignment paragraphAlignment)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetWordWrapping(WordWrapping wordWrapping)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetReadingDirection(ReadingDirection readingDirection)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFlowDirection(FlowDirection flowDirection)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIncrementalTabStop(float incrementalTabStop)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ref IDWriteInlineObject trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTrimming([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ref IDWriteInlineObject trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLineSpacing(LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly TextAlignment GetTextAlignment()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, TextAlignment>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ParagraphAlignment GetParagraphAlignment()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ParagraphAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly WordWrapping GetWordWrapping()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            WordWrapping ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, WordWrapping>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetReadingDirection()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ReadingDirection>)@this->LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FlowDirection GetFlowDirection()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FlowDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FlowDirection>)@this->LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetIncrementalTabStop()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float>)@this->LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(Trimming* trimmingOptions, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(ref Trimming trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming(ref Trimming trimmingOptions, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
            {
                fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, float* lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* baselinePtr = &baseline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baselinePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baseline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                fixed (float* baselinePtr = &baseline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baselinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baseline);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* baselinePtr = &baseline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baselinePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, float* baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* lineSpacingPtr = &lineSpacing)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baseline);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLineSpacing(ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, ref float baseline)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
            {
                fixed (float* lineSpacingPtr = &lineSpacing)
                {
                    fixed (float* baselinePtr = &baseline)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baselinePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontCollection(ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyNameLength()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamilyName(char* fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamilyName(ref char fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamilyName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, byte*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontWeight GetFontWeight()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontWeight ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontWeight>)@this->LpVtbl[22])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStyle GetFontStyle()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStyle ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontStyle>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly FontStretch GetFontStretch()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            FontStretch ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontStretch>)@this->LpVtbl[24])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetFontSize()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float>)@this->LpVtbl[25])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetLocaleNameLength()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(char* localeName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocaleName(ref char localeName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocaleName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint nameSize)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, byte*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaxWidth(float maxWidth)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, int>)@this->LpVtbl[28])(@this, maxWidth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaxHeight(float maxHeight)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, int>)@this->LpVtbl[29])(@this, maxHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontCollection(IDWriteFontCollection* fontCollection, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollection, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontCollection(ref IDWriteFontCollection fontCollection, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollectionPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyName, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyNamePtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, byte*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyNamePtr, textRange);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontWeight(FontWeight fontWeight, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontWeight, TextRange, int>)@this->LpVtbl[32])(@this, fontWeight, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontStyle(FontStyle fontStyle, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontStyle, TextRange, int>)@this->LpVtbl[33])(@this, fontStyle, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontStretch(FontStretch fontStretch, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, FontStretch, TextRange, int>)@this->LpVtbl[34])(@this, fontStretch, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontSize(float fontSize, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, TextRange, int>)@this->LpVtbl[35])(@this, fontSize, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetUnderline(Silk.NET.Core.Bool32 hasUnderline, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[36])(@this, hasUnderline, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStrikethrough(Silk.NET.Core.Bool32 hasStrikethrough, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[37])(@this, hasStrikethrough, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDrawingEffect(Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffect, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDrawingEffect(ref Silk.NET.Core.Native.IUnknown drawingEffect, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* drawingEffectPtr = &drawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffectPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInlineObject(IDWriteInlineObject* inlineObject, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObject, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInlineObject(ref IDWriteInlineObject inlineObject, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObjectPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTypography(IDWriteTypography* typography, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typography, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypography(ref IDWriteTypography typography, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTypography* typographyPtr = &typography)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typographyPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLocaleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeName, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLocaleName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeNamePtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLocaleName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, byte*, TextRange, int>)@this->LpVtbl[41])(@this, localeNamePtr, textRange);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetMaxWidth()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float>)@this->LpVtbl[42])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetMaxHeight()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float>)@this->LpVtbl[43])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnderline(uint currentPosition, int* hasUnderline, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnderline(uint currentPosition, int* hasUnderline, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnderline(uint currentPosition, ref int hasUnderline, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasUnderlinePtr = &hasUnderline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderlinePtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUnderline(uint currentPosition, ref int hasUnderline, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasUnderlinePtr = &hasUnderline)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderlinePtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStrikethrough(uint currentPosition, int* hasStrikethrough, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStrikethrough(uint currentPosition, int* hasStrikethrough, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStrikethrough(uint currentPosition, ref int hasStrikethrough, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasStrikethroughPtr = &hasStrikethrough)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethroughPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStrikethrough(uint currentPosition, ref int hasStrikethrough, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasStrikethroughPtr = &hasStrikethrough)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethroughPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect(uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect(uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect(uint currentPosition, ref Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** drawingEffectPtr = &drawingEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffectPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect(uint currentPosition, ref Silk.NET.Core.Native.IUnknown* drawingEffect, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** drawingEffectPtr = &drawingEffect)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffectPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject(uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject(uint currentPosition, IDWriteInlineObject** inlineObject, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject(uint currentPosition, ref IDWriteInlineObject* inlineObject, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** inlineObjectPtr = &inlineObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObjectPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject(uint currentPosition, ref IDWriteInlineObject* inlineObject, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** inlineObjectPtr = &inlineObject)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObjectPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography(uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography(uint currentPosition, IDWriteTypography** typography, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography(uint currentPosition, ref IDWriteTypography* typography, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTypography** typographyPtr = &typography)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typographyPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography(uint currentPosition, ref IDWriteTypography* typography, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTypography** typographyPtr = &typography)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typographyPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, renderer, originX, originY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw(void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, rendererPtr, originX, originY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<T0>(ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY) where T0 : unmanaged
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContextPtr, renderer, originX, originY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0>(ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY) where T0 : unmanaged
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* clientDrawingContextPtr = &clientDrawingContext)
            {
                fixed (IDWriteTextRenderer* rendererPtr = &renderer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContextPtr, rendererPtr, originX, originY);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineMetrics(LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineMetrics(LineMetrics* lineMetrics, uint maxLineCount, ref uint actualLineCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualLineCountPtr = &actualLineCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineMetrics(ref LineMetrics lineMetrics, uint maxLineCount, uint* actualLineCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineMetrics* lineMetricsPtr = &lineMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetricsPtr, maxLineCount, actualLineCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLineMetrics(ref LineMetrics lineMetrics, uint maxLineCount, ref uint actualLineCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineMetrics* lineMetricsPtr = &lineMetrics)
            {
                fixed (uint* actualLineCountPtr = &actualLineCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetricsPtr, maxLineCount, actualLineCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetrics(TextMetrics* textMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetrics(ref TextMetrics textMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextMetrics* textMetricsPtr = &textMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOverhangMetrics(OverhangMetrics* overhangs)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOverhangMetrics(ref OverhangMetrics overhangs)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OverhangMetrics* overhangsPtr = &overhangs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClusterMetrics(ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClusterMetrics(ClusterMetrics* clusterMetrics, uint maxClusterCount, ref uint actualClusterCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualClusterCountPtr = &actualClusterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetClusterMetrics(ref ClusterMetrics clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClusterMetrics* clusterMetricsPtr = &clusterMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetricsPtr, maxClusterCount, actualClusterCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClusterMetrics(ref ClusterMetrics clusterMetrics, uint maxClusterCount, ref uint actualClusterCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ClusterMetrics* clusterMetricsPtr = &clusterMetrics)
            {
                fixed (uint* actualClusterCountPtr = &actualClusterCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetricsPtr, maxClusterCount, actualClusterCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DetermineMinWidth(float* minWidth)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float*, int>)@this->LpVtbl[63])(@this, minWidth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DetermineMinWidth(ref float minWidth)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* minWidthPtr = &minWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float*, int>)@this->LpVtbl[63])(@this, minWidthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, int* isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, int* isTrailingHit, int* isInside, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, int* isTrailingHit, ref int isInside, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isInsidePtr = &isInside)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInsidePtr, hitTestMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, int* isTrailingHit, ref int isInside, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isInsidePtr = &isInside)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInsidePtr, hitTestMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, ref int isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isTrailingHitPtr = &isTrailingHit)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInside, hitTestMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, ref int isTrailingHit, int* isInside, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isTrailingHitPtr = &isTrailingHit)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInside, hitTestMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestPoint(float pointX, float pointY, ref int isTrailingHit, ref int isInside, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isTrailingHitPtr = &isTrailingHit)
            {
                fixed (int* isInsidePtr = &isInside)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInsidePtr, hitTestMetrics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HitTestPoint(float pointX, float pointY, ref int isTrailingHit, ref int isInside, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isTrailingHitPtr = &isTrailingHit)
            {
                fixed (int* isInsidePtr = &isInside)
                {
                    fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInsidePtr, hitTestMetricsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetricsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, ref float pointY, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointYPtr = &pointY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointYPtr, hitTestMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, ref float pointY, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointYPtr = &pointY)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointYPtr, hitTestMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, float* pointY, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointXPtr = &pointX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointY, hitTestMetrics);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, float* pointY, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointXPtr = &pointX)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointY, hitTestMetricsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, ref float pointY, HitTestMetrics* hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointXPtr = &pointX)
            {
                fixed (float* pointYPtr = &pointY)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointYPtr, hitTestMetrics);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HitTestTextPosition(uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, ref float pointY, ref HitTestMetrics hitTestMetrics)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* pointXPtr = &pointX)
            {
                fixed (float* pointYPtr = &pointY)
                {
                    fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointYPtr, hitTestMetricsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, ref uint actualHitTestMetricsCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* actualHitTestMetricsCountPtr = &actualHitTestMetricsCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, ref HitTestMetrics hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetricsPtr, maxHitTestMetricsCount, actualHitTestMetricsCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, ref HitTestMetrics hitTestMetrics, uint maxHitTestMetricsCount, ref uint actualHitTestMetricsCount)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                fixed (uint* actualHitTestMetricsCountPtr = &actualHitTestMetricsCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetricsPtr, maxHitTestMetricsCount, actualHitTestMetricsCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPairKerning(Silk.NET.Core.Bool32 isPairKerningEnabled, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[67])(@this, isPairKerningEnabled, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPairKerning(uint currentPosition, int* isPairKerningEnabled, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabled, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPairKerning(uint currentPosition, int* isPairKerningEnabled, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabled, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPairKerning(uint currentPosition, ref int isPairKerningEnabled, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isPairKerningEnabledPtr = &isPairKerningEnabled)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabledPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPairKerning(uint currentPosition, ref int isPairKerningEnabled, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isPairKerningEnabledPtr = &isPairKerningEnabled)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, int*, TextRange*, int>)@this->LpVtbl[68])(@this, currentPosition, isPairKerningEnabledPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, float, float, float, TextRange, int>)@this->LpVtbl[69])(@this, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRangePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, ref float minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidthPtr, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, float* trailingSpacing, ref float minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidthPtr, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, ref float trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* trailingSpacingPtr = &trailingSpacing)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacingPtr, minimumAdvanceWidth, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, ref float trailingSpacing, float* minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* trailingSpacingPtr = &trailingSpacing)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacingPtr, minimumAdvanceWidth, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, ref float trailingSpacing, ref float minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* trailingSpacingPtr = &trailingSpacing)
            {
                fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacingPtr, minimumAdvanceWidthPtr, textRange);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, float* leadingSpacing, ref float trailingSpacing, ref float minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* trailingSpacingPtr = &trailingSpacing)
            {
                fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                {
                    fixed (TextRange* textRangePtr = &textRange)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacing, trailingSpacingPtr, minimumAdvanceWidthPtr, textRangePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacing, minimumAdvanceWidth, textRange);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, float* trailingSpacing, float* minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (TextRange* textRangePtr = &textRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacing, minimumAdvanceWidth, textRangePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, float* trailingSpacing, ref float minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacing, minimumAdvanceWidthPtr, textRange);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, float* trailingSpacing, ref float minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                {
                    fixed (TextRange* textRangePtr = &textRange)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacing, minimumAdvanceWidthPtr, textRangePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, ref float trailingSpacing, float* minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* trailingSpacingPtr = &trailingSpacing)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacingPtr, minimumAdvanceWidth, textRange);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, ref float trailingSpacing, float* minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* trailingSpacingPtr = &trailingSpacing)
                {
                    fixed (TextRange* textRangePtr = &textRange)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacingPtr, minimumAdvanceWidth, textRangePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, ref float trailingSpacing, ref float minimumAdvanceWidth, TextRange* textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* trailingSpacingPtr = &trailingSpacing)
                {
                    fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacingPtr, minimumAdvanceWidthPtr, textRange);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCharacterSpacing(uint currentPosition, ref float leadingSpacing, ref float trailingSpacing, ref float minimumAdvanceWidth, ref TextRange textRange)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* leadingSpacingPtr = &leadingSpacing)
            {
                fixed (float* trailingSpacingPtr = &trailingSpacing)
                {
                    fixed (float* minimumAdvanceWidthPtr = &minimumAdvanceWidth)
                    {
                        fixed (TextRange* textRangePtr = &textRange)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, uint, float*, float*, float*, TextRange*, int>)@this->LpVtbl[70])(@this, currentPosition, leadingSpacingPtr, trailingSpacingPtr, minimumAdvanceWidthPtr, textRangePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVerticalGlyphOrientation(VerticalGlyphOrientation glyphOrientation)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, VerticalGlyphOrientation, int>)@this->LpVtbl[72])(@this, glyphOrientation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly VerticalGlyphOrientation GetVerticalGlyphOrientation()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            VerticalGlyphOrientation ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, VerticalGlyphOrientation>)@this->LpVtbl[73])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLastLineWrapping(Silk.NET.Core.Bool32 isLastLineWrappingEnabled)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[74])(@this, isLastLineWrappingEnabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetLastLineWrapping()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, Silk.NET.Core.Bool32>)@this->LpVtbl[75])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOpticalAlignment(OpticalAlignment opticalAlignment)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, OpticalAlignment, int>)@this->LpVtbl[76])(@this, opticalAlignment);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OpticalAlignment GetOpticalAlignment()
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OpticalAlignment ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, OpticalAlignment>)@this->LpVtbl[77])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontFallback*, int>)@this->LpVtbl[78])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontFallback(ref IDWriteFontFallback fontFallback)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallback* fontFallbackPtr = &fontFallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontFallback*, int>)@this->LpVtbl[78])(@this, fontFallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontFallback**, int>)@this->LpVtbl[79])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFallback(ref IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallback** fontFallbackPtr = &fontFallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout2*, IDWriteFontFallback**, int>)@this->LpVtbl[79])(@this, fontFallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetTrimming<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTrimming(trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTrimming<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTrimming(in trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrimming<TI0>(Trimming* trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTrimming(trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTrimming<TI0>(ref Trimming trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTrimming(ref trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontCollection<TI0>(ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontCollection<TI0>(ComPtr<TI0> fontCollection, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetFontCollection((IDWriteFontCollection*) fontCollection.Handle, textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDrawingEffect<TI0>(ComPtr<TI0> drawingEffect, TextRange textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetDrawingEffect((Silk.NET.Core.Native.IUnknown*) drawingEffect.Handle, textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInlineObject<TI0>(ComPtr<TI0> inlineObject, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetInlineObject((IDWriteInlineObject*) inlineObject.Handle, textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTypography<TI0>(ComPtr<TI0> typography, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetTypography((IDWriteTypography*) typography.Handle, textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDrawingEffect<TI0>(uint currentPosition, ref ComPtr<TI0> drawingEffect, TextRange* textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDrawingEffect(currentPosition, (Silk.NET.Core.Native.IUnknown**) drawingEffect.GetAddressOf(), textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDrawingEffect<TI0>(uint currentPosition, ref ComPtr<TI0> drawingEffect, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDrawingEffect(currentPosition, (Silk.NET.Core.Native.IUnknown**) drawingEffect.GetAddressOf(), ref textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInlineObject<TI0>(uint currentPosition, ref ComPtr<TI0> inlineObject, TextRange* textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInlineObject(currentPosition, (IDWriteInlineObject**) inlineObject.GetAddressOf(), textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInlineObject<TI0>(uint currentPosition, ref ComPtr<TI0> inlineObject, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetInlineObject(currentPosition, (IDWriteInlineObject**) inlineObject.GetAddressOf(), ref textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypography<TI0>(uint currentPosition, ref ComPtr<TI0> typography, TextRange* textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypography(currentPosition, (IDWriteTypography**) typography.GetAddressOf(), textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTypography<TI0>(uint currentPosition, ref ComPtr<TI0> typography, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTypography(currentPosition, (IDWriteTypography**) typography.GetAddressOf(), ref textRange);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Draw<TI0>(void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY);
        }

        /// <summary>To be documented.</summary>
        public readonly int Draw<T0, TI0>(ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFontFallback<TI0>(ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetFontFallback((IDWriteFontFallback*) fontFallback.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFallback<TI0>(ref ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFallback((IDWriteFontFallback**) fontFallback.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextLayout2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
