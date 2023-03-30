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
    [Guid("b71e6052-5aea-4fa3-832e-f60d431f7e91")]
    [NativeName("Name", "IDWriteFontDownloadQueue")]
    public unsafe partial struct IDWriteFontDownloadQueue : IComVtbl<IDWriteFontDownloadQueue>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b71e6052-5aea-4fa3-832e-f60d431f7e91");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontDownloadQueue val)
            => Unsafe.As<IDWriteFontDownloadQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontDownloadQueue
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
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddListener(IDWriteFontDownloadListener* listener, uint* token)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listener, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddListener(IDWriteFontDownloadListener* listener, ref uint token)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* tokenPtr = &token)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listener, tokenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddListener(ref IDWriteFontDownloadListener listener, uint* token)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontDownloadListener* listenerPtr = &listener)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listenerPtr, token);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddListener(ref IDWriteFontDownloadListener listener, ref uint token)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontDownloadListener* listenerPtr = &listener)
            {
                fixed (uint* tokenPtr = &token)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, IDWriteFontDownloadListener*, uint*, int>)@this->LpVtbl[3])(@this, listenerPtr, tokenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveListener(uint token)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, uint, int>)@this->LpVtbl[4])(@this, token);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsEmpty()
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Bool32>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDownload(Silk.NET.Core.Native.IUnknown* context)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, context);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDownload(ref Silk.NET.Core.Native.IUnknown context)
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* contextPtr = &context)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, contextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CancelDownload()
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, int>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetGenerationCount()
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontDownloadQueue*, ulong>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddListener<TI0>(ComPtr<TI0> listener, uint* token) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadListener>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddListener((IDWriteFontDownloadListener*) listener.Handle, token);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddListener<TI0>(ComPtr<TI0> listener, ref uint token) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadListener>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddListener((IDWriteFontDownloadListener*) listener.Handle, ref token);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDownload<TI0>(ComPtr<TI0> context) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDownload((Silk.NET.Core.Native.IUnknown*) context.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontDownloadQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
