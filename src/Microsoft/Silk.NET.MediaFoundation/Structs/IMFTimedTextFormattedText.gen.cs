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

namespace Silk.NET.MediaFoundation
{
    [Guid("e13af3c1-4d47-4354-b1f5-e83ae0ecae60")]
    [NativeName("Name", "IMFTimedTextFormattedText")]
    public unsafe partial struct IMFTimedTextFormattedText : IComVtbl<IMFTimedTextFormattedText>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e13af3c1-4d47-4354-b1f5-e83ae0ecae60");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextFormattedText val)
            => Unsafe.As<IMFTimedTextFormattedText, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextFormattedText
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
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetText(char** text)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, char**, int>)@this->LpVtbl[3])(@this, text);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetText(ref char* text)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** textPtr = &text)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, char**, int>)@this->LpVtbl[3])(@this, textPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSubformattingCount()
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting(uint index, uint* firstChar, uint* charLength, IMFTimedTextStyle** style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLength, style);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting(uint index, uint* firstChar, uint* charLength, ref IMFTimedTextStyle* style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextStyle** stylePtr = &style)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLength, stylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting(uint index, uint* firstChar, ref uint charLength, IMFTimedTextStyle** style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* charLengthPtr = &charLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstChar, charLengthPtr, style);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting(uint index, uint* firstChar, ref uint charLength, ref IMFTimedTextStyle* style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetSubformatting(uint index, ref uint firstChar, uint* charLength, IMFTimedTextStyle** style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* firstCharPtr = &firstChar)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextFormattedText*, uint, uint*, uint*, IMFTimedTextStyle**, int>)@this->LpVtbl[5])(@this, index, firstCharPtr, charLength, style);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting(uint index, ref uint firstChar, uint* charLength, ref IMFTimedTextStyle* style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetSubformatting(uint index, ref uint firstChar, ref uint charLength, IMFTimedTextStyle** style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetSubformatting(uint index, ref uint firstChar, ref uint charLength, ref IMFTimedTextStyle* style)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetText(string[] textSa)
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var text = (char**) SilkMarshal.StringArrayToPtr(textSa);
            var ret = @this->GetText(text);
            SilkMarshal.CopyPtrToStringArray((nint) text, textSa);
            SilkMarshal.Free((nint) text);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting<TI0>(uint index, uint* firstChar, uint* charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSubformatting(index, firstChar, charLength, (IMFTimedTextStyle**) style.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting<TI0>(uint index, uint* firstChar, ref uint charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSubformatting(index, firstChar, ref charLength, (IMFTimedTextStyle**) style.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubformatting<TI0>(uint index, ref uint firstChar, uint* charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSubformatting(index, ref firstChar, charLength, (IMFTimedTextStyle**) style.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSubformatting<TI0>(uint index, ref uint firstChar, ref uint charLength, ref ComPtr<TI0> style) where TI0 : unmanaged, IComVtbl<IMFTimedTextStyle>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSubformatting(index, ref firstChar, ref charLength, (IMFTimedTextStyle**) style.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextFormattedText*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
