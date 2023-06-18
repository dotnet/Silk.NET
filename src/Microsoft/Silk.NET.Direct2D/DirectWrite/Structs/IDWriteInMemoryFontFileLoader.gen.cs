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
    [Guid("dc102f47-a12d-4b1c-822d-9e117e33043f")]
    [NativeName("Name", "IDWriteInMemoryFontFileLoader")]
    public unsafe partial struct IDWriteInMemoryFontFileLoader : IComVtbl<IDWriteInMemoryFontFileLoader>, IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dc102f47-a12d-4b1c-822d-9e117e33043f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileLoader(IDWriteInMemoryFontFileLoader val)
            => Unsafe.As<IDWriteInMemoryFontFileLoader, IDWriteFontFileLoader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteInMemoryFontFileLoader val)
            => Unsafe.As<IDWriteInMemoryFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteInMemoryFontFileLoader
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
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFileCount()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

    }
}
