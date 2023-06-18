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
    [Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0")]
    [NativeName("Name", "IDWriteFontFile")]
    public unsafe partial struct IDWriteFontFile : IComVtbl<IDWriteFontFile>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("739d886a-cef5-47dc-8769-1a8b41bebbb0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFile val)
            => Unsafe.As<IDWriteFontFile, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFile
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
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReferenceKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, uint* fontFileReferenceKeySize)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLoader(IDWriteFontFileLoader** fontFileLoader)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
            return ret;
        }

    }
}
