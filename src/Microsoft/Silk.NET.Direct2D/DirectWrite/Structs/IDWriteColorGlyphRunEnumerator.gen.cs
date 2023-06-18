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
        public readonly unsafe int GetCurrentRun([Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorGlyphRun** colorGlyphRun)
        {
            var @this = (IDWriteColorGlyphRunEnumerator*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteColorGlyphRunEnumerator*, ColorGlyphRun**, int>)@this->LpVtbl[4])(@this, colorGlyphRun);
            return ret;
        }

    }
}
