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
    [Guid("2397599d-dd0d-4681-bd6a-f4f31eaade77")]
    [NativeName("Name", "IDWriteFontFallback1")]
    public unsafe partial struct IDWriteFontFallback1 : IComVtbl<IDWriteFontFallback1>, IComVtbl<IDWriteFontFallback>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2397599d-dd0d-4681-bd6a-f4f31eaade77");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFallback(IDWriteFontFallback1 val)
            => Unsafe.As<IDWriteFontFallback1, IDWriteFontFallback>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFallback1 val)
            => Unsafe.As<IDWriteFontFallback1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFallback1
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
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (uint* mappedLengthPtr = &mappedLength)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (uint* mappedLengthPtr = &mappedLength)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (uint* mappedLengthPtr = &mappedLength)
                        {
                            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        fixed (uint* mappedLengthPtr = &mappedLength)
                        {
                            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                            {
                                fixed (float* scalePtr = &scale)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                        }
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                        }
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                        }
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
            {
                fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                            }
                        }
                    }
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1, TI2>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0, TI1>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int MapCharacters<TI0>(ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallback1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
