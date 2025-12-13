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

namespace Silk.NET.Core.Native
{
    [Guid("09b2dfe4-840f-401a-804c-0dd8aadc9e9f")]
    [NativeName("Name", "ID3DShaderCacheInstallerFactory")]
    public unsafe partial struct ID3DShaderCacheInstallerFactory : IComVtbl<ID3DShaderCacheInstallerFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("09b2dfe4-840f-401a-804c-0dd8aadc9e9f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DShaderCacheInstallerFactory val)
            => Unsafe.As<ID3DShaderCacheInstallerFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DShaderCacheInstallerFactory
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
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ID3DShaderCacheInstallerClient* pClient, Guid* riid, void** ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClient, riid, ppvInstaller);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ID3DShaderCacheInstallerClient* pClient, Guid* riid, ref void* ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvInstallerPtr = &ppvInstaller)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClient, riid, ppvInstallerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ID3DShaderCacheInstallerClient* pClient, ref Guid riid, void** ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClient, riidPtr, ppvInstaller);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ID3DShaderCacheInstallerClient* pClient, ref Guid riid, ref void* ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvInstallerPtr = &ppvInstaller)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClient, riidPtr, ppvInstallerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ref ID3DShaderCacheInstallerClient pClient, Guid* riid, void** ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3DShaderCacheInstallerClient* pClientPtr = &pClient)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClientPtr, riid, ppvInstaller);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ref ID3DShaderCacheInstallerClient pClient, Guid* riid, ref void* ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3DShaderCacheInstallerClient* pClientPtr = &pClient)
            {
                fixed (void** ppvInstallerPtr = &ppvInstaller)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClientPtr, riid, ppvInstallerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ref ID3DShaderCacheInstallerClient pClient, ref Guid riid, void** ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3DShaderCacheInstallerClient* pClientPtr = &pClient)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClientPtr, riidPtr, ppvInstaller);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller(ref ID3DShaderCacheInstallerClient pClient, ref Guid riid, ref void* ppvInstaller)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3DShaderCacheInstallerClient* pClientPtr = &pClient)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvInstallerPtr = &ppvInstaller)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, ID3DShaderCacheInstallerClient*, Guid*, void**, int>)@this->LpVtbl[3])(@this, pClientPtr, riidPtr, ppvInstallerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(Silk.NET.Core.Native.IUnknown* pUnknown, Guid* riid, void** ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknown, riid, ppvExplorer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(Silk.NET.Core.Native.IUnknown* pUnknown, Guid* riid, ref void* ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvExplorerPtr = &ppvExplorer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknown, riid, ppvExplorerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(Silk.NET.Core.Native.IUnknown* pUnknown, ref Guid riid, void** ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknown, riidPtr, ppvExplorer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(Silk.NET.Core.Native.IUnknown* pUnknown, ref Guid riid, ref void* ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvExplorerPtr = &ppvExplorer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknown, riidPtr, ppvExplorerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(ref Silk.NET.Core.Native.IUnknown pUnknown, Guid* riid, void** ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknownPtr, riid, ppvExplorer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(ref Silk.NET.Core.Native.IUnknown pUnknown, Guid* riid, ref void* ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                fixed (void** ppvExplorerPtr = &ppvExplorer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknownPtr, riid, ppvExplorerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(ref Silk.NET.Core.Native.IUnknown pUnknown, ref Guid riid, void** ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknownPtr, riidPtr, ppvExplorer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer(ref Silk.NET.Core.Native.IUnknown pUnknown, ref Guid riid, ref void* ppvExplorer)
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvExplorerPtr = &ppvExplorer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DShaderCacheInstallerFactory*, Silk.NET.Core.Native.IUnknown*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pUnknownPtr, riidPtr, ppvExplorerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstaller<TI0, TI1>(ComPtr<TI0> pClient, out ComPtr<TI1> ppvInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstallerClient>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvInstaller = default;
            return @this->CreateInstaller((ID3DShaderCacheInstallerClient*) pClient.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvInstaller.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller<TI0>(ComPtr<TI0> pClient, Guid* riid, ref void* ppvInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstallerClient>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstaller((ID3DShaderCacheInstallerClient*) pClient.Handle, riid, ref ppvInstaller);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller<TI0>(ComPtr<TI0> pClient, ref Guid riid, void** ppvInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstallerClient>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstaller((ID3DShaderCacheInstallerClient*) pClient.Handle, ref riid, ppvInstaller);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstaller<TI0>(ComPtr<TI0> pClient, ref Guid riid, ref void* ppvInstaller) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstallerClient>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstaller((ID3DShaderCacheInstallerClient*) pClient.Handle, ref riid, ref ppvInstaller);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstaller<TI0>(ref ID3DShaderCacheInstallerClient pClient, out ComPtr<TI0> ppvInstaller) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvInstaller = default;
            return @this->CreateInstaller(ref pClient, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvInstaller.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateExplorer<TI0, TI1>(ComPtr<TI0> pUnknown, out ComPtr<TI1> ppvExplorer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvExplorer = default;
            return @this->CreateExplorer((Silk.NET.Core.Native.IUnknown*) pUnknown.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvExplorer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer<TI0>(ComPtr<TI0> pUnknown, Guid* riid, ref void* ppvExplorer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateExplorer((Silk.NET.Core.Native.IUnknown*) pUnknown.Handle, riid, ref ppvExplorer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer<TI0>(ComPtr<TI0> pUnknown, ref Guid riid, void** ppvExplorer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateExplorer((Silk.NET.Core.Native.IUnknown*) pUnknown.Handle, ref riid, ppvExplorer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateExplorer<TI0>(ComPtr<TI0> pUnknown, ref Guid riid, ref void* ppvExplorer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateExplorer((Silk.NET.Core.Native.IUnknown*) pUnknown.Handle, ref riid, ref ppvExplorer);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateExplorer<TI0>(ref Silk.NET.Core.Native.IUnknown pUnknown, out ComPtr<TI0> ppvExplorer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvExplorer = default;
            return @this->CreateExplorer(ref pUnknown, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvExplorer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateInstaller<TI0, TI1>(ComPtr<TI0> pClient) where TI0 : unmanaged, IComVtbl<ID3DShaderCacheInstallerClient>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateInstaller(pClient, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateInstaller<TI0>(ref ID3DShaderCacheInstallerClient pClient) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateInstaller(ref pClient, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateExplorer<TI0, TI1>(ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateExplorer(pUnknown, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateExplorer<TI0>(ref Silk.NET.Core.Native.IUnknown pUnknown) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3DShaderCacheInstallerFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateExplorer(ref pUnknown, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
