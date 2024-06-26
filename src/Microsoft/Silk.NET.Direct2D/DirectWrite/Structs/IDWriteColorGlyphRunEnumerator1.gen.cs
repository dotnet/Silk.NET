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
    [Guid("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35")]
    [NativeName("Name", "IDWriteColorGlyphRunEnumerator1")]
    public unsafe partial struct IDWriteColorGlyphRunEnumerator1 : IComVtbl<IDWriteColorGlyphRunEnumerator1>, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("7c5f86da-c7a1-4f05-b8e1-55a179fe5a35");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteColorGlyphRunEnumerator(IDWriteColorGlyphRunEnumerator1 val)
            => Unsafe.As<IDWriteColorGlyphRunEnumerator1, IDWriteColorGlyphRunEnumerator>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteColorGlyphRunEnumerator1 val)
            => Unsafe.As<IDWriteColorGlyphRunEnumerator1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteColorGlyphRunEnumerator1
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
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveNext(int* hasRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, int*, int>)@this->LpVtbl[3])(@this, hasRun);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MoveNext(ref int hasRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* hasRunPtr = &hasRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, int*, int>)@this->LpVtbl[3])(@this, hasRunPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentRun([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorGlyphRun** colorGlyphRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRun);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentRun([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ColorGlyphRun* colorGlyphRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ColorGlyphRun** colorGlyphRunPtr = &colorGlyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator1*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRunPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteColorGlyphRunEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
