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
    [Guid("db639199-c809-4c89-bfca-d0bbb9729d6e")]
    [NativeName("Name", "IMFTimedTextStyle2")]
    public unsafe partial struct IMFTimedTextStyle2 : IComVtbl<IMFTimedTextStyle2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("db639199-c809-4c89-bfca-d0bbb9729d6e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextStyle2 val)
            => Unsafe.As<IMFTimedTextStyle2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextStyle2
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
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRuby(IMFTimedTextRuby** ruby)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextRuby**, int>)@this->LpVtbl[3])(@this, ruby);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRuby(ref IMFTimedTextRuby* ruby)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextRuby** rubyPtr = &ruby)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextRuby**, int>)@this->LpVtbl[3])(@this, rubyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBouten(IMFTimedTextBouten** bouten)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextBouten**, int>)@this->LpVtbl[4])(@this, bouten);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBouten(ref IMFTimedTextBouten* bouten)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFTimedTextBouten** boutenPtr = &bouten)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, IMFTimedTextBouten**, int>)@this->LpVtbl[4])(@this, boutenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsTextCombined(int* value)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, int*, int>)@this->LpVtbl[5])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTextCombined(ref int value)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, int*, int>)@this->LpVtbl[5])(@this, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontAngleInDegrees(double* value)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, double*, int>)@this->LpVtbl[6])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontAngleInDegrees(ref double value)
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle2*, double*, int>)@this->LpVtbl[6])(@this, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRuby<TI0>(ref ComPtr<TI0> ruby) where TI0 : unmanaged, IComVtbl<IMFTimedTextRuby>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRuby((IMFTimedTextRuby**) ruby.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBouten<TI0>(ref ComPtr<TI0> bouten) where TI0 : unmanaged, IComVtbl<IMFTimedTextBouten>, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBouten((IMFTimedTextBouten**) bouten.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
