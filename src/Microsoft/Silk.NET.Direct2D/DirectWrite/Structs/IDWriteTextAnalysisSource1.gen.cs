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
    [Guid("639cfad8-0fb4-4b21-a58a-067920120009")]
    [NativeName("Name", "IDWriteTextAnalysisSource1")]
    public unsafe partial struct IDWriteTextAnalysisSource1 : IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("639cfad8-0fb4-4b21-a58a-067920120009");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextAnalysisSource(IDWriteTextAnalysisSource1 val)
            => Unsafe.As<IDWriteTextAnalysisSource1, IDWriteTextAnalysisSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalysisSource1 val)
            => Unsafe.As<IDWriteTextAnalysisSource1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalysisSource1
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
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textStringPtr, textLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                fixed (uint* textLengthPtr = &textLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textStringPtr, textLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textStringPtr, textLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                fixed (uint* textLengthPtr = &textLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textStringPtr, textLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetParagraphReadingDirection()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, ReadingDirection>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLengthPtr, localeName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (char** localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLengthPtr, localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, uint* textLength, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitutionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, ref uint textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLengthPtr, numberSubstitution);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, ref uint textLength, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLengthPtr, numberSubstitutionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientation, bidiLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, ref byte bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bidiLevelPtr = &bidiLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientation, bidiLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bidiLevelPtr = (byte*) SilkMarshal.StringToPtr(bidiLevel, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientation, bidiLevelPtr);
            SilkMarshal.Free((nint)bidiLevelPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, ref VerticalGlyphOrientation glyphOrientation, byte* bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientationPtr, bidiLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, ref VerticalGlyphOrientation glyphOrientation, ref byte bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
            {
                fixed (byte* bidiLevelPtr = &bidiLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientationPtr, bidiLevelPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, ref VerticalGlyphOrientation glyphOrientation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
            {
            var bidiLevelPtr = (byte*) SilkMarshal.StringToPtr(bidiLevel, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientationPtr, bidiLevelPtr);
            SilkMarshal.Free((nint)bidiLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientation, bidiLevel);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, VerticalGlyphOrientation* glyphOrientation, ref byte bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (byte* bidiLevelPtr = &bidiLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientation, bidiLevelPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, VerticalGlyphOrientation* glyphOrientation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
            var bidiLevelPtr = (byte*) SilkMarshal.StringToPtr(bidiLevel, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientation, bidiLevelPtr);
            SilkMarshal.Free((nint)bidiLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, ref VerticalGlyphOrientation glyphOrientation, byte* bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientationPtr, bidiLevel);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, ref VerticalGlyphOrientation glyphOrientation, ref byte bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
                {
                    fixed (byte* bidiLevelPtr = &bidiLevel)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientationPtr, bidiLevelPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVerticalGlyphOrientation(uint textPosition, ref uint textLength, ref VerticalGlyphOrientation glyphOrientation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                fixed (VerticalGlyphOrientation* glyphOrientationPtr = &glyphOrientation)
                {
            var bidiLevelPtr = (byte*) SilkMarshal.StringToPtr(bidiLevel, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLengthPtr, glyphOrientationPtr, bidiLevelPtr);
            SilkMarshal.Free((nint)bidiLevelPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
            var ret = @this->GetTextAtPosition(textPosition, textString, textLength);
            SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
            SilkMarshal.Free((nint) textString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
            var ret = @this->GetTextAtPosition(textPosition, textString, ref textLength);
            SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
            SilkMarshal.Free((nint) textString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
            var ret = @this->GetTextBeforePosition(textPosition, textString, textLength);
            SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
            SilkMarshal.Free((nint) textString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var textString = (char**) SilkMarshal.StringArrayToPtr(textStringSa);
            var ret = @this->GetTextBeforePosition(textPosition, textString, ref textLength);
            SilkMarshal.CopyPtrToStringArray((nint) textString, textStringSa);
            SilkMarshal.Free((nint) textString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] localeNameSa)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var localeName = (char**) SilkMarshal.StringArrayToPtr(localeNameSa);
            var ret = @this->GetLocaleName(textPosition, textLength, localeName);
            SilkMarshal.CopyPtrToStringArray((nint) localeName, localeNameSa);
            SilkMarshal.Free((nint) localeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLocaleName(uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] localeNameSa)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var localeName = (char**) SilkMarshal.StringArrayToPtr(localeNameSa);
            var ret = @this->GetLocaleName(textPosition, ref textLength, localeName);
            SilkMarshal.CopyPtrToStringArray((nint) localeName, localeNameSa);
            SilkMarshal.Free((nint) localeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution<TI0>(uint textPosition, uint* textLength, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNumberSubstitution(textPosition, textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNumberSubstitution<TI0>(uint textPosition, ref uint textLength, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNumberSubstitution(textPosition, ref textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
