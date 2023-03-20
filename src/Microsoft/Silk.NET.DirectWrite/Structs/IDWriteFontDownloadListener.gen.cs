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
    [Guid("b06fe5b9-43ec-4393-881b-dbe4dc72fda7")]
    [NativeName("Name", "IDWriteFontDownloadListener")]
    public unsafe partial struct IDWriteFontDownloadListener : IComVtbl<IDWriteFontDownloadListener>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b06fe5b9-43ec-4393-881b-dbe4dc72fda7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontDownloadListener val)
            => Unsafe.As<IDWriteFontDownloadListener, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontDownloadListener
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
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, Silk.NET.Core.Native.IUnknown* context, int downloadResult)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int, void>)@this->LpVtbl[3])(@this, downloadQueue, context, downloadResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DownloadCompleted(IDWriteFontDownloadQueue* downloadQueue, ref Silk.NET.Core.Native.IUnknown context, int downloadResult)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Core.Native.IUnknown* contextPtr = &context)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int, void>)@this->LpVtbl[3])(@this, downloadQueue, contextPtr, downloadResult);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DownloadCompleted(ref IDWriteFontDownloadQueue downloadQueue, Silk.NET.Core.Native.IUnknown* context, int downloadResult)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteFontDownloadQueue* downloadQueuePtr = &downloadQueue)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int, void>)@this->LpVtbl[3])(@this, downloadQueuePtr, context, downloadResult);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DownloadCompleted(ref IDWriteFontDownloadQueue downloadQueue, ref Silk.NET.Core.Native.IUnknown context, int downloadResult)
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteFontDownloadQueue* downloadQueuePtr = &downloadQueue)
            {
                fixed (Silk.NET.Core.Native.IUnknown* contextPtr = &context)
                {
                    ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadListener*, IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int, void>)@this->LpVtbl[3])(@this, downloadQueuePtr, contextPtr, downloadResult);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void DownloadCompleted<TI0, TI1>(ComPtr<TI0> downloadQueue, ComPtr<TI1> context, int downloadResult) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadQueue>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DownloadCompleted((IDWriteFontDownloadQueue*) downloadQueue.Handle, (Silk.NET.Core.Native.IUnknown*) context.Handle, downloadResult);
        }

        /// <summary>To be documented.</summary>
        public readonly void DownloadCompleted<TI0>(ComPtr<TI0> downloadQueue, ref Silk.NET.Core.Native.IUnknown context, int downloadResult) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadQueue>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DownloadCompleted((IDWriteFontDownloadQueue*) downloadQueue.Handle, ref context, downloadResult);
        }

        /// <summary>To be documented.</summary>
        public readonly void DownloadCompleted<TI0>(ref IDWriteFontDownloadQueue downloadQueue, ComPtr<TI0> context, int downloadResult) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->DownloadCompleted(ref downloadQueue, (Silk.NET.Core.Native.IUnknown*) context.Handle, downloadResult);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadListener*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
