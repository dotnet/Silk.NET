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
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
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
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentContextPtr = &fragmentContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentStartPtr = &fragmentStart)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentStartPtr = &fragmentStart)
            {
                fixed (void** fragmentContextPtr = &fragmentContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFileFragment(void* fragmentContext)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseFileFragment<T0>(ref T0 fragmentContext) where T0 : unmanaged
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* fragmentContextPtr = &fragmentContext)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContextPtr);
            }
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
        public readonly int GetFileSize(ref ulong fileSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fileSizePtr = &fileSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSizePtr);
            }
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
        public readonly int GetLastWriteTime(ref ulong lastWriteTime)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTimePtr);
            }
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
        public readonly int GetLocalFileSize(ref ulong localFileSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* localFileSizePtr = &localFileSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong*, int>)@this->LpVtbl[7])(@this, localFileSizePtr);
            }
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
        public readonly unsafe int GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, int* isLocal, ref ulong partialSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* partialSizePtr = &partialSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocal, partialSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, ref int isLocal, ulong* partialSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocalPtr, partialSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileFragmentLocality(ulong fileOffset, ulong fragmentSize, ref int isLocal, ref ulong partialSize)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isLocalPtr = &isLocal)
            {
                fixed (ulong* partialSizePtr = &partialSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, ulong, ulong, int*, ulong*, int>)@this->LpVtbl[8])(@this, fileOffset, fragmentSize, isLocalPtr, partialSizePtr);
                }
            }
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

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragments, fragmentCount, asyncResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FileFragment* fileFragmentsPtr = &fileFragments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragmentsPtr, fragmentCount, asyncResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FileFragment* fileFragmentsPtr = &fileFragments)
            {
                fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationID, fileFragmentsPtr, fragmentCount, asyncResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragments, fragmentCount, asyncResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
            {
                fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragments, fragmentCount, asyncResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, IDWriteAsyncResult** asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
            {
                fixed (FileFragment* fileFragmentsPtr = &fileFragments)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragmentsPtr, fragmentCount, asyncResult);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, ref IDWriteAsyncResult* asyncResult)
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* downloadOperationIDPtr = &downloadOperationID)
            {
                fixed (FileFragment* fileFragmentsPtr = &fileFragments)
                {
                    fixed (IDWriteAsyncResult** asyncResultPtr = &asyncResult)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteRemoteFontFileStream*, Guid*, FileFragment*, uint, IDWriteAsyncResult**, int>)@this->LpVtbl[10])(@this, downloadOperationIDPtr, fileFragmentsPtr, fragmentCount, asyncResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDownload(downloadOperationID, fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDownload(downloadOperationID, in fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FileFragment* fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDownload(in downloadOperationID, fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDownload<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid downloadOperationID, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FileFragment fileFragments, uint fragmentCount, ref ComPtr<TI0> asyncResult) where TI0 : unmanaged, IComVtbl<IDWriteAsyncResult>, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDownload(in downloadOperationID, in fileFragments, fragmentCount, (IDWriteAsyncResult**) asyncResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteRemoteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
