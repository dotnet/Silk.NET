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

namespace Silk.NET.DirectStorage
{
    [Guid("84ef5121-9b43-4d03-b5c1-cc34606b262d")]
    [NativeName("Name", "IDStorageCompressionCodec")]
    public unsafe partial struct IDStorageCompressionCodec : IComVtbl<IDStorageCompressionCodec>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("84ef5121-9b43-4d03-b5c1-cc34606b262d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageCompressionCodec val)
            => Unsafe.As<IDStorageCompressionCodec, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageCompressionCodec
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
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompressBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* uncompressedData, nuint uncompressedDataSize, Compression compressionSetting, void* compressedBuffer, nuint compressedBufferSize, nuint* compressedDataSize)
        {
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, Compression, void*, nuint, nuint*, int>)@this->LpVtbl[3])(@this, uncompressedData, uncompressedDataSize, compressionSetting, compressedBuffer, compressedBufferSize, compressedDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecompressBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* compressedData, nuint compressedDataSize, void* uncompressedBuffer, nuint uncompressedBufferSize, nuint* uncompressedDataSize)
        {
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, void*, nuint, void*, nuint, nuint*, int>)@this->LpVtbl[4])(@this, compressedData, compressedDataSize, uncompressedBuffer, uncompressedBufferSize, uncompressedDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint CompressBufferBound(nuint uncompressedDataSize)
        {
            var @this = (IDStorageCompressionCodec*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCompressionCodec*, nuint, nuint>)@this->LpVtbl[5])(@this, uncompressedDataSize);
            return ret;
        }

    }
}
