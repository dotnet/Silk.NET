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
    [Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2")]
    [NativeName("Name", "IDWriteLocalFontFileLoader")]
    public unsafe partial struct IDWriteLocalFontFileLoader : IComVtbl<IDWriteLocalFontFileLoader>, IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileLoader(IDWriteLocalFontFileLoader val)
            => Unsafe.As<IDWriteLocalFontFileLoader, IDWriteFontFileLoader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteLocalFontFileLoader val)
            => Unsafe.As<IDWriteLocalFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteLocalFontFileLoader
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
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathLengthFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTimeFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
            return ret;
        }

    }
}
