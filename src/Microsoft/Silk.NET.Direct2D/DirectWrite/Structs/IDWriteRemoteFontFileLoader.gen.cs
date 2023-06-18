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
    [Guid("68648c83-6ede-46c0-ab46-20083a887fde")]
    [NativeName("Name", "IDWriteRemoteFontFileLoader")]
    public unsafe partial struct IDWriteRemoteFontFileLoader : IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("68648c83-6ede-46c0-ab46-20083a887fde");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileLoader(IDWriteRemoteFontFileLoader val)
            => Unsafe.As<IDWriteRemoteFontFileLoader, IDWriteFontFileLoader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteRemoteFontFileLoader val)
            => Unsafe.As<IDWriteRemoteFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteRemoteFontFileLoader
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
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRemoteStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteRemoteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, IDWriteRemoteFontFileStream**, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocalityFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Locality* locality)
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, void*, uint, Locality*, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, locality);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReferenceFromUrl(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFileUrl, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteRemoteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileLoader*, IDWriteFactory*, char*, char*, IDWriteFontFile**, int>)@this->LpVtbl[6])(@this, factory, baseUrl, fontFileUrl, fontFile);
            return ret;
        }

    }
}
