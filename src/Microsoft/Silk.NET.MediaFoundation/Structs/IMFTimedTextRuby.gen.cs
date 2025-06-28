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
    [Guid("76c6a6f5-4955-4de5-b27b-14b734cc14b4")]
    [NativeName("Name", "IMFTimedTextRuby")]
    public unsafe partial struct IMFTimedTextRuby : IComVtbl<IMFTimedTextRuby>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("76c6a6f5-4955-4de5-b27b-14b734cc14b4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextRuby val)
            => Unsafe.As<IMFTimedTextRuby, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextRuby
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
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRubyText(char** rubyText)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, char**, int>)@this->LpVtbl[3])(@this, rubyText);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRubyText(ref char* rubyText)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** rubyTextPtr = &rubyText)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, char**, int>)@this->LpVtbl[3])(@this, rubyTextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRubyPosition(TimedTextRubyPosition* value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyPosition*, int>)@this->LpVtbl[4])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRubyPosition(ref TimedTextRubyPosition value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextRubyPosition* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyPosition*, int>)@this->LpVtbl[4])(@this, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRubyAlign(TimedTextRubyAlign* value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyAlign*, int>)@this->LpVtbl[5])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRubyAlign(ref TimedTextRubyAlign value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextRubyAlign* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyAlign*, int>)@this->LpVtbl[5])(@this, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRubyReserve(TimedTextRubyReserve* value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyReserve*, int>)@this->LpVtbl[6])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRubyReserve(ref TimedTextRubyReserve value)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextRubyReserve* valuePtr = &value)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRuby*, TimedTextRubyReserve*, int>)@this->LpVtbl[6])(@this, valuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRubyText(string[] rubyTextSa)
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var rubyText = (char**) SilkMarshal.StringArrayToPtr(rubyTextSa);
            var ret = @this->GetRubyText(rubyText);
            SilkMarshal.CopyPtrToStringArray((nint) rubyText, rubyTextSa);
            SilkMarshal.Free((nint) rubyText);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextRuby*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
