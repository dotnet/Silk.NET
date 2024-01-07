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
    [Guid("688e1a58-5094-47c8-adc8-fbcea60ae92b")]
    [NativeName("Name", "IDWriteTextAnalysisSource")]
    public unsafe partial struct IDWriteTextAnalysisSource : IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("688e1a58-5094-47c8-adc8-fbcea60ae92b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalysisSource val)
            => Unsafe.As<IDWriteTextAnalysisSource, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalysisSource
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textStringPtr, textLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textStringPtr = &textString)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textStringPtr, textLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* textString, ref uint textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly ReadingDirection GetParagraphReadingDirection()
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, ReadingDirection>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLengthPtr, localeName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, ref uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* localeName)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetNumberSubstitution(uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, uint* textLength, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitutionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, ref uint textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textLengthPtr = &textLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLengthPtr, numberSubstitution);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, ref uint textLength, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] textStringSa, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNumberSubstitution(textPosition, textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNumberSubstitution<TI0>(uint textPosition, ref uint textLength, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetNumberSubstitution(textPosition, ref textLength, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSource*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
