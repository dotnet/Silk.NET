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
    [Guid("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c")]
    [NativeName("Name", "IDWriteRemoteFontFileStream")]
    public unsafe partial struct IDWriteRemoteFontFileStream : IComVtbl<IDWriteRemoteFontFileStream>, IComVtbl<IDWriteFontFileStream>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4db3757a-2c72-4ed9-b2b6-1ababe1aff9c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileStream(IDWriteRemoteFontFileStream val)
            => Unsafe.As<IDWriteRemoteFontFileStream, IDWriteFontFileStream>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteRemoteFontFileStream val)
            => Unsafe.As<IDWriteRemoteFontFileStream, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteRemoteFontFileStream
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
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFileFragment(void* fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileSize(ulong* fileSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTime(ulong* lastWriteTime)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocalFileSize(ulong* localFileSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[7])(@this, localFileSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, int* isLocal, ulong* partialSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocal, partialSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Locality GetLocality()
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Locality ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Locality>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragments, fragmentCount, asyncResult);
            return ret;
        }

    }
}
