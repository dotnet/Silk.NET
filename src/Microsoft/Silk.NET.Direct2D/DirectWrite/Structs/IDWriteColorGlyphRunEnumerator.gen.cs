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
    [Guid("d31fbe17-f157-41a2-8d24-cb779e0560e8")]
    [NativeName("Name", "IDWriteColorGlyphRunEnumerator")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator : IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d31fbe17-f157-41a2-8d24-cb779e0560e8");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteColorGlyphRunEnumerator val)
            => Unsafe.As<IDWriteColorGlyphRunEnumerator, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteColorGlyphRunEnumerator
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
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveNext(int* hasRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, int*, int>)@this->LpVtbl[3])(@this, hasRun);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MoveNext(ref int hasRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasRunPtr = &hasRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, int*, int>)@this->LpVtbl[3])(@this, hasRunPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentRun([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorGlyphRun** colorGlyphRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRun);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentRun([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorGlyphRun* colorGlyphRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ColorGlyphRun** colorGlyphRunPtr = &colorGlyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRunPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
